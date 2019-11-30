using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoalescedAlgorithm.Business.Abstract
{
    public interface IFunction
    {
        int RandomSayiUret();
        int İndexAra(int[] arrKey,int key);
        double PackingFactorHesapla(int[] arrValue,int[] arrAreaSize);
        
       
        
    }
}
