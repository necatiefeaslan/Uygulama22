using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama22
{
    public partial class Form1 : Form
    {
        ArrayList kaynakVeri = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKitapekle_Click(object sender, EventArgs e)
        {
            Kitaplar kitap = new Kitaplar();
            kitap.KitapAdi = txtKitapAdi.Text;
            kitap.KitapYazari = txtKitapYazarı.Text;
            kitap.KitapTuru = txtKitapTürü.Text;
            kaynakVeri.Add(kitap);
            kaynakVeri.Add(kitap.KitapYazari);
            kaynakVeri.Add(kitap.KitapTuru);
           

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listeVeri.DataSource = null;
            listeVeri.DataSource = kaynakVeri;
            listeVeri.DisplayMember = "KitapAdi";
           

        }
    }
    class Kitaplar
    {
        public string KitapAdi { get; set; }
        public string KitapYazari { get; set; }
        public string KitapTuru { get; set; }
    }
}
