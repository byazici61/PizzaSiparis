using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaSiparis.DTO
{
    public class Siparis
    {
        public Siparis()
        {
            SiparisinDetaylari = new List<SiparisDetayi>();
        }
        public string Adres { get; set; }
        public string SiparisiVerenKullaniciAdiSoyadi { get; set; }
        public DateTime SiparisTarihi { get; set; }
        public List<SiparisDetayi> SiparisinDetaylari { get; set; }
        private double _ToplamTutar = 0;
        public double ToplamTutar
        {
            get
            {
                foreach (SiparisDetayi item in SiparisinDetaylari)
                {
                    double ebatlıPizzaninFiyati = item.SecilmisEbat.EbatAdi == "Orta"
                          ? item.SecilmisPizza.Fiyati * 2
                          : item.SecilmisEbat.EbatAdi == "Büyük"
                              ? item.SecilmisPizza.Fiyati * 4
                              : item.SecilmisPizza.Fiyati * 1;
                    //Lambda expression
                    double malzemeFiyatlariToplami = item.EkstraPizzayaEklenecekMalzemeler.Sum(a => a.MalzemeFiyati);

                    _ToplamTutar += (ebatlıPizzaninFiyati + malzemeFiyatlariToplami) * item.SiparisEdilecekPizzaAdedi;
                }
                return _ToplamTutar;
            }
        }
    }
}
