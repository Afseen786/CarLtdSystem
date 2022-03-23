using CarLtdTesting;
using System.Collections.Generic;

namespace CarLtdClasses
{
    public class clsSupplierCollection
    {
        //private data member for the list
        List<clsSupplier> mSuplierList = new List<clsSupplier>();
        //public property for the address list


        public int Count
        {
            get
            {
                return mSuplierList.Count;
            }
            set
            {

            }


        }

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSuplierList;
            }
            set
            {
                mSuplierList = value;
            }
        }

        public clsSupplier ThisSupplier { get; set; }
    }
}