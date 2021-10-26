using System;

namespace sayitahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tahmin = 0, girilenSayi;
            int randomsayi = rnd.Next(1, 101);
            do
            {
                do
                {
                    Console.WriteLine("1-100 arasında bir sayi tahmin ediniz:");

                    try
                    {
                        girilenSayi = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("lutfen bir sayi giriiniz:");
                        continue;
                    }
                    finally
                    {
                        tahmin++;
                    } 
                } while (true);

                if (girilenSayi == randomsayi )
                {
                    Console.WriteLine( "Tebrikler "+ tahmin + " denemede Bildiniz");
                    Console.WriteLine( "Oyuna devam etmek icin E ya bas");
                    ConsoleKeyInfo info = Console.ReadKey();
                    if (info.Key != ConsoleKey.E)
                        break;

                }
                else if (girilenSayi > randomsayi) 
                {
                    Console.WriteLine("Tahmini Kucult");
                }
                else
                {
                    Console.WriteLine("Tahmini  Buyult");
                }


            } while (true);
           
           
          
            
        }
    }
}
