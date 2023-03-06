
namespace PizzaSiparis.UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbPizzalar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIcerik = new System.Windows.Forms.Label();
            this.rdpKucukBoy = new System.Windows.Forms.RadioButton();
            this.rdpOrtaBoy = new System.Windows.Forms.RadioButton();
            this.rdpBuyukBoy = new System.Windows.Forms.RadioButton();
            this.flMalzemeler = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nmAdet = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAraToplam = new System.Windows.Forms.Label();
            this.btnSepeteAt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdresBilgisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSiparisiTamamla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAraToplamHesapla = new System.Windows.Forms.Button();
            this.btnSepet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPizzalar
            // 
            this.cmbPizzalar.FormattingEnabled = true;
            this.cmbPizzalar.Location = new System.Drawing.Point(138, 71);
            this.cmbPizzalar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPizzalar.Name = "cmbPizzalar";
            this.cmbPizzalar.Size = new System.Drawing.Size(180, 21);
            this.cmbPizzalar.TabIndex = 0;
            this.cmbPizzalar.SelectedIndexChanged += new System.EventHandler(this.cmbPizzalar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Seçiniz";
            // 
            // lblIcerik
            // 
            this.lblIcerik.AutoSize = true;
            this.lblIcerik.Location = new System.Drawing.Point(154, 106);
            this.lblIcerik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIcerik.Name = "lblIcerik";
            this.lblIcerik.Size = new System.Drawing.Size(102, 13);
            this.lblIcerik.TabIndex = 2;
            this.lblIcerik.Text = "Pizzaİçerik Bilgileri : ";
            // 
            // rdpKucukBoy
            // 
            this.rdpKucukBoy.AutoSize = true;
            this.rdpKucukBoy.Checked = true;
            this.rdpKucukBoy.Location = new System.Drawing.Point(51, 159);
            this.rdpKucukBoy.Margin = new System.Windows.Forms.Padding(2);
            this.rdpKucukBoy.Name = "rdpKucukBoy";
            this.rdpKucukBoy.Size = new System.Drawing.Size(77, 17);
            this.rdpKucukBoy.TabIndex = 3;
            this.rdpKucukBoy.TabStop = true;
            this.rdpKucukBoy.Text = "Küçük Boy";
            this.rdpKucukBoy.UseVisualStyleBackColor = true;
            // 
            // rdpOrtaBoy
            // 
            this.rdpOrtaBoy.AutoSize = true;
            this.rdpOrtaBoy.Location = new System.Drawing.Point(147, 159);
            this.rdpOrtaBoy.Margin = new System.Windows.Forms.Padding(2);
            this.rdpOrtaBoy.Name = "rdpOrtaBoy";
            this.rdpOrtaBoy.Size = new System.Drawing.Size(63, 17);
            this.rdpOrtaBoy.TabIndex = 3;
            this.rdpOrtaBoy.Text = "OrtaBoy";
            this.rdpOrtaBoy.UseVisualStyleBackColor = true;
            // 
            // rdpBuyukBoy
            // 
            this.rdpBuyukBoy.AutoSize = true;
            this.rdpBuyukBoy.Location = new System.Drawing.Point(244, 159);
            this.rdpBuyukBoy.Margin = new System.Windows.Forms.Padding(2);
            this.rdpBuyukBoy.Name = "rdpBuyukBoy";
            this.rdpBuyukBoy.Size = new System.Drawing.Size(76, 17);
            this.rdpBuyukBoy.TabIndex = 3;
            this.rdpBuyukBoy.Text = "Büyük Boy";
            this.rdpBuyukBoy.UseVisualStyleBackColor = true;
            // 
            // flMalzemeler
            // 
            this.flMalzemeler.Location = new System.Drawing.Point(51, 225);
            this.flMalzemeler.Margin = new System.Windows.Forms.Padding(2);
            this.flMalzemeler.Name = "flMalzemeler";
            this.flMalzemeler.Size = new System.Drawing.Size(275, 130);
            this.flMalzemeler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 203);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekta Malzeme Seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Adet Giriniz : ";
            // 
            // nmAdet
            // 
            this.nmAdet.Location = new System.Drawing.Point(102, 368);
            this.nmAdet.Margin = new System.Windows.Forms.Padding(2);
            this.nmAdet.Name = "nmAdet";
            this.nmAdet.Size = new System.Drawing.Size(79, 20);
            this.nmAdet.TabIndex = 7;
            this.nmAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 373);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ara Toplam:";
            // 
            // lblAraToplam
            // 
            this.lblAraToplam.AutoSize = true;
            this.lblAraToplam.Location = new System.Drawing.Point(302, 372);
            this.lblAraToplam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAraToplam.Name = "lblAraToplam";
            this.lblAraToplam.Size = new System.Drawing.Size(13, 13);
            this.lblAraToplam.TabIndex = 8;
            this.lblAraToplam.Text = "0";
            // 
            // btnSepeteAt
            // 
            this.btnSepeteAt.Location = new System.Drawing.Point(250, 396);
            this.btnSepeteAt.Margin = new System.Windows.Forms.Padding(2);
            this.btnSepeteAt.Name = "btnSepeteAt";
            this.btnSepeteAt.Size = new System.Drawing.Size(76, 39);
            this.btnSepeteAt.TabIndex = 9;
            this.btnSepeteAt.Text = "Sepete Ekle";
            this.btnSepeteAt.UseVisualStyleBackColor = true;
            this.btnSepeteAt.Click += new System.EventHandler(this.btnSepeteAt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdresBilgisi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(383, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(216, 319);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura Bilgileri Giriniz ";
            // 
            // txtAdresBilgisi
            // 
            this.txtAdresBilgisi.Location = new System.Drawing.Point(79, 89);
            this.txtAdresBilgisi.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresBilgisi.Multiline = true;
            this.txtAdresBilgisi.Name = "txtAdresBilgisi";
            this.txtAdresBilgisi.Size = new System.Drawing.Size(134, 158);
            this.txtAdresBilgisi.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(79, 45);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(127, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ad Soyad";
            // 
            // btnSiparisiTamamla
            // 
            this.btnSiparisiTamamla.Location = new System.Drawing.Point(523, 396);
            this.btnSiparisiTamamla.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiparisiTamamla.Name = "btnSiparisiTamamla";
            this.btnSiparisiTamamla.Size = new System.Drawing.Size(76, 39);
            this.btnSiparisiTamamla.TabIndex = 9;
            this.btnSiparisiTamamla.Text = "Siparişi Tamamla";
            this.btnSiparisiTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisiTamamla.Click += new System.EventHandler(this.btnSiparisiTamamla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(241, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sipariş Ekranı";
            // 
            // btnAraToplamHesapla
            // 
            this.btnAraToplamHesapla.Location = new System.Drawing.Point(186, 368);
            this.btnAraToplamHesapla.Name = "btnAraToplamHesapla";
            this.btnAraToplamHesapla.Size = new System.Drawing.Size(24, 23);
            this.btnAraToplamHesapla.TabIndex = 12;
            this.btnAraToplamHesapla.Text = "button1";
            this.btnAraToplamHesapla.UseVisualStyleBackColor = true;
            this.btnAraToplamHesapla.Click += new System.EventHandler(this.btnAraToplamHesapla_Click);
            // 
            // btnSepet
            // 
            this.btnSepet.Location = new System.Drawing.Point(412, 24);
            this.btnSepet.Name = "btnSepet";
            this.btnSepet.Size = new System.Drawing.Size(300, 31);
            this.btnSepet.TabIndex = 13;
            this.btnSepet.Text = "0";
            this.btnSepet.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 458);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "GEÇ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 535);
            this.Controls.Add(this.btnSepet);
            this.Controls.Add(this.btnAraToplamHesapla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSiparisiTamamla);
            this.Controls.Add(this.btnSepeteAt);
            this.Controls.Add(this.lblAraToplam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmAdet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flMalzemeler);
            this.Controls.Add(this.rdpBuyukBoy);
            this.Controls.Add(this.rdpOrtaBoy);
            this.Controls.Add(this.rdpKucukBoy);
            this.Controls.Add(this.lblIcerik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPizzalar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPizzalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIcerik;
        private System.Windows.Forms.RadioButton rdpKucukBoy;
        private System.Windows.Forms.RadioButton rdpOrtaBoy;
        private System.Windows.Forms.RadioButton rdpBuyukBoy;
        private System.Windows.Forms.FlowLayoutPanel flMalzemeler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nmAdet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAraToplam;
        private System.Windows.Forms.Button btnSepeteAt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdresBilgisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSiparisiTamamla;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAraToplamHesapla;
        private System.Windows.Forms.Button btnSepet;
        private System.Windows.Forms.Button button1;
    }
}

