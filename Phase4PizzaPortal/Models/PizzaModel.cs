using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Phase4PizzaPortal.Models
{
    public class PizzaModel
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PCrustSize { get; set; }
        public string PDesc { get; set; }
        public decimal PPrice { get; set; }
        public string PImage { get; set; }
    }
}
