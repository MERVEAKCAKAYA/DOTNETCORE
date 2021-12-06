using System;

namespace KonsolProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            #ilk odev
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32( Console.ReadLine());
            int[] dizi= new int[sayi];
            for(int i=0; i<sayi; i++)
            {
                Console.WriteLine((i+1)+". sayiyi giriniz: ");
                dizi[i]= Convert.ToInt32( Console.ReadLine());

            }
            for(int j=0; j<dizi.Length; j++)
            {
                if(dizi[j]%2==0)
                {
                    Console.WriteLine(dizi[j]+" sayisi cift sayidir.");
                }
            }    
        }
    }
}
