using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi= {23,12,4,86,72,3,11,17}

            Console.WriteLine("**** sirasiz dizi ****");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            Console.WriteLine("**** sirali dizi****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //clear
            Console.WriteLine("**** array clear ****");
            // sayidizisi elemanlarini kullanarak 2. indexten itibaren 2 elemani 0'lar.
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //reverse
            Console.WriteLine("**** array reverse ****");
            Array.Reverse(sayiDizisi);

            foreach(var sayi in SayiDizisi)
                Console.WriteLine(sayi);

            //indexof
            Console.WriteLine("**** indexof ****");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //resize
            Console.WriteLine("**** resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;

            foreach (var sayi in SayiDizisi)
                Console.WriteLine(sayi);
        }
    }
}