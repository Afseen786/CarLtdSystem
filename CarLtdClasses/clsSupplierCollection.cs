using CarLtdTesting;
using System.Collections.Generic;

namespace CarLtdClasses
{
    public class clsSupplierCollection
    {
        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        public List<clsSupplier> SupplierList
        {
            get
            {
                //return the private data
                return mSupplierList;
            }
            set
            {
                //set the private data
                mSupplierList = value;
            }

        }

        public int Count
        {
            get
            {
                //return the count of the list
                return mSupplierList.Count;
            }
            set
            {
                //later

            }
        }
        public clsSupplier ThisSupplier { get; set; }
    }
}
