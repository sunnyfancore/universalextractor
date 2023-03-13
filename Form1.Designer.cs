using System.Windows.Forms;

namespace UniversalExtractor
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.utxtTargetPath = new Sunny.UI.UITextBox();
            this.ulblTargetPath = new Sunny.UI.UILabel();
            this.ucdgSelectTypes = new Sunny.UI.UIComboDataGridView();
            this.ulblSelectType = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.utxtOutputPath = new Sunny.UI.UITextBox();
            this.ubtnStart = new Sunny.UI.UIButton();
            this.dgv = new Sunny.UI.UISuperGrid();
            this.ubtnStop = new Sunny.UI.UIButton();
            this.ubtnLoad = new Sunny.UI.UIButton();
            this.urtxtTips = new Sunny.UI.UIRichTextBox();
            this.ubtnDelete = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // utxtTargetPath
            // 
            this.utxtTargetPath.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtTargetPath.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.utxtTargetPath.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.utxtTargetPath.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtTargetPath.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.utxtTargetPath.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.utxtTargetPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtTargetPath.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.utxtTargetPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.utxtTargetPath.Location = new System.Drawing.Point(100, 40);
            this.utxtTargetPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtTargetPath.MinimumSize = new System.Drawing.Size(1, 16);
            this.utxtTargetPath.Name = "utxtTargetPath";
            this.utxtTargetPath.ReadOnly = true;
            this.utxtTargetPath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtTargetPath.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtTargetPath.ShowButton = true;
            this.utxtTargetPath.ShowText = false;
            this.utxtTargetPath.Size = new System.Drawing.Size(332, 29);
            this.utxtTargetPath.Style = Sunny.UI.UIStyle.LayuiRed;
            this.utxtTargetPath.TabIndex = 0;
            this.utxtTargetPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.utxtTargetPath.Watermark = "请选择目标文件夹...";
            this.utxtTargetPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.utxtTargetPath.ButtonClick += new System.EventHandler(this.utxtTargetPath_ButtonClick);
            // 
            // ulblTargetPath
            // 
            this.ulblTargetPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ulblTargetPath.Location = new System.Drawing.Point(3, 46);
            this.ulblTargetPath.Name = "ulblTargetPath";
            this.ulblTargetPath.Size = new System.Drawing.Size(90, 23);
            this.ulblTargetPath.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ulblTargetPath.TabIndex = 1;
            this.ulblTargetPath.Text = "目标路径：";
            this.ulblTargetPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ulblTargetPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ucdgSelectTypes
            // 
            this.ucdgSelectTypes.DropDownStyle = Sunny.UI.UIDropDownStyle.DropDownList;
            this.ucdgSelectTypes.FillColor = System.Drawing.Color.White;
            this.ucdgSelectTypes.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.ucdgSelectTypes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucdgSelectTypes.Location = new System.Drawing.Point(536, 40);
            this.ucdgSelectTypes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucdgSelectTypes.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucdgSelectTypes.Name = "ucdgSelectTypes";
            this.ucdgSelectTypes.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucdgSelectTypes.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ucdgSelectTypes.Size = new System.Drawing.Size(290, 29);
            this.ucdgSelectTypes.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ucdgSelectTypes.TabIndex = 2;
            this.ucdgSelectTypes.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucdgSelectTypes.Watermark = "请选择类型...";
            this.ucdgSelectTypes.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ucdgSelectTypes.ValueChanged += new Sunny.UI.UIComboDataGridView.OnValueChanged(this.ucdgSelectTypes_ValueChanged);
            // 
            // ulblSelectType
            // 
            this.ulblSelectType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ulblSelectType.Location = new System.Drawing.Point(439, 46);
            this.ulblSelectType.Name = "ulblSelectType";
            this.ulblSelectType.Size = new System.Drawing.Size(90, 23);
            this.ulblSelectType.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ulblSelectType.TabIndex = 3;
            this.ulblSelectType.Text = "选择类型：";
            this.ulblSelectType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ulblSelectType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 94);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(90, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.LayuiRed;
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "输出路径：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // utxtOutputPath
            // 
            this.utxtOutputPath.ButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtOutputPath.ButtonFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.utxtOutputPath.ButtonFillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.utxtOutputPath.ButtonRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtOutputPath.ButtonRectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.utxtOutputPath.ButtonRectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.utxtOutputPath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.utxtOutputPath.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.utxtOutputPath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.utxtOutputPath.Location = new System.Drawing.Point(100, 88);
            this.utxtOutputPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.utxtOutputPath.MinimumSize = new System.Drawing.Size(1, 16);
            this.utxtOutputPath.Name = "utxtOutputPath";
            this.utxtOutputPath.ReadOnly = true;
            this.utxtOutputPath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtOutputPath.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.utxtOutputPath.ShowButton = true;
            this.utxtOutputPath.ShowText = false;
            this.utxtOutputPath.Size = new System.Drawing.Size(332, 29);
            this.utxtOutputPath.Style = Sunny.UI.UIStyle.LayuiRed;
            this.utxtOutputPath.TabIndex = 5;
            this.utxtOutputPath.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.utxtOutputPath.Watermark = "请选择输出文件夹...";
            this.utxtOutputPath.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.utxtOutputPath.ButtonClick += new System.EventHandler(this.utxtOutputPath_ButtonClick);
            // 
            // ubtnStart
            // 
            this.ubtnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnStart.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnStart.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnStart.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStart.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnStart.Location = new System.Drawing.Point(553, 82);
            this.ubtnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnStart.Name = "ubtnStart";
            this.ubtnStart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnStart.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnStart.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStart.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStart.Size = new System.Drawing.Size(83, 35);
            this.ubtnStart.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ubtnStart.TabIndex = 6;
            this.ubtnStart.Text = "提取文件";
            this.ubtnStart.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ubtnStart.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // dgv
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(110)))), ((int)(((byte)(64)))));
            this.dgv.Location = new System.Drawing.Point(7, 191);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(222)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.dgv.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.dgv.ScrollBarRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.dgv.SelectedIndex = -1;
            this.dgv.Size = new System.Drawing.Size(820, 351);
            this.dgv.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.dgv.Style = Sunny.UI.UIStyle.LayuiRed;
            this.dgv.TabIndex = 7;
            this.dgv.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ubtnStop
            // 
            this.ubtnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnStop.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnStop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnStop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnStop.Location = new System.Drawing.Point(656, 82);
            this.ubtnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnStop.Name = "ubtnStop";
            this.ubtnStop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnStop.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnStop.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStop.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnStop.Size = new System.Drawing.Size(76, 35);
            this.ubtnStop.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ubtnStop.TabIndex = 8;
            this.ubtnStop.Text = "终止";
            this.ubtnStop.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnStop.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ubtnStop.Click += new System.EventHandler(this.ubtnStop_Click);
            // 
            // ubtnLoad
            // 
            this.ubtnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnLoad.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnLoad.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnLoad.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnLoad.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnLoad.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnLoad.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnLoad.Location = new System.Drawing.Point(443, 82);
            this.ubtnLoad.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnLoad.Name = "ubtnLoad";
            this.ubtnLoad.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnLoad.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnLoad.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnLoad.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnLoad.Size = new System.Drawing.Size(86, 35);
            this.ubtnLoad.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ubtnLoad.TabIndex = 9;
            this.ubtnLoad.Text = "加载";
            this.ubtnLoad.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnLoad.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ubtnLoad.Click += new System.EventHandler(this.ubtnLoad_Click);
            // 
            // urtxtTips
            // 
            this.urtxtTips.FillColor = System.Drawing.Color.White;
            this.urtxtTips.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(240)))));
            this.urtxtTips.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.urtxtTips.Location = new System.Drawing.Point(7, 121);
            this.urtxtTips.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.urtxtTips.MinimumSize = new System.Drawing.Size(1, 1);
            this.urtxtTips.Name = "urtxtTips";
            this.urtxtTips.Padding = new System.Windows.Forms.Padding(2);
            this.urtxtTips.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.urtxtTips.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.urtxtTips.ShowText = false;
            this.urtxtTips.Size = new System.Drawing.Size(819, 62);
            this.urtxtTips.Style = Sunny.UI.UIStyle.LayuiRed;
            this.urtxtTips.TabIndex = 10;
            this.urtxtTips.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.urtxtTips.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ubtnDelete
            // 
            this.ubtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ubtnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnDelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnDelete.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnDelete.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnDelete.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnDelete.Location = new System.Drawing.Point(750, 82);
            this.ubtnDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.ubtnDelete.Name = "ubtnDelete";
            this.ubtnDelete.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ubtnDelete.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.ubtnDelete.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnDelete.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(70)))), ((int)(((byte)(28)))));
            this.ubtnDelete.Size = new System.Drawing.Size(76, 35);
            this.ubtnDelete.Style = Sunny.UI.UIStyle.LayuiRed;
            this.ubtnDelete.TabIndex = 11;
            this.ubtnDelete.Text = "删除";
            this.ubtnDelete.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ubtnDelete.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ubtnDelete.Click += new System.EventHandler(this.ubtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(830, 545);
            this.ControlBoxFillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(78)))));
            this.Controls.Add(this.ubtnDelete);
            this.Controls.Add(this.urtxtTips);
            this.Controls.Add(this.ubtnLoad);
            this.Controls.Add(this.ubtnStop);
            this.Controls.Add(this.ubtnStart);
            this.Controls.Add(this.utxtOutputPath);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.ulblSelectType);
            this.Controls.Add(this.ucdgSelectTypes);
            this.Controls.Add(this.ulblTargetPath);
            this.Controls.Add(this.utxtTargetPath);
            this.Controls.Add(this.dgv);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.Style = Sunny.UI.UIStyle.LayuiRed;
            this.Text = "文件提取器";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 741, 431);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UITextBox utxtTargetPath;
        private Sunny.UI.UILabel ulblTargetPath;
        private Sunny.UI.UIComboDataGridView ucdgSelectTypes;
        private Sunny.UI.UILabel ulblSelectType;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox utxtOutputPath;
        private Sunny.UI.UIButton ubtnStart;
        private Sunny.UI.UISuperGrid dgv;
        private Sunny.UI.UIButton ubtnStop;
        private Sunny.UI.UIButton ubtnLoad;
        private Sunny.UI.UIRichTextBox urtxtTips;
        private Sunny.UI.UIButton ubtnDelete;
    }
}

