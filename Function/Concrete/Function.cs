using Functions.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Functions.Concrete
{
    public class Function : IFunction
    {
        public void PackingFactorHesapla()
        {
            throw new NotImplementedException();
        }

        public void RandomSayiUret(int[] arr)
        {
            Random rd = new Random();
            arr = new int[10];
            for (int i = 0; i <9 ; i++)
            {
                int sayi = rd.Next(1, 900);
                arr[i]=sayi;

            }
            
        }

        public int SayiEkle(int sayi)
        {
            throw new NotImplementedException();
        }

        public int İndexAra()
        {
            throw new NotImplementedException();
        }
    }
}
