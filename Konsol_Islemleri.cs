using System;
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
    }
}