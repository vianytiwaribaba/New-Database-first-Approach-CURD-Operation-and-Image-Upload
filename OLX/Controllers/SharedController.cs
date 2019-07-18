using OLX.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OLX.Controllers
{
    public class SharedController : Controller
    {
        SharedServices services = new SharedServices();

        // GET: Shared
        [HttpPost]
        public JsonResult UploadPictures()
        {

            JsonResult result = new JsonResult();

            List<object> pictureJSON = new List<object>();


            var pictures = Request.Files;

            for (int i = 0; i < pictures.Count; i++)
            {
                var picture = pictures[i];

                var fileName = Guid.NewGuid() + Path.GetExtension(picture.FileName);

                var path = Server.MapPath("~/Content/Image/") + fileName;

                picture.SaveAs(path);

                picture.SaveAs(path);

                var dbpicture = new tbl_Picture();

                dbpicture.URL = fileName;

                var pictureID = services.SavePicture(dbpicture);

                pictureJSON.Add(new { ID = pictureID, pictureURL = fileName });
            }

            result.Data = pictureJSON;

            return result;
        }
    }
}