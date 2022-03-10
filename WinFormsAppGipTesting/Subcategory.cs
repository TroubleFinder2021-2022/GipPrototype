using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppGipTesting
{
    class Subcategory
    {
        public string strSubcategory { get; set; }
        public int intSubcategoryID { get; set; }

        public Subcategory(string strSubcategory, int intSubcategoryID)
        {
            this.strSubcategory = strSubcategory;
            this.intSubcategoryID = intSubcategoryID;
        }
    }
}
