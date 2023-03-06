using PizzaSiparis.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis.UI
{
    public partial class FrmRapor : Form
    {
        List<Siparis> siparislerListesi; 
        public FrmRapor()
        {
            InitializeComponent();
        }
        public FrmRapor(List<Siparis> siparislerinListesi):this()
        {
            this.siparislerListesi = siparislerinListesi;


        }
        private void FrmRapor_Load(object sender, EventArgs e)
        {
            int adet = 0;
            int kayseriadet = 0;
            int egeliadet = 0;
            //bugüne kadar yapılmış en fazla adet olan pizzasını bulalı.
            foreach (Siparis item in siparislerListesi)
            {
                foreach (var siparisDetay in item.SiparisinDetaylari)
                {
                    if (siparisDetay.SecilmisPizza.Adi == "Karışık Pizza")
                    {
                        adet += siparisDetay.SiparisEdilecekPizzaAdedi;
                    }
                    if (siparisDetay.SecilmisPizza.Adi == "Kayseri Ateşi Pizza")
                    {
                        kayseriadet += siparisDetay.SiparisEdilecekPizzaAdedi;
                    }
                    if (siparisDetay.SecilmisPizza.Adi == "Egeli Pizza")
                    {
                        egeliadet += siparisDetay.SiparisEdilecekPizzaAdedi;
                    }

                }
                //Karışık Pizza
                //Kayseri Ateşi Pizza
                //Egeli Pizza
            }

            
            this.Text = "Karışık Pizza toplam satış adeti " + adet;
            if (adet>egeliadet && adet >kayseriadet)
            {
                //adet buyuk
            }
            else if (egeliadet > adet  && egeliadet > kayseriadet)
            {
                //egeliadet büyük

            }
            else
            {
                //karışık büyük


            }

        }
    }
}
