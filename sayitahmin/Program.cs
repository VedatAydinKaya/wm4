using System;

namespace sayitahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            int tahmin = 0, girilenSayi = 0, randomSayi;
            Random rnd = new Random();
            randomSayi = rnd.Next(1, 101);
       
            do
            {
                do
                {
                    Console.Write("1-100 arasi bir sayi giriniz:");
                    try
                    {
                        girilenSayi = int.Parse(Console.ReadLine());
                        
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Lutfen bir sayi giriniz: ");
                        Console.WriteLine(ex.Message);
                        continue;
                    }
                    finally
                    {
                        tahmin++;
                    }
                    if (girilenSayi==randomSayi)
                    {
                        Console.WriteLine($"TEBRIKLER {tahmin}. denemede Bildiniz:");
                        break;
                    }
                    else if (girilenSayi >randomSayi)
                    {
                        Console.WriteLine("Tahmini Kucult");
                    }
                    else
                    {
                        Console.WriteLine("Tahmini Buyult");

                    }

                } while (true);

                Console.WriteLine("TEKRAR OYNAMAK ICIN E YA BAS");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key != ConsoleKey.E)
                    break;


            } while (true);

        }
    }
}
