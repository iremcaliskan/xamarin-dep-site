using System;
using System.Collections.Generic;
using System.Text;

namespace App13
{
    public class Derslik
    {
        public string DerslikAdı { get; set; }
        public string Kapasite { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return DerslikAdı;
        }

    }
}
