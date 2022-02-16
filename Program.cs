using System;

namespace KaraterDegistirme
{
    class Program
    {
        static void Main(string[] args)
        {
            Konsol_Islemleri konsol = new Konsol_Islemleri();
            Karakter_Islemleri karakter= new Karakter_Islemleri();
            konsol.IlkMesaj();
            konsol.KelimeleriEkranaYazdır(karakter.YerleriDegistir(konsol.KelimeleriAlma()));
            
            
        }
    }
}
