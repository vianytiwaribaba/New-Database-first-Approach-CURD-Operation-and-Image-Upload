using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLX.Models
{
    public class SharedServices
    {
        public int SavePicture(tbl_Picture picture)
        {
            OLXDBContext context = new OLXDBContext();

            context.tbl_Picture.Add(picture);

            context.SaveChanges();

            return picture.PicID;
        }
    }    
}