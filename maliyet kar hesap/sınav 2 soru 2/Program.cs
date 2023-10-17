using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınav_2_soru_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sabit maliyeti girin:");
            double sm = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen birim değişken maliyeti girin:");
            double bdm = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen miktarı girin:");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen birim satış fiyatını girin:");
            double bsf = double.Parse(Console.ReadLine());

            Hesapla hesap = new Hesapla();
            hesap.VeriGir(sm, bdm, m, bsf);
            hesap.Yaz();

            Console.ReadLine();
        }
    }
    class Hesapla
    {
        private double sabitMaliyet;
        private double birimDegiskenMaliyet;
        private double miktar;
        private double birimSatisFiyati;

        public void VeriGir(double sm, double bdm, double m, double bsf)
        {
            sabitMaliyet = sm;
            birimDegiskenMaliyet = bdm;
            miktar = m;
            birimSatisFiyati = bsf;
        }

        private double MaliyetHesapla()
        {
            return sabitMaliyet + birimDegiskenMaliyet * miktar;
        }

        private double GelirHesapla()
        {
            return birimSatisFiyati * miktar;
        }

        public double KarHesapla()
        {
            double toplamMaliyet = MaliyetHesapla();
            double toplamGelir = GelirHesapla();
            return toplamGelir - toplamMaliyet;
        }

        public void Yaz()
        {
            double kar = KarHesapla();
            Console.WriteLine("Elde edilen kar: " + kar);
        }
    }
}