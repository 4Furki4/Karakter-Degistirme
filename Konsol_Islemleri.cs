using System;
using System.Collections.Generic;
namespace KaraterDegistirme
{
    public class Konsol_Islemleri
    {
        public void IlkMesaj()
        {
            System.Console.Write("Lütfen aralarında boşluk olacak şekilde kelimeler giriniz:");
        }
        public string[] KelimeleriAlma()
        {
            string input = Console.ReadLine();
            return input.Split(" ");
        }
        public void KelimeleriEkranaYazdır(List<string> list)
        {
            foreach (var item in list)
            {
                System.Console.WriteLine(item+" ");
            }
        }
    }
}