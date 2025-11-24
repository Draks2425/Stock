//using System;
//using Stock;

//class Program
//{
//    static void Main()
//    {
//        var magazyn = new Stock.Stock();
//        int nextId = 1;

//        Console.WriteLine("Dodawanie produktów do magazynu.");
//        bool dodawanie = true;

//        while (dodawanie)
//        {
//            try
//            {
//                Console.Write("Podaj nazwę produktu: ");
//                string name = Console.ReadLine();
//                Console.Write("Podaj cenę produktu: ");
//                decimal price = decimal.Parse(Console.ReadLine());

//                var produkt = new Product { Id = nextId, Name = name, Price = price };
//                magazyn.AddProduct(produkt);

//                Console.WriteLine($"Dodano produkt: {produkt.Name} (Id: {produkt.Id}, Cena: {produkt.Price} zł)");

//                nextId++;

//                Console.Write("Chcesz dodać kolejny produkt? (y/n): ");
//                string odpowiedz = Console.ReadLine().ToLower();
//                switch(odpowiedz)
//                {
//                    case "y":
//                        dodawanie = true;
//                        break;
//                    case "n":
//                        dodawanie = false;
//                        break;
//                    default:
//                        Console.WriteLine("Nieznana odpowiedź, kończę dodawanie.");
//                        dodawanie = false;
//                        break;
//                }
//            }
//            catch (ArgumentOutOfRangeException e)
//            {
//                Console.WriteLine(e.Message);
//            }
//        }

//        Console.WriteLine("\nProdukty w magazynie:");
//        foreach (var p in magazyn.Products)
//        {
//            Console.WriteLine($"- {p.Name} (Id: {p.Id}, Cena: {p.Price} zł)");
//        }

//        Console.Write("\nPodaj Id produktu do wyszukania: ");
//        if (int.TryParse(Console.ReadLine(), out int szukanyId))
//        {
//            var szukany = magazyn.FindProductById(szukanyId);
//            if (szukany != null)
//            {
//                Console.WriteLine($"Znaleziono produkt: {szukany.Name} (Id: {szukany.Id}, Cena: {szukany.Price} zł)");
//            }
//            else
//            {
//                Console.WriteLine("Nie znaleziono produktu o podanym Id.");
//            }
//        }
//    }
//}