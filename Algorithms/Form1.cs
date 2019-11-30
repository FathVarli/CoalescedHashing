using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Functions.Abstract;
using Functions.Concrete;
using Functions.DependecyReselvor.Ninject;


namespace Algorithms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _function = InstanceFactory.GetInstance<IFunction>();

        }
        IFunction _function;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ara_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void frmAlgorithms_Load(object sender, EventArgs e)
        {

        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[10];
            _function.RandomSayiUret(sayilar);
            lblsayi1.Text = Convert.ToString(sayilar[0]);
            lblsayi2.Text = Convert.ToString(sayilar[1]);
            lblsayi3.Text = Convert.ToString(sayilar[2]);
            lblsayi4.Text = Convert.ToString(sayilar[3]);
            lblsayi5.Text = Convert.ToString(sayilar[4]);
            lblsayi6.Text = Convert.ToString(sayilar[5]);
            lblsayi7.Text = Convert.ToString(sayilar[6]);
            lblsayi8.Text = Convert.ToString(sayilar[7]);
            lblsayi9.Text = Convert.ToString(sayilar[8]);
            lblsayi10.Text = Convert.ToString(sayilar[9]);

        }
    }
}
