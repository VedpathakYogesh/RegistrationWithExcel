﻿//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Web;
//using System.Web.Hosting;

//namespace DptsData.Models
//{
//    public class DataClasses
//    {
//        public List<FileNames> GetFiles()
//        {

//            List<FileNames> lstFiles = new List<FileNames>();
//            DirectoryInfo dirInfo = new DirectoryInfo(HostingEnvironment.MapPath("~/Contents"));

//            int i = 0;
//            foreach (var item in dirInfo.GetFiles())
//            {

//                lstFiles.Add(new FileNames()
//                {

//                    FileId = i + 1,
//                    FileName = item.Name,
//                    FilePath = dirInfo.FullName + @"\" + item.Name
//                });
//                i = i + 1;
//            }

//            return lstFiles;
//        }
//    }
//    public class FileNames
//    {
//        public int FileId { get; set; }
//        public string FileName { get; set; }
//        public string FilePath { get; set; }
//    }
//}
//    }
//}