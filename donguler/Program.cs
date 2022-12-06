using System;

class program
{

    static void Main(string[]args)
    {
       /* 
        //ekrandan girilen sayiya kadar olan tek sayıları ekrana yazdırır.
        Console.Write("lütfen bir sayi giriniz:");
        int sayac=int.Parse(Console.ReadLine());
        for(int i=1; i<=sayac; i++)
        {
            if(i%2==1)
            Console.WriteLine(i);
        }
       //1 ile 1000 arasındaki tek ve çift sayıları kendi içerisinde toplayıp ekrana yazdır
       int tektoplam=0;
       int cifttoplam=0;

       for(int i=1; i<=1000;i++ )
       {
            if(i%2==1)
            
                tektoplam +=i;//tektoplam=tektoplam+i;
            else 
                cifttoplam +=i;//çifttoplam=çifttoplam+i;
       }
        Console.WriteLine("tektoplam:" +tektoplam);
        Console.WriteLine("çifttoplam:"+cifttoplam);

        //break,continue
*/
        for(int i=1;i<=10;i++)
        {

            if(i==4)
            continue;
            Console.WriteLine(i);       
        }

 for(int i=1;i<=10;i++)
        {

            if(i==4)
            break;
            Console.WriteLine(i);       
        }

    


}