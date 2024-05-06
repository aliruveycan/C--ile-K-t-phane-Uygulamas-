using System;
using System.Collections.Generic;

class Kitap
{
    public string Ad { get; set; }
    public string Yazar { get; set; }
    public int Yil { get; set; }

    public Kitap(string ad, string yazar, int yil)
    {
        Ad = ad;
        Yazar = yazar;
        Yil = yil;
    }

    public override string ToString()
    {
        return $"Ad: {Ad}, Yazar: {Yazar}, Yıl: {Yil}";
    }
}

class Program
{
    static List<Kitap> kitaplar = new List<Kitap>();

    static void Main(string[] args)
    {
        bool devam = true;
        while (devam)
        {
            Console.WriteLine("1. Kitap Ekle");
            Console.WriteLine("2. Kitap Ara");
            Console.WriteLine("3. Tüm Kitapları Listele");
            Console.WriteLine("4. Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    KitapEkle();
                    break;
                case "2":
                    KitapAra();
                    break;
                case "3":
                    TumKitaplariListele();
                    break;
                case "4":
                    devam = false;
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        }
    }

    static void KitapEkle()
    {
        Console.WriteLine("Kitap adını girin:");
        string ad = Console.ReadLine();

        Console.WriteLine("Yazarını girin:");
        string yazar = Console.ReadLine();

        Console.WriteLine("Yılını girin:");
        int yil = Convert.ToInt32(Console.ReadLine());

        Kitap yeniKitap = new Kitap(ad, yazar, yil);
        kitaplar.Add(yeniKitap);
        Console.WriteLine("Kitap başarıyla eklendi.");
    }

    static void KitapAra()
    {
        Console.WriteLine("Aramak istediğiniz kitabın adını girin:");
        string arananAd = Console.ReadLine();

        List<Kitap> bulunanKitaplar = kitaplar.FindAll(k => k.Ad.Contains(arananAd));

        if (bulunanKitaplar.Count > 0)
        {
            Console.WriteLine("Arama sonuçları:");
            foreach (Kitap kitap in bulunanKitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
        else
        {
            Console.WriteLine("Aranan kitap bulunamadı.");
        }
    }

    static void TumKitaplariListele()
    {
        if (kitaplar.Count > 0)
        {
            Console.WriteLine("Tüm kitaplar:");
            foreach (Kitap kitap in kitaplar)
            {
                Console.WriteLine(kitap);
            }
        }
        else
        {
            Console.WriteLine("Henüz hiç kitap eklenmemiş.");
        }
    }
}
