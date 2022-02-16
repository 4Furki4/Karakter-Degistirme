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
                int uzunluk = item.Length;
                string ilkKelime=arr[0]; 
                item.Replace(arr[0],arr[uzunluk-1]);
                item.Replace(arr[uzunluk-1],ilkKelime);
                sonKelimeler.Add(item);
            }
            return sonKelimeler;
        }
        
    }
}