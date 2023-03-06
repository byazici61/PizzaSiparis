using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSiparis.DTO
{
  public  class Pizza
    {
        public Pizza()
        {
            Malzemeleri = new List<Malzeme>();
        }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public List<Malzeme> Malzemeleri { get; set; }
        public override string ToString()
        {
            return Adi.ToUpper();
        }
    }
}
