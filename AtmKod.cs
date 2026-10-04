using System;

class Program
{
    static void Main()
    {
        int bakiye = 5000;
        Console.WriteLine("ATM'ye Hosgeldiniz");
        Console.WriteLine("1- Bakiye Sorgulama");
        Console.WriteLine("2- Para Yatirma");
        Console.WriteLine("3- Para Cekme");
        Console.WriteLine("4- Cikis");
        Console.Write("Seciminiz: ");
        string secim = Console.ReadLine();

        switch (secim)
        {
            case "1":
                Console.WriteLine("Mevcut Bakiyeniz: " + bakiye + " TL");
                break;
            case "2":
                Console.Write("Yatirmak istediginiz tutar: ");
                int yatan = Convert.ToInt32(Console.ReadLine());
                bakiye = bakiye + yatan;
                Console.WriteLine("Yeni bakiyeniz: " + bakiye + " TL");
                break;
            case "3":
                Console.Write("Cekmek istediginiz tutar: ");
                int cekilen = Convert.ToInt32(Console.ReadLine());
                if (cekilen > bakiye)
                {
                    Console.WriteLine("Yetersiz bakiye!");
                }
                else
                {
                    bakiye = bakiye - cekilen;
                    Console.WriteLine("Yeni bakiyeniz: " + bakiye + " TL");
                }
                break;
            case "4":
                Console.WriteLine("Cikis yapiliyor...");
                break;
            default:
                Console.WriteLine("Gecersiz islem");
                break;
        }
    }
}