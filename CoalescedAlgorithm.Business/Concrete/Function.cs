using CoalescedAlgorithm.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescedAlgorithm.Business.Concrete
{
    public class Function : IFunction
    {
        public double PackingFactorHesapla(int[] arrValue,int[] arrAreaSize)
        {
            double packingFactor = Convert.ToDouble(((double) arrValue.Length) / ((double) arrAreaSize.Length));
            return packingFactor;
        }

        public int RandomSayiUret()
        {
            Random rd = new Random();
            int sayi = rd.Next(1, 900);
            return sayi;
        }

        public int İndexAra(int[] arrKey, int key)
        {
            int arananDeger = 0;
            int i = 0;
            while (key!=arrKey[i])
            {
                i++;
                if (key==arrKey[i])
                {
                    arananDeger = i;
                }
                else
                {
                    arananDeger = -1;
                }
            }

            return arananDeger;
            
        }
    }
}
      

