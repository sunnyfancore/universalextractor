using MediaToolkit.Model;
using MediaToolkit;
using System;

namespace UniversalExtractor
{
    internal class Utils
    {
        public static string ConvertFileSize(long size)
        {
            string result = "0KB";
            int filelength = size.ToString().Length;
            if (filelength < 4)
                result = size + "byte";
            else if (filelength < 7)
                result = Math.Round(Convert.ToDouble(size / 1024d), 2) + "KB";
            else if (filelength < 10)
                result = Math.Round(Convert.ToDouble(size / 1024d / 1024), 2) + "MB";
            else if (filelength < 13)
                result = Math.Round(Convert.ToDouble(size / 1024d / 1024 / 1024), 2) + "GB";
            else
                result = Math.Round(Convert.ToDouble(size / 1024d / 1024 / 1024 / 1024), 2) + "TB";
            return result;
        }

        public static TimeSpan GetFileDuration(string Filename, Engine engine)
        {
            TimeSpan timeSpan = new TimeSpan(0, 0, 0);
            var inputFile2 = new MediaFile { Filename = Filename };
            try
            {
                engine.GetMetadata(inputFile2);
                timeSpan = inputFile2.Metadata.Duration;
            }
            catch (Exception)
            {
            }
            return timeSpan;
        }
    }
}
