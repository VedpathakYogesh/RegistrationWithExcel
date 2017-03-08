using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DptsData.Models;
using System.IO;
using System.Net;

namespace DptsData.Controllers
{
    public class FileProcessController : Controller
    {
        // GET: FileProcess
        //public ActionResult Index()
        //{
        //    return View();
        //}
        DownloadFiles obj;
        public FileProcessController()
        {
            obj = new DownloadFiles();
        }

        public ActionResult Index()
        {
            var filesCollection = obj.GetFiles();
            return View(filesCollection);
        }

        public FileResult Download(string FileID)
        {
            int CurrentFileID = Convert.ToInt32(FileID);
            var filesCol = obj.GetFiles();
            string CurrentFileName = (from fls in filesCol
                                      where fls.FileId == CurrentFileID
                                      select fls.FilePath).First();
            //FileID.Delete(FileID);


            string contentType = string.Empty;

            if (CurrentFileName.Contains(".csv"))
            {
                contentType = "application/pdf";
            }

            else if (CurrentFileName.Contains(".docx"))
            {
                contentType = "application/docx";
            }
            return File(CurrentFileName, contentType, CurrentFileName);
        }


        public ActionResult Edit()
        {
            return View();
        }
        public FileResult downloadFile()
        {


            //return new FilePathResult(Server.MapPath(@"~/Contents/.csv"), "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
            return new FilePathResult(Server.MapPath("/Contents/dummy.docx"), "application/vnd.openxmlformats-officedocument.wordprocessingml.document");
        }
        //[HttpPost]
        //[ValidateAntiForgeryToken]


        //public ActionResult DeletePhoto(string photoFileName)
        //{
        //    return View();
        //}

        //public ActionResult DeletePhoto(string photoFileName)
        //{

        //    ViewBag.deleteSuccess = "false";
        //    var fileName = "";
        //    fileName = photoFileName;
        //    var fullPath = Server.MapPath("~/Contents/" + fileName);

        //    if (File.Exists(fullPath))
        //    {
        //        File.Delete(fullPath);
        //        ViewBag.deleteSuccess = "true";

        //    }
        //}


    //    public ActionResult Index()
    //    {
    //        string[] dirs = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + @"Contents\", "*.*");
    //        return View(dirs.ToList());
    //    }
    //    {
    //    string path = AppDomain.CurrentDomain.BaseDirectory + "Contents/";
    //    string fileName = fileNameWithExtention;
    //        return File(path + fileName, "text/plain", "test.txt");
    //}


    }

    }

