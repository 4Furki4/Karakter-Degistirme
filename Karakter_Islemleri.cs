using System;
using System.Collections.Generic;
namespace KaraterDegistirme
{
    public class Karakter_Islemleri
    {
        public List<string> YerleriDegistir(string[] arr)
        {
            List<string> sonKelimeler= new List<string>();
            foreach (var item in arr)
            {
                int counter=0;
                char[] harfler= new char[item.Length];
                foreach (var harf in item)
                {
                    harfler[counter]= harf;
                    counter++;
                }
                char ilkHarf= harfler[0];
                harfler[0]=harfler[item.Length-1];
                harfler[item.Length-1]= ilkHarf;
                sonKelimeler.Add(string.Join(null,harfler));
            }
            return sonKelimeler;
        }
        
    }
}