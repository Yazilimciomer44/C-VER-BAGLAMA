using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veri_bağlama_uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class ogrenciler
        {
            public int numara { get; set; }
            public string adSoyad { get; set; }
            public string Alan { get; set; }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVeriBağla_Click(object sender, EventArgs e)
        {
            ogrenciler ogr = new ogrenciler();
            ogr.numara = 1111;
            ogr.adSoyad = "Mehmet";
            ogr.Alan = "Bilişim Teknolojileri";
            txtNumara.DataBindings.Add("Text", ogr, "Numara");
            txtAdSoyad.DataBindings.Add("Text", ogr, "AdSoyad");
            txtAlan.DataBindings.Add("Text", ogr, "Alan");

        }
    }
}
