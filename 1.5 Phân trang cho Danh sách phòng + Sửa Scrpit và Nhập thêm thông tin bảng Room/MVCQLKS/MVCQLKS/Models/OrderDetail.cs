//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCQLKS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int OrderID { get; set; }
        public int C_RoomID { get; set; }
        public int Quantity { get; set; }
        public int StatusForeignCus { get; set; }
        public int AdditionalFee { get; set; }
        public System.DateTime OrderCheckOut { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
