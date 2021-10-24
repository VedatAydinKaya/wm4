using System;

namespace randomnesnesideneme
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();  // instance
            

            int rastgelesayi = rnd.Next(0, 100);
          //  Console.WriteLine(rastgelesayi);

            int sayi1 = rnd.Next(100);
           // Console.WriteLine(sayi1);

            //-10 ile 20 arasında rastgele sayı

            int sayi2 = rnd.Next(-10, 20);

            //rastgele bir int sayisi 

            int sayi3 = rnd.Next();
            // Console.WriteLine(sayi3);  // 68362572

            int value;
                 
            for (int i = 0; i < 6; i++)
            {
                value = rnd.Next(-1000, 10000);  
                Console.WriteLine(value);

            }

            Random deneme = new Random();

            int randomNumber = deneme.Next(-1000, 10000);

        }
    }
}
