using System;


class Program
{
    static void Main()
    {
        bool continuePlanning = true;

        while (continuePlanning)
        {
            //yer seç
            Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz: Bodrum, Marmaris, Çeşme");
            string location = Console.ReadLine().Trim().ToLower(CultureInfo.InvariantCulture);
            ///fiyatdata
            int basePrice = 0;
            switch (location)
            {
                case "bodrum":
                    basePrice = 4000;
                    break;
                case "marmaris":
                    basePrice = 3000;
                    break;
                case "çeşme":
                    basePrice = 5000;
                    break;
                default:
                    Console.WriteLine("Hatalı lokasyon girdiniz. Lütfen Bodrum, Marmaris veya Çeşme yazınız.");
                    continue;
            }
            //sorular
            Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
            if (!int.TryParse(Console.ReadLine(), out int numberOfPeople) || numberOfPeople <= 0)
            {
                Console.WriteLine("Geçersiz kişi sayısı girdiniz.");
                continue;
            }

            Console.WriteLine("Tatilinize nasıl gitmek istersiniz? 1 - Kara yolu (1500 TL), 2 - Hava yolu (4000 TL)");
            if (!int.TryParse(Console.ReadLine(), out int travelOption) || (travelOption != 1 && travelOption != 2))
            {
                Console.WriteLine("Geçersiz ulaşım seçeneği girdiniz.");
                continue;
            }

            int travelCost = travelOption == 1 ? 1500 : 4000;

            int totalCost = basePrice + (numberOfPeople * travelCost);

            Console.WriteLine($"Lokasyon: {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(location)}");
            Console.WriteLine($"Kişi Sayısı: {numberOfPeople}");
            Console.WriteLine($"Ulaşım Türü: {(travelOption == 1 ? "Kara yolu" : "Hava yolu")}");
            Console.WriteLine($"Toplam Tutar: {totalCost} TL");

            Console.WriteLine("Başka bir tatil planlamak ister misiniz? (E/H)");
            string response = Console.ReadLine().Trim().ToLower(CultureInfo.InvariantCulture);
            continuePlanning = response == "e";
        }

        Console.WriteLine("İyi günler dileriz!");
    }
}
