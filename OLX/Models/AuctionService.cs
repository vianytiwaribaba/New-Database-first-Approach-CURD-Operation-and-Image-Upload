using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLX.Models
{
    public class AuctionService
    {
        public void SaveAuction(tbl_Auction auction)
        {
            OLXDBContext context = new OLXDBContext();

            context.tbl_Auction.Add(auction);

            context.SaveChanges();
        }

        public List<tbl_Auction> Listing()
        {
            OLXDBContext context = new OLXDBContext();

            return context.tbl_Auction.ToList();

        }

        public tbl_Auction EditAuction(int ID)
        {
            OLXDBContext context = new OLXDBContext();

            return context.tbl_Auction.Find(ID);
        }

        public void SaveEdit(tbl_Auction auction)
        {
            OLXDBContext context = new OLXDBContext();

            context.Entry(auction).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();
        }

        public void DeleteAuction(tbl_Auction auction)
        {
            OLXDBContext context = new OLXDBContext();

            context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;

            context.SaveChanges();
        }


    }
}