using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalExtractor.Model
{
    internal class FileDto
    {
        public string Id { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public TimeSpan FileDuration { get; set; }

        public long FileSize01 { get; set; }

        public string FileSize { get; set; }

        public string FileStatus { get; set; }

    }
}
