using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DptsData.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFile
        public ActionResult Index()
        {
            return View();
        }

        private bool isValidContentType(string contenttype)
        {
            return contenttype.Equals("image/png") || contenttype.Equals("image/gif") ||
                contenttype.Equals("image/jpg") || contenttype.Equals("image/jpeg");
        }

        private bool isValidContentLength(int contentLength)
        {
            return ((contentLength / 1024) / 1024) < 1; // 1MB max
        }
        [HttpPost]
        public ActionResult Process(HttpPostedFileBase Photo)
        {
            if (!isValidContentType(Photo.ContentType))
            {
                ViewBag.Error = "Image Not Uploaded only JPEG /JPG/PNG/GIF FILE ARE ALLOWED.";
                return View("Index");
            }
            else if (!isValidContentLength(Photo.ContentLength))
            {
                ViewBag.Error = "Photosize Should be 1MB Max .";
                return View("Index");
            }
            // Length Checking
            else
            {
                if (Photo.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(Photo.FileName);
                    var path= Path.Combine(Server.MapPath("~/Contents/Images"),fileName);
                    Photo.SaveAs(path);
                    ViewBag.filName = Photo.FileName;
                }
                ViewBag.fileName = Photo.FileName;
                return View("Success");
            }
                 
            }
        }
    }
