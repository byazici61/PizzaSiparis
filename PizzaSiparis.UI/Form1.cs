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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pizzaları doldur.
            PizzaDoldur();
            //ekstra malzemeleri doldur.
            EkstraMalzemeleriDoldur();
            groupBox1.Enabled = btnSiparisiTamamla.Enabled = false;


        }

        private void EkstraMalzemeleriDoldur()
        {
            flMalzemeler.Controls.Add(new CheckBox() { Text = "Mısır", Tag = new Malzeme() { MalzemeAdi = "Mısır", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "Kornişon Turşu", Tag = new Malzeme() { MalzemeAdi = "Kornişon Turşu", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "Salam", Tag = new Malzeme() { MalzemeAdi = "Salam", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "sosis", Tag = new Malzeme() { MalzemeAdi = "sosis", MalzemeFiyati = 5 } });
            flMalzemeler.Controls.Add(new CheckBox() { Text = "yeşil zeytin", Tag = new Malzeme() { MalzemeAdi = "yeşil zeytin", MalzemeFiyati = 5 } });
        }

        private void PizzaDoldur()
        {
            //datasource
            cmbPizzalar.Items.AddRange((new List<Pizza>() {
            new Pizza()
            {
                Adi="Karışık Pizza",
                Fiyati=20,
                Malzemeleri= new List<Malzeme>(){
                    new Malzeme() { MalzemeAdi="Sucuk",MalzemeFiyati=5},
                    new Malzeme() { MalzemeAdi = "Salam", MalzemeFiyati = 5 },
                    new Malzeme() { MalzemeAdi = "Sosis", MalzemeFiyati = 5 } }
            },
          new Pizza()
            {
                Adi="Kayseri Ateşi Pizza",
                Fiyati=50,
                Malzemeleri= new List<Malzeme>(){
                    new Malzeme() { MalzemeAdi="Pastırma",MalzemeFiyati=5},
                    new Malzeme() { MalzemeAdi = "Kavurma", MalzemeFiyati = 5 },
                    new Malzeme() { MalzemeAdi = "Sosis", MalzemeFiyati = 5 } }
            },
          new Pizza()
            {
                Adi="Egeli Pizza",
                Fiyati=30,
                Malzemeleri= new List<Malzeme>(){
                    new Malzeme() { MalzemeAdi="Domates",MalzemeFiyati=5},
                    new Malzeme() { MalzemeAdi = "Peynir", MalzemeFiyati = 5 },
                    new Malzeme() { MalzemeAdi = "Roka", MalzemeFiyati = 5 } }
            }}).ToArray());
        }

        private void cmbPizzalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pizza secilen = cmbPizzalar.SelectedItem as Pizza;
            //lblIcerik.Text = secilen.Malzemeleri.Add(;
            string s = null;
            foreach (var item in secilen.Malzemeleri)
            {
                s += item.MalzemeAdi + " ";
            }
            lblIcerik.Text = s;
        }

        private void btnAraToplamHesapla_Click(object sender, EventArgs e)
        {
            sipDetay = new SiparisDetayi();
            sipDetay.SecilmisPizza = cmbPizzalar.SelectedItem as Pizza;

            #region MyRegion
            //sipDetay.SecilmisPizza = rdpBuyukBoy.Checked == true
            //    ?sipDetay.SecilmisPizza.Fiyati*4
            //    :rdpOrtaBoy.Checked == true
            //        ? sipDetay.SecilmisPizza.Fiyati * 2
            //        : sipDetay.SecilmisPizza.Fiyati * 1;

            #endregion
            sipDetay.SecilmisEbat = new Ebat()
            {
                EbatAdi = rdpBuyukBoy.Checked == true
                ? "Büyük"
                : rdpOrtaBoy.Checked == true
                    ? "Orta"
                    : "Küçük"
            };
            sipDetay.SiparisEdilecekPizzaAdedi = Convert.ToInt32(nmAdet.Value);

            sipDetay.EkstraPizzayaEklenecekMalzemeler = EkstralarıBul();
            lblAraToplam.Text = AraToplamHesapla(sipDetay);



        }

        private string AraToplamHesapla(SiparisDetayi sipDetay)
        {
            double ebatlıPizzaninFiyati = sipDetay.SecilmisEbat.EbatAdi == "Orta"
                           ? sipDetay.SecilmisPizza.Fiyati * 2
                           : sipDetay.SecilmisEbat.EbatAdi == "Büyük"
                               ? sipDetay.SecilmisPizza.Fiyati * 4
                               : sipDetay.SecilmisPizza.Fiyati * 1;
            //Lambda expression
            double malzemeFiyatlariToplami = sipDetay.EkstraPizzayaEklenecekMalzemeler.Sum(a => a.MalzemeFiyati);
            return ((ebatlıPizzaninFiyati + malzemeFiyatlariToplami) * sipDetay.SiparisEdilecekPizzaAdedi).ToString() + " TL";

        }

        List<Malzeme> listem = new List<Malzeme>();
        private List<Malzeme> EkstralarıBul()
        {
            foreach (CheckBox item in flMalzemeler.Controls)
            {   //todo eğer hiç ekstra malzeme eklemezse ne olacak kontrolü yapılmalı.
                if (item.Checked)
                {
                    listem.Add((Malzeme)item.Tag);
                }


            }
            return listem;


        }
        //todo mbox da adet ve ara toplamı soyleyerek mesaj veriniz. 3 ürünn toplamda 200 lira
        SiparisDetayi sipDetay = new SiparisDetayi();
        List<SiparisDetayi> sepet = new List<SiparisDetayi>();
        private void btnSepeteAt_Click(object sender, EventArgs e)
        {
            if (sipDetay != null)
            {
                // todo sepeti lontrol et aynı üründen varsa ürünün sadecei adetini değiştir
                if (SepetiKontolEt(sipDetay))
                {
                    sepet.Add(sipDetay);
                }
                //sepet.Add(sipDetay);
                MessageBox.Show("Ürünler Sepete eklendi.");
                groupBox1.Enabled = btnSiparisiTamamla.Enabled = true;
                btnSepet.Text = sepet.Count + " ürün sepete eklendi.";
                sipDetay = null;
                FormuTemizle();

            }
            else MessageBox.Show("Pizza Seçiniz;");

        }

        private bool SepetiKontolEt(SiparisDetayi sipDetay)
        {
            foreach (SiparisDetayi item in sepet)
            {
                if (sipDetay.SecilmisPizza.Adi == item.SecilmisPizza.Adi)
                {
                    item.SiparisEdilecekPizzaAdedi += sipDetay.SiparisEdilecekPizzaAdedi;
                    return false;
                }
            }
            return true;

        }

        //todo formu temizle
        private void FormuTemizle()
        {

        }
        List<Siparis> siparislerinListesi = new List<Siparis>();
        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            //dialogResult
            DialogResult dg = MessageBox.Show("Sipraişi vermek istediğinizden emin misiniz?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                
                siparislerinListesi.Add(new Siparis()
                {
                    Adres = txtAdresBilgisi.Text,
                    SiparisTarihi = DateTime.Now,
                    SiparisiVerenKullaniciAdiSoyadi = txtAdSoyad.Text,
                    SiparisinDetaylari = sepet

                });
                //todo her eklmeden daha önce eklenen pizzların üzerine eklenmesi içn ve countu doğru dönmesi için kontol yap
                MessageBox.Show(string.Format("{0} çeşit pizzanız, {1} TL değerindedir. Adresinize teslim edilcektir", siparislerinListesi.Count, siparislerinListesi.Sum(a =>a.ToplamTutar)));

                //siparislerinListesi.ForEach(a => a.SiparisinDetaylari.Where(x => x.SecilmisPizza.Adi == "Karışık Pizza").Sum());
                //siparislerinListesi.ForEach(listem.Add(x=>x);

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRapor fm = new FrmRapor(siparislerinListesi);
            fm.Show();
        }
    }
}
