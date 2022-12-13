using System;
using System.Collections.Generic;
using System.Linq;


namespace Proje_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1- Girilen Pozitif Sayının Çift Olanlarını Görmek İçin;");
            Console.WriteLine("2- Girilen İki Pozitif Sayının Tam Bölenlerini Görmek İçin;");
            Console.WriteLine("3- Girilen Sayı Kadar Kelime Girmek İçin;");
            Console.WriteLine("4- Girilen Cümlenin Kelime ve Harf Sayısını Görmek için;");
            Console.WriteLine("İşlem Seçiniz");
            byte menu = Convert.ToByte(Console.ReadLine());
            if(menu==1)
            {
                Hw1();
            }
            else if ( menu==2)
            {
                Hw2();
                
            }
            else if ( menu==3)
            {
                Hw3();
            }
             else if ( menu==4)
            {
                Hw4();
            }
            else
            {
                Console.WriteLine("Lütfen Geçerli İşlem Seçiniz");
            }
            
            Console.Read();
        }

        private static void Hw1()
        {
            Console.Write("Lütfen Pozitif Sayı Giriniz : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} Adet Pozitif Sayı", n);
            int[] Nnumber = new int[n];
            for (int i = 1; i < n+1; i++)
            {
                Console.Write("{0}. Sayı : ",i);
                Nnumber[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in Nnumber)
            {   
                if ( item%2 == 0)
                {   
                    Console.Write(item+", ");
                }
                
            }
        }   

        private static void Hw2()
        {
            Console.WriteLine("1.Sayıyı Giriniz");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} Adet Pozitif Sayı Giriniz",n);
            int[] Nnumber = new int[n];
            for (int i = 1; i < n+1; i++)
            {
                Console.Write("{0}. Sayı : ",i);
                Nnumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (var item in Nnumber)
            {
                if( item%m==0 || item==m )
                {
                    Console.Write(item+", ");
                }
                
            }  
            Console.Read();
        }

        private static void Hw3()
        {
            Console.WriteLine("Pozifif Bir Sayı Giriniz ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} Adet Pozitif Sayı Giriniz",n);
            int[] dizi = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}. Sayı : ",i);
                dizi [i-1]= int.Parse(Console.ReadLine());
            }
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item+", ");
            }

        }

        static void Hw4()
        {
            Console.WriteLine("Lütfen Bir Cümle Yazınız");
            string cumle = Console.ReadLine();
            cumle=cumle.ToLower();
            int numberofcharacters = cumle.Count();
            string letters = "abcçdefgğhıijklmnoöprsştuüvyzxwq";
            int numberofletters = 0;
            for (int i = 0; i < numberofcharacters; i++)
            {
                if(letters.Contains(cumle[i]))
                {
                    numberofletters++;
                }                
            }
            
            Console.WriteLine("Girdiğiniz Cümlenin Harf Sayısı : "+numberofletters);
            string[] cumlesayisi = cumle.Split(' ');
            Console.WriteLine("Girdiğiniz Cümlenin Cümle Sayısı : "+cumlesayisi.Length);
            Console.Read();
        }
        
    }
}
