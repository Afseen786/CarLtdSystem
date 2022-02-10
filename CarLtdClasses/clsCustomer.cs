using System;

namespace CarLtdClasses
{
    public class clsCustomer
    {
        public bool Active { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PostCode { get; set; }
        public string Address { get; set; }
    }
}