using OLX.Models;
using OLX.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OLX.Controllers
{
   
    public class AuctionController : Controller
    {
        AuctionService service = new AuctionService();

        // GET: Auction
        public ActionResult Index()
        {
            var list = service.Listing();

            if (Request.IsAjaxRequest())
            {
                return PartialView(list);
            }
            else
            {
                return View(list);
            }

           
        }

        public ActionResult create()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult create(AuctionViewModel model)
        {
            tbl_Auction auction = new tbl_Auction();

            auction.Title = model.Title;

            auction.Description = model.Description;

            auction.ActualAmount = model.ActualAmount;

            auction.StartingTime = model.StartingTime;

            auction.EndingTime = model.EndingTime;


            var pictureIDs = model.tbl_AuctionPicture.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            auction.tbl_AuctionPicture = new List<tbl_AuctionPicture>();

            foreach (var picID in pictureIDs)
            {
                var auctionPicture = new tbl_AuctionPicture();

                auctionPicture.PicID = picID;


                auction.tbl_AuctionPicture.Add(auctionPicture);
            }



            service.SaveAuction(auction);

            return RedirectToAction("Index");
        }

        public ActionResult Edit(int ID)
        {
            var auction = service.EditAuction(ID);

            return PartialView(auction);
        }

        [HttpPost]
        public ActionResult Edit(tbl_Auction auction)
        {
            service.SaveEdit(auction);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int ID)
        {
            var auction = service.EditAuction(ID);

            return View(auction);
        }

        [HttpPost]
        public ActionResult Delete(tbl_Auction auction)
        {
            service.DeleteAuction(auction);

            return View(auction);
        }
    }
}