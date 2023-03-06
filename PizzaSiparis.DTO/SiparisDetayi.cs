using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSiparis.DTO
{
  public  class SiparisDetayi
    {
        public SiparisDetayi()
        {
            EkstraPizzayaEklenecekMalzemeler = new List<Malzeme>();
        }
       
        public Pizza SecilmisPizza { get; set; }
        public Ebat SecilmisEbat { get; set; }
        public List<Malzeme> EkstraPizzayaEklenecekMalzemeler { get; set; }
        public int SiparisEdilecekPizzaAdedi { get; set; }
    }
}
