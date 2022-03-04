using System;

namespace CarLtdClasses
{
    public class clsOrder
    {
        public bool Active { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderNo { get; set; }
        public string OrderName { get; set; }
        public string OrderStatus { get; set; }
        public string BillingAddress { get; set; }
    }
}