using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Item.Add ile
            //comboBoxDoldurV1();

            //.DataSource ile
            comboBoxDoldurV2();

        }

        private void comboBoxDoldurV1()
        {
            foreach (var item in database.urunTablo)
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        private void comboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = database.urunTablo;
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            object o1 = (object)cmbUrunListe.SelectedItem;
            urun urunListe = (urun)o1;

            pictureBox1.Image = Image.FromFile(urunListe.urunResim);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = urunListe.urunAdi;
            txtUrunKategori.Text = urunListe.urunKategori;
            txtUrunStok.Text = Convert.ToString(urunListe.urunStok);
            txtYazar.Text = urunListe.yazar;
            richTextBox1.Text = urunListe.aciklama;


        }
    }
}
