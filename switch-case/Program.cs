using System;
internal class Program
{
    
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //experission
            switch (month)
            {
                case 1:
                    Console.WriteLine("ocak aayındasınız!");
                    break;
                case 2:
                    Console.WriteLine("şubat ayındasınız'");
                    break;
                case 3:
                    Console.WriteLine("mart ayındasınız!");
                    break;
                case 4:
                    Console.WriteLine("nisan ayındasınız!");
                    break;
                case 5:
                    Console.WriteLine("mayıs ayındasınız!");
                    break;
                case 11:
                    Console.WriteLine("kasım ayındasınız!");
                    break;
                case 12:
                    Console.WriteLine("aralık ayındasınız!");
                    break;
                default:Console.WriteLine("lutfen dogru giriniz");
                break;

            }
        
        switch(month)
        {

            case 12:
            case 2:
            case 1:
            Console.WriteLine("kış ayındasınız!");
            break;
            case 3:
            case 4:
            case 5:
            Console.WriteLine("ilkbahar ayındasınız!");
            break;
            case 6:
            case 7:
            case 8:
            Console.WriteLine("yaz ayındasınız!");
            break;
            case 9:
            case 10:
            case 11:
            Console.WriteLine("sonbahar ayındasınız!");
            break;

        }
        
        
        
        
        }
    
}