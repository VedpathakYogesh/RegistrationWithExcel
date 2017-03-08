using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace DptsData.Models
{
    public class DownLoadFileInformation
    {
        public int FileId { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
    }
    public class DownloadFiles
    {
        public List<DownLoadFileInformation> GetFiles()
        {
            List<DownLoadFileInformation> lstFiles = new List<DownLoadFileInformation>();
            DirectoryInfo dirInfo = new DirectoryInfo(HostingEnvironment.MapPath("~/Contents"));

            int i = 0;
            foreach (var item in dirInfo.GetFiles())
            {
                lstFiles.Add(new DownLoadFileInformation()
                {

                    FileId = i + 1,
                    FileName = item.Name,
                    FilePath = dirInfo.FullName + @"Contents\" + item.Name
                });
                i = i + 1;
            }
            return lstFiles;
        }

        //public FileResult Download(String p, String d)
        //{
        //    return File(Path.Combine(Server.MapPath("~/Contents"), p), System.Net.Mime.MediaTypeNames.Application.Octet, d);
        //}
    }
}