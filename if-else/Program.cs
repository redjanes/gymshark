using System;
class program

{
    static void Main(string[]args)
    {
        int time=DateTime.Now.Hour;

        if(time>=6)
        Console.WriteLine("gunaydin!");
        else if(time<=18)
        Console.WriteLine("iyi gunler!");
        else
        Console.WriteLine("iyi geceler!");

        string sonuc = time<=18 ? "iyi gunler!": "iyi geceler";
        sonuc=time>=6 && time<11 ? "günaydin": time<=18 ? "iyi günler!": "iyi geceler!";
        Console.WriteLine(sonuc);

    }
    
    
}



  