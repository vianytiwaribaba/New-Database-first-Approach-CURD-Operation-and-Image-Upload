//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OLX
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_AuctionPicture
    {
        public int ID { get; set; }
        public Nullable<int> PicID { get; set; }
        public Nullable<int> AuctionID { get; set; }
    
        public virtual tbl_Auction tbl_Auction { get; set; }
        public virtual tbl_Picture tbl_Picture { get; set; }
    }
}
