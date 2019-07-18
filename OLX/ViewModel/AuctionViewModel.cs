using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLX.ViewModel
{
    public class AuctionViewModel
    {
        public int AuctionID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public System.DateTime StartingTime { get; set; }
        public System.DateTime EndingTime { get; set; }

        public string tbl_AuctionPicture { get; set; }

    }
}