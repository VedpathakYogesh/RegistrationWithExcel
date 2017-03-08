using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DptsData.Models
{
    public class FileNames
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileExt { get; set; }
        public string DirName { get; set; }
        public string FileNameWithExt { get; set; }
    }
}