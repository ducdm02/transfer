//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrintOrder
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public long id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string content { get; set; }
        public double price { get; set; }
        public double price2 { get; set; }
        public long shopID { get; set; }
        public string thumb { get; set; }
        public System.DateTime created { get; set; }
        public Nullable<System.DateTime> updated { get; set; }
        public bool Status { get; set; }
        public int CategoryID { get; set; }
        public bool isShowHome { get; set; }
        public string unit { get; set; }
        public string unit_type { get; set; }
    }
}
