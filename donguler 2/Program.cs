using System;

 class Program

   
        {
            static void Main(string[] args)
            {
                //while
                //1 den başlayarak consoleden girilen sayıya kadar (sayi dahil) ortalama hesaplayıp console yazdıran program
                Console.Write("lutfen bir sayi giriniz:");
                int sayi = int.Parse(Console.ReadLine());
                int sayac = 1;
                int toplam = 0;
                while (sayac <= sayi)
                {
                    toplam += sayac;
                    sayac++;
                }
                Console.WriteLine(toplam/sayi);
                

                // 'a' dan 'z'ye kadar tüm harfeleri console a yazdırır.
                char character='a';
                while(character<'z')
                {
                    Console.Write(character);
                    character++;
                }                
                Console.Write("***********foreach********");
                string[] arabalar={"bmw","ford","toyota","nissan"};
                foreach(var araba in arabalar)
                {
                    Console.WriteLine(araba);

                }





            }




     }   
