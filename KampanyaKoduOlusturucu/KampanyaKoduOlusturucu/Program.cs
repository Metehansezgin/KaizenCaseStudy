using System;

namespace KampanyaKoduOlusturucu
{
    public class Program
    {
        static void Main(string[] args)
        {
            CampaignCodeBuilder campaignCodeBuilder = new CampaignCodeBuilder();
             
            bool calisma = true;
            while (calisma)
            {
                menuYaz();
                string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Kampanya Kodu:" + campaignCodeBuilder.Generate());
                        break;
                    case"2":
                        Console.Write("Kampanya Kodunu Giriniz:");
                        string kampanyaKodu = Console.ReadLine();
                        if (campaignCodeBuilder.Validate(kampanyaKodu))
                        {
                            Console.WriteLine("Kampanya Kodu Doğru");
                        }
                        else
                        {
                            Console.WriteLine("Kampanya Kodu Yanlış");
                        }
                        break;
                    case"3":
                        calisma = false;
                        break;
                }
            }
        }

        static void menuYaz()
        {
            Console.WriteLine("1- Kampanya Kodu Oluştur.");
            Console.WriteLine("2- Kampanya Kodu Doğrula.");
            Console.WriteLine("3- Çıkış");
        }
    }
}
