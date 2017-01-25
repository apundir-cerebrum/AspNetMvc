using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laoshi.WCF
{
    public class response<T> where T:class
    {
        public int code { get; set; }
        public string status { get; set; }
        public List<T> result { get; set; }
    }
}