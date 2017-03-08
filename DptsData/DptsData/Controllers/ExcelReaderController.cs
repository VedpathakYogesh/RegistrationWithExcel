using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DptsData.Controllers
{
    public class ExcelReaderController : Controller
    {
        // GET: ExcelReader
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Upload()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upload(HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {

                if (upload != null && upload.ContentLength > 0)
                {

                    if (upload.FileName.EndsWith(".csv"))
                    {
                        Stream stream = upload.InputStream;
                        DataTable csvTable = new DataTable();
                        using (CsvReader csvReader =
                            new CsvReader(new StreamReader(stream), true))
                        {
                            csvTable.Load(csvReader);
                        }
                        return View(csvTable);
                    }
                    else
                    {
                        ModelState.AddModelError("File", "This file format is not supported");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("File", "Please Upload Your file");
                }
            }
            return View();
        }

        //public FileActionResult Downloadss()
        //{
        //    var dir = new System.IO.DirectoryInfo(Server.MapPath("~/App_Data/Images/"));
        //    System.IO.FileInfo[] fileNames = dir.GetFiles("*.*");
        //    List<string> items = new List<string>();

        //    foreach (var file in fileNames)
        //    {
        //        items.Add(file.Name);
        //    }

        //    return View(items);
        //}

    }
}