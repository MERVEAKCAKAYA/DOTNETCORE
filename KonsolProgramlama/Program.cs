﻿using System;

namespace KonsolProgramlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*ilk odev*********************************************************
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
            } */
            
            /*ikinci odev******************************************************
            Console.WriteLine("İlk sayiyi giriniz: ");
            int ilk = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("İkinci sayiyi giriniz: ");
            int ikinci = Convert.ToInt32( Console.ReadLine());
            int[] dizi= new int[ilk];
            for(int i=0; i<ilk; i++)
            {
                Console.WriteLine((i+1)+". sayiyi giriniz: ");
                dizi[i]= Convert.ToInt32( Console.ReadLine());

            }
            for(int j=0; j<dizi.Length; j++)
            {
                if(dizi[j]%ikinci==0 || dizi[j]==ikinci) 
                {
                    Console.WriteLine(dizi[j]+" sayisi ikinci sayiya eşit veya tam bolunuyordur..");
                }
            }*/
            
            /*ucuncu odev**********************************************************
            Console.WriteLine("Bir sayi giriniz: ");
            int sayi = Convert.ToInt32( Console.ReadLine());
            string[] dizi= new string[sayi];
            for(int i=0; i<sayi; i++)
            {
                Console.WriteLine((i+1)+". kelimeyi giriniz: ");
                dizi[i]= Convert.ToString( Console.ReadLine());

            }
            for(int j=dizi.Length-1; j>=0; j--)
            {

               Console.WriteLine(dizi[j]);

            }*/
            
            
            
           /* #dorduncu odev**********************************************************
            Console.WriteLine("Bir cumle giriniz: ");
            string cumle = Convert.ToString( Console.ReadLine());
            string[] kelimeler = cumle.Split(' ');
            Console.WriteLine("Girilen cumledeki kelime sayisi: "+kelimeler.Length);
            int harf=0;
            for (int i = 0; i < cumle.Length; i++)
            {
                if(cumle[i]!=' ')
                {
                    harf++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("Girilen cumledeki harf sayisi: "+harf); */   
            
            
            
            /* c# ile string hazir metotlar
            
            string cumle="c# ile string hazir metotlari ogreniyorum.";
            string cumle2="c# ile rgeg4g ty";
            Console.WriteLine(cumle.Length);
            Console.WriteLine(cumle.ToUpper());
            Console.WriteLine(cumle.ToLower());   
            Console.WriteLine(String.Concat(cumle,"merhaba"));
            Console.WriteLine(cumle.CompareTo(cumle2));
            Console.WriteLine(String.Compare(cumle,cumle2,true));
            Console.WriteLine(String.Compare(cumle,cumle2,false));
            Console.WriteLine(cumle.Contains(cumle2));
            Console.WriteLine(cumle.EndsWith("."));
            Console.WriteLine(cumle.StartsWith("c#"));
            Console.WriteLine(cumle.IndexOf("ile"));
            Console.WriteLine(cumle.Insert(0,"merhaba!"));
            Console.WriteLine(cumle.LastIndexOf("i"));
            Console.WriteLine(cumle2+ cumle.PadLeft(48));
            Console.WriteLine(cumle2+ cumle.PadRight(48,'*'));
            Console.WriteLine(cumle.Remove(10));
            Console.WriteLine(cumle.Remove(0,2));
            Console.WriteLine(cumle.Replace(' ','*'));
            Console.WriteLine(cumle);
            Console.WriteLine(cumle.Split(' ')[1]);
            Console.WriteLine(cumle.Substring(4));
            Console.WriteLine(cumle.Substring(0,17));
            
            
            */
        }
    }
}
