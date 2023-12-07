using MediaToolkit;
using MediaToolkit.Model;
using Sunny.UI;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversalExtractor.Model;


namespace UniversalExtractor
{
    public partial class Form1 : Sunny.UI.UIForm
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void utxtTargetPath_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                utxtTargetPath.Text = dilog.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(utxtTargetPath.Text);
                FileInfo[] fileInfos = dir.GetFiles(".", SearchOption.AllDirectories);

                if (fileInfos.Length > 0)
                {

                    List<string> extList = fileInfos.Select(a => a.Extension).Distinct().ToList();

                    DataTable dt = new DataTable();
                    dt.Columns.Add("ExtName", typeof(string));


                    foreach (string ext in extList)
                    {
                        dt.Rows.Add(ext);
                    }

                    ucdgSelectTypes.DataGridView.DataSource = dt;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ucdgSelectTypes.DataGridView.Init();
            ucdgSelectTypes.DataGridView.MultiSelect = true;//设置可多选
            ucdgSelectTypes.ItemSize = new System.Drawing.Size(320, 240);
            ucdgSelectTypes.DataGridView.AddColumn("文件类型", "ExtName");
            ucdgSelectTypes.DataGridView.ReadOnly = true;
            ucdgSelectTypes.ShowFilter = true;
            ucdgSelectTypes.FilterColumnName = "ExtName"; //不设置则全部列过滤

            DataGridViewColumn dataGridViewColumn = dgv.AddColumn("Id", "Id");
            dataGridViewColumn.Visible = false;
            dgv.AddColumn("文件名称", "FileName");
            dgv.AddColumn("物理路径", "FilePath");
            dgv.AddColumn("大小", "FileSize");
            dgv.AddColumn("时长", "FileDuration");
            dgv.AddColumn("状态", "FileStatus", 80);
            dgv.Init();

            ubtnStart.Enabled = false;
            ubtnStop.Enabled = false;
        }

        private void ucdgSelectTypes_ValueChanged(object sender, object value)
        {
            ucdgSelectTypes.Text = "";
            if (value != null && value is DataGridViewSelectedRowCollection)
            {
                DataGridViewSelectedRowCollection collection = (DataGridViewSelectedRowCollection)value;
                foreach (var item in collection)
                {
                    DataGridViewRow row = (DataGridViewRow)item;
                    ucdgSelectTypes.Text += row.Cells["文件类型"].Value.ToString();
                    ucdgSelectTypes.Text += "; ";
                }
            }
        }

        private void utxtOutputPath_ButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog dilog = new FolderBrowserDialog();
            dilog.Description = "请选择文件夹";
            if (dilog.ShowDialog() == DialogResult.OK || dilog.ShowDialog() == DialogResult.Yes)
            {
                utxtOutputPath.Text = dilog.SelectedPath;
            }
        }


        BindingList<FileDto> fileDtos = null;
        CancellationTokenSource cts = null;
        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(utxtTargetPath.Text))
            {
                this.ShowErrorTip("请选择目标文件路径");
                return;
            }

            if (string.IsNullOrEmpty(utxtOutputPath.Text))
            {
                this.ShowErrorTip("请选择输出文件路径");
                return;
            }

            if (string.IsNullOrEmpty(ucdgSelectTypes.Text))
            {
                this.ShowErrorTip("请选择文件类型");
                return;
            }

            if (fileDtos == null || fileDtos.Count < 1)
            {
                this.ShowErrorTip("无可提取文件");
                return;
            }

            if (fileDtos.Count > 0)
            {
                ubtnLoad.Enabled = false;
                ubtnStart.Enabled = false;
                ubtnStop.Enabled = true;

                cts = new CancellationTokenSource();
                ParallelOptions po = new ParallelOptions();
                po.CancellationToken = cts.Token;
                po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        ParallelLoopResult parallelLoopResult = Parallel.ForEach(fileDtos, po, (file) =>
                        {
                            file.FileStatus = "提取中...";
                            try
                            {
                                File.Copy(file.FilePath, $"{utxtOutputPath.Text}\\{file.FileName}", true);
                                file.FileStatus = "提取完成";
                                Thread.Sleep(200);
                                this.dgv.DataSource = fileDtos;
                                dgv.Refresh();
                                this.Invalidate();
                                po.CancellationToken.ThrowIfCancellationRequested();
                            }
                            catch
                            {
                                file.FileStatus = "提取失败";
                                this.dgv.DataSource = fileDtos;
                            }
                        });
                        if (parallelLoopResult.IsCompleted)
                        {
                            this.ShowSuccessTip("提取完成！");
                            this.dgv.DataSource = fileDtos;
                            dgv.Refresh();
                            ubtnLoad.Enabled = true;
                            ubtnStart.Enabled = true;
                            ubtnStop.Enabled = false;
                            this.Invalidate();
                        }
                    }
                    catch (Exception)
                    {
                        this.ShowSuccessTip("已终止！");
                        this.dgv.DataSource = fileDtos;
                        dgv.Refresh();
                        this.Invalidate();

                        ubtnLoad.Enabled = true;
                        ubtnStart.Enabled = true;
                        ubtnStop.Enabled = false;
                    }
                    finally
                    {
                        cts.Dispose();
                    }
                });
            }
        }

        private void ubtnStop_Click(object sender, EventArgs e)
        {
            ubtnStop.Enabled = false;
            if (cts != null)
            {
                cts.Cancel();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }


        private void ubtnLoad_Click(object sender, EventArgs e)
        {

            string dmark = "";
            int fileCount = 0;
            long fileSize = 0;
            TimeSpan timeSpan = new TimeSpan(0, 0, 0, 0);
            if (string.IsNullOrEmpty(utxtTargetPath.Text))
            {
                this.ShowErrorTip("请选择目标文件路径");
                return;
            }

            if (string.IsNullOrEmpty(ucdgSelectTypes.Text))
            {
                this.ShowErrorTip("请选择文件类型");
                return;
            }
            ubtnLoad.Enabled = false;

            try
            {
                DirectoryInfo dir = new DirectoryInfo(utxtTargetPath.Text);
                FileInfo[] fileInfos = dir.GetFiles(".", SearchOption.AllDirectories);

                if (fileInfos.Length > 0)
                {
                    cts = new CancellationTokenSource();
                    ParallelOptions po = new ParallelOptions();
                    po.CancellationToken = cts.Token;
                    po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
                    List<string> types = ucdgSelectTypes.Text.Split(";").Select(a => a.Trim()).Where(a => !string.IsNullOrEmpty(a)).ToList();
                    List<FileInfo> files = fileInfos.Where(a => types.Contains(a.Extension)).ToList();
                    fileDtos = new BindingList<FileDto>();
                    FileDto fileDto = null;
                    foreach (FileInfo item in files)
                    {
                        fileDto = new FileDto();
                        fileDto.Id = System.Guid.NewGuid().ToString().ToUpper();
                        fileDto.FileName = item.Name;
                        fileDto.FilePath = item.FullName;
                        fileDto.FileSize = Utils.ConvertFileSize(item.Length);
                        fileDto.FileStatus = "未开始";
                        fileDto.FileSize01 = item.Length;
                        fileDtos.Add(fileDto);
                    }

                    this.dgv.DataSource = fileDtos;
                    dgv.Refresh();


                    Engine engine = new Engine();
                    this.urtxtTips.AutoScroll = true;
                    this.urtxtTips.ReadOnly = true;
                    this.urtxtTips.AppendText("统计时长开始" + "\r\n");

                    Task.Factory.StartNew(() =>
                {
                    try
                    {
                        ParallelLoopResult parallelLoopResult = Parallel.ForEach(fileDtos, po, (item) =>
                        {
                            try
                            {
                                item.FileDuration = Utils.GetFileDuration(item.FilePath, engine);

                                this.Invoke(new Action(() =>
                                {
                                    this.urtxtTips.AppendText($"文件：{item.FileName}" + "\r\n");
                                }));
                                Thread.Sleep(50);
                            }
                            catch
                            {

                            }
                            po.CancellationToken.ThrowIfCancellationRequested();
                        });
                        if (parallelLoopResult.IsCompleted)
                        {
                            this.dgv.DataSource = fileDtos;
                            if (fileDtos.Count() > 0)
                            {
                                fileCount = fileDtos.Count;
                                timeSpan = new TimeSpan(fileDtos.Sum(a => a.FileDuration.Ticks));
                                fileSize = fileDtos.Sum(a => a.FileSize01);

                                dmark = $"共：{fileCount}个文件，总计大小：{Utils.ConvertFileSize(fileSize)},总计时长：{Math.Round(timeSpan.TotalHours, 2)}时";
                                this.urtxtTips.AppendText(dmark + "\r\n");
                            }
                            ubtnStart.Enabled = true;
                            dgv.Refresh();
                            this.Invalidate();
                            cts.Dispose();
                            engine.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        this.ShowSuccessTip("已终止！");
                        this.dgv.DataSource = fileDtos;

                        if (fileDtos.Count() > 0)
                        {
                            fileCount = fileDtos.Count;
                            timeSpan = new TimeSpan(fileDtos.Sum(a => a.FileDuration.Ticks));
                            fileSize = fileDtos.Sum(a => a.FileSize01);

                            dmark = $"共：{fileCount}个文件，总计大小：{Utils.ConvertFileSize(fileSize)},总计时长：{Math.Round(timeSpan.TotalHours, 2)}时";
                            this.urtxtTips.AppendText(dmark + "\r\n");
                        }
                    }
                });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {

                ubtnLoad.Enabled = true;
                ubtnStop.Enabled = false;
            }
        }

        private void ubtnDelete_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(utxtTargetPath.Text))
            {
                this.ShowErrorTip("请选择目标文件路径");
                return;
            }

            if (string.IsNullOrEmpty(ucdgSelectTypes.Text))
            {
                this.ShowErrorTip("请选择文件类型");
                return;
            }
            try
            {
                ubtnDelete.Enabled = false;
                DirectoryInfo dir = new DirectoryInfo(utxtTargetPath.Text);
                FileInfo[] fileInfos = dir.GetFiles(".", SearchOption.AllDirectories);

                if (fileInfos.Length > 0)
                {
                    cts = new CancellationTokenSource();
                    ParallelOptions po = new ParallelOptions();
                    po.CancellationToken = cts.Token;
                    po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;

                    List<string> types = ucdgSelectTypes.Text.Split(";").ToList();
                    List<FileInfo> files = fileInfos.Where(a => types.Contains(a.Extension)).ToList();

                    this.urtxtTips.AutoScroll = true;
                    this.urtxtTips.ReadOnly = true;
                    this.urtxtTips.AppendText("开时删除:" + "\r\n");

                    Task.Factory.StartNew(() =>
                    {
                        try
                        {
                            ParallelLoopResult parallelLoopResult = Parallel.ForEach(files, po, (item) =>
                            {
                                try
                                {
                                    if (File.Exists(item.FullName))
                                    {
                                        File.Delete(item.FullName);
                                    }
                                    this.urtxtTips.AppendText($"删除文件:{item.Name}" + "\r\n");
                                    Thread.Sleep(50);
                                }
                                catch
                                {

                                }
                                po.CancellationToken.ThrowIfCancellationRequested();
                            });
                            if (parallelLoopResult.IsCompleted)
                            {
                                this.urtxtTips.AppendText("删除完成" + "\r\n");
                            }
                        }
                        catch (Exception)
                        {
                            this.ShowSuccessTip("已终止！");
                        }
                    });
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ubtnDelete.Enabled = true;
            }
        }
    }
}
