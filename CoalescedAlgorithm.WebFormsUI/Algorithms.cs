using CoalescedAlgorithm.Business.Abstract;
using CoalescedAlgorithm.Business.DependecyReselvor.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoalescedAlgorithm.WebFormsUI
{
    public partial class Algorithms : Form
    {
        public Algorithms()
        {
            InitializeComponent();
            _function = InstanceFactory.GetInstance<IFunction>();
        }
        IFunction _function;
        int[] sayilar = new int[10];

        private void Algorithms_Load(object sender, EventArgs e)
        {
            lblsayi1.Text = "";
            lblValueOne.Text = "";
            lblİndexOne.Text = "";
            lblEischKey.Text = "";
            lblEischLink.Text = "";
            lblLichKey.Text = "";
            lblLichLink.Text = "";
            lblRischKey.Text = "";
            lblRischLink.Text = "";
            lblBeischKey.Text = "";
            lblBeischLink.Text = "";

        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            int sayi;
            int i = 0;
            lblsayi1.Text = "";

            while (i < 10)
            {
                sayi = _function.RandomSayiUret();
                int non = Array.IndexOf(sayilar, sayi);//differentnumber
                if (non == -1)
                {
                    sayilar[i] = sayi;
                    lblsayi1.Text +=i+1+".sayı: " + sayi + "\n"+"\n";
                    i++;
                }

            }
            lblValueOne.Text = "";
            lblİndexOne.Text = "";
            lblEischKey.Text = "";
            lblEischLink.Text = "";
            lblLichKey.Text = "";
            lblLichLink.Text = "";
            lblRischKey.Text = "";
            lblRischLink.Text = "";
            lblBeischKey.Text = "";
            lblBeischLink.Text = "";


        }
        int[] arrKeyLisch;
        string[] arrLinkLisch;
        private void btnLisch_Click(object sender, EventArgs e)
        {
            
            int boyut = 11;
            arrKeyLisch = new int[boyut];
            arrLinkLisch = new string[boyut];
            for (int i = 0; i < sayilar.Length; i++)
            {
                int key = sayilar[i] % boyut;
                int lastEmptyLink = boyut - 1;
                if (arrKeyLisch[key] != 0)
                {
                    
                    //BOS ANAHTAR ARAMA
                    while (arrKeyLisch[lastEmptyLink] != 0)
                    {
                        lastEmptyLink -= 1;
                        
                    }
                    if (key != boyut - 1)
                    {
                        
                    }
                    arrKeyLisch[lastEmptyLink] = sayilar[i];

                    //BOS LINK ARAMA 
                    if (arrLinkLisch[key] != null)
                    {
                        int j = int.Parse(arrLinkLisch[key].ToString());
                        while (arrLinkLisch[j] != null)
                        {
                            j = int.Parse(arrLinkLisch[j].ToString());
                        }
                        arrLinkLisch[j] = lastEmptyLink.ToString();
                    }
                    else
                    {
                        arrLinkLisch[key] = lastEmptyLink.ToString();
                    }
                }
                else
                {
                    
                    arrKeyLisch[key] = sayilar[i];
                }
            }
            int n=0;
            lblİndexOne.Text = "";
            lblValueOne.Text = "";
            while (n <= 10)
            {
                var sayi= arrKeyLisch[n];
                var link = arrLinkLisch[n];
                lblİndexOne.Text += sayi +  "\n"+"\n";
                lblValueOne.Text += link + "\n"+ "\n";
                n++;
                

            }

        }
        int[] arrKeyEisch;
        string[] arrLinkEisch;
        private void btnEisch_Click(object sender, EventArgs e)
        {
         
         int boyut = 11;
        

            
            arrKeyEisch = new int[boyut];
            arrLinkEisch = new string[boyut];
            for (int i = 0; i < sayilar.Length; i++)
            {

                int key = sayilar[i] % boyut;
                int lastEmptyLink = key;
                if (arrKeyEisch[key] != 0)
                {
                    
                    //BOS ANAHTAR ARAMA
                    while (arrKeyEisch[lastEmptyLink] != 0 && lastEmptyLink < boyut)
                    {

                        lastEmptyLink = lastEmptyLink + 1;
                        if (lastEmptyLink == boyut)
                        {
                            break;
                        }
                       
                    }
                    if (lastEmptyLink == boyut)
                    {
                        lastEmptyLink = key;

                        while (arrKeyEisch[lastEmptyLink] != 0)
                        {
                            lastEmptyLink -= 1;
                           
                        }
                    }
                    arrKeyEisch[lastEmptyLink] = sayilar[i];

                    //BOS LINK ARAMA
                    if (arrLinkEisch[key] != null)
                    {
                        int j = Convert.ToInt32(arrLinkEisch[key].ToString());

                        while (arrLinkEisch[j] != null)
                        {
                            j = Convert.ToInt32(arrLinkEisch[j].ToString());
                        }
                        arrLinkEisch[j] = lastEmptyLink.ToString();

                    }
                    else
                    {
                        arrLinkEisch[key] = lastEmptyLink.ToString();
                    }
                }
                else
                {
                    
                    arrKeyEisch[key] = sayilar[i];
                }

                int n = 0;

                lblEischKey.Text = "";
                lblEischLink.Text = "";

                while (n <= 10)
                {
                    var sayi = arrKeyEisch[n];
                    var link = arrLinkEisch[n];
                    lblEischKey.Text += sayi + "\n"+ "\n";
                    lblEischLink.Text += link + "\n"+ "\n";
                    n++;


                }

            }
        }

        int[] arrLichKey;
        int[] arrLichLink;
        private void btnLich_Click(object sender, EventArgs e)
        {
            
            
            int primaryArea = 7;
            int overflowArea = 4;
            int hashValue = primaryArea;

            arrLichKey = new int[primaryArea + overflowArea];
            arrLichLink = new int[primaryArea + overflowArea];


                for (int i = 0; i < sayilar.Length; i++)   
                {
                int key = sayilar[i] % hashValue; //  
                    int lastEmptyKey = primaryArea + overflowArea;  
                    // BOS ANAHTAR ARAMA
                    if (arrLichKey[key] == 0)   
                    {
                    arrLichKey[key] = sayilar[i];  
                    }
                    else //OVERFLOW
                    { 
                         lastEmptyKey -=1;
                        if (arrLichKey[lastEmptyKey] == 0)
                        {
                        arrLichKey[lastEmptyKey] = sayilar[i];
                        arrLichLink[key] = lastEmptyKey;
                        }
                        else 
                        {
                            while (arrLichKey[lastEmptyKey] != 0)
                            {
                            lastEmptyKey -= 1;
                            }
                        arrLichKey[lastEmptyKey] = sayilar[i];

                        if (lastEmptyKey >= primaryArea && lastEmptyKey < 11)
                            arrLichLink[key] = lastEmptyKey; 
                    }  
                   }
                }

            int n = 0;
            lblLichKey.Text = "";
            lblLichLink.Text = "";
            while (n <= 10)
            {
                var sayi = arrLichKey[n];
                var link = arrLichLink[n];
                lblLichKey.Text += sayi + "\n"+ "\n";
                if (link!=0)
                {
                     lblLichLink.Text += link + "\n"+ "\n";
                }
                n++;


            }

        }

        private void gbxLich_Enter(object sender, EventArgs e)
        {

        }

        int[] arrRischKey;
        int[] arrRischLink;
        private void btnRLisch_Click(object sender, EventArgs e)
        {
            
            int boyut = 11;

            arrRischKey = new int[boyut];
            arrRischLink = new int[boyut];
                Random randomRisch = new Random();
                int key;  
                int randomEmptyKey = randomRisch.Next(0, boyut);
                for (int i = 0; i < sayilar.Length; i++)
                {
                key = sayilar[i] % (boyut);  
                    if (arrRischKey[key] == 0)
                    {
                    arrRischKey[key] = sayilar[i];

                    }
                    else
                    {
                        if (arrRischLink[key] != 0) 
                        {
                            while (arrRischLink[key] == 0)   
                            {
                            key = arrRischLink[key];  
                            }
                        }
                        //RANDOM BOŞ YER ARAMA
                        while (arrRischKey[randomEmptyKey] != 0)  
                        {
                        randomEmptyKey = randomRisch.Next(0, boyut); 
                        }

                    arrRischKey[randomEmptyKey] = sayilar[i];
                    arrRischLink[key] = randomEmptyKey;
                    }

                }
            int n = 0;
            lblRischKey.Text = "";
            lblRischLink.Text = "";
            while (n <= 10)
            {
                var sayi = arrRischKey[n];
                var link = arrRischLink[n];
                lblRischKey.Text += sayi + "\n" + "\n";
                if (link != 0)
                {
                    lblRischLink.Text += link + "\n" + "\n";
                }
                n++;


            }
        }
        int[] arrBeischKey;
        int[] arrBeischLink;

        private void btnBeisch_Click(object sender, EventArgs e)
        {
            
            
            int boyut = 11;

            arrBeischKey = new int[boyut];
            arrBeischLink = new int[boyut];
            int key;
            int lastEmptyKey = boyut - 1;  
            int firstEmptyKey = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                key = sayilar[i] % (boyut);  
                //BOŞ KAYIT ARAMA
                if (arrBeischKey[key] == 0) 
                {
                    arrBeischKey[key] = sayilar[i];  

                }
                //LİNK ARAMA
                else  
                {

                    if (arrBeischLink[key] != 0) 
                    {
                        while (arrBeischLink[key] == 0)   
                        {
                            key = arrBeischLink[key];  
                        }
                    }
                   
                    for (; ; ) 
                    {
                        if (arrBeischKey[firstEmptyKey] == 0) 
                        {
                            arrBeischKey[firstEmptyKey] = sayilar[i]; 
                            arrBeischLink[key] = firstEmptyKey;
                            break;
                        }
                        else
                        {
                            firstEmptyKey += 1; 
                            if (arrBeischKey[lastEmptyKey] == 0) 
                            {
                                arrBeischKey[lastEmptyKey] = sayilar[i]; 
                                arrBeischLink[key] = lastEmptyKey;
                                break;
                            }
                            else
                            {
                                lastEmptyKey -= 1; 
                            }
                        }
                }
            }
        }

            int n = 0;
            lblBeischKey.Text = "";
            lblBeischLink.Text = "";
            while (n <= 10)
            {
                var sayi = arrBeischKey[n];
                var link = arrBeischLink[n];
                lblBeischKey.Text += sayi + "\n" + "\n";
                if (link != 0)
                {
                    lblBeischLink.Text += link + "\n" + "\n";
                }
                n++;


            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            try
            {
                    lblLischİndexValue.Text=Convert.ToString(
                                _function.İndexAra(arrKeyLisch, Convert.ToInt32(tbxAranacakSayi.Text)));
                                lblEischİndexValue.Text = Convert.ToString(
                                _function.İndexAra(arrKeyEisch, Convert.ToInt32(tbxAranacakSayi.Text)));
                                /*  lblEichİndexValue.Text = Convert.ToString(
                                  _function.İndexAra(arrKeyEich, Convert.ToInt32(tbxAranacakSayi.Text)));*/
                                lblLichİndexValue.Text = Convert.ToString(
                                _function.İndexAra(arrLichKey, Convert.ToInt32(tbxAranacakSayi.Text)));
                                lblBeischİndexValue.Text = Convert.ToString(
                                _function.İndexAra(arrBeischKey, Convert.ToInt32(tbxAranacakSayi.Text)));
                                lblRischİndexValue.Text = Convert.ToString(
                                _function.İndexAra(arrRischKey, Convert.ToInt32(tbxAranacakSayi.Text)));
            }
            catch (Exception)
            {

                MessageBox.Show("Aranan Değer Bulunamadı!");
            }
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                 if (cbhxLisch.Checked==true)
                            {
                                lblPackingFactor.Text = Convert.ToString(_function.PackingFactorHesapla(sayilar, arrKeyLisch));
                            }
                            else if (cbhxRisch.Checked==true)
                            {
                                lblPackingFactor.Text = Convert.ToString(_function.PackingFactorHesapla(sayilar, arrRischKey));
                            }
                            else if (cbhxLich.Checked == true)
                            {
                                lblPackingFactor.Text = Convert.ToString(_function.PackingFactorHesapla(sayilar, arrLichKey));
                            }
                            else if (cbhxBeisch.Checked == true)
                            {
                                lblPackingFactor.Text = Convert.ToString(_function.PackingFactorHesapla(sayilar, arrBeischKey));
                            }
                            else if (cbhxEisch.Checked == true)
                            {
                                lblPackingFactor.Text = Convert.ToString(_function.PackingFactorHesapla(sayilar, arrKeyEisch));
                            }
                           /* else if (cbhxEich.Checked == true)
                            {
                                lblPackingFactor.Text = Convert.ToString(_function.PackingFactorHesapla(sayilar, arrRischKey));
                            }*/
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen sayıları yerleştiriniz!");
            }
           
        }
    }
}
