using System;

namespace Northwind.Domain.Core.Entities
{
    public partial class SummaryOfSalesByYear
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
