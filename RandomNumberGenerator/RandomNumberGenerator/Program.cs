using System;

namespace RandomNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int mynumber = rnd.Next(1, 11);

            //programm genereerib juhuslikku numbrit 1 kuni 10
            //programm kontrollib kas genereeritud number on suurem kui 5
            //kui number on suurem kui 5, siis konsool kuvab "juhuslik number on {mynumber}, see on suurem kui 5";
            //kui number on väiksem kui 5, konsool kuvab "juhuslik number on {mynumber}, see on väiksem kui 5";
            //kui number on 5, konsool kuvab "juhuslik number on 5";

            if (mynumber > 5)
            {
                Console.WriteLine("juhuslik number on " + mynumber + ", see on suurem kui 5");
            }

            else if (mynumber < 5)
            {
                Console.WriteLine("juhuslik number on " + mynumber + ", see on väiksem kui 5");
            }

            else
            {
                Console.WriteLine("juhuslik number on " + mynumber);
            }

            


           




        }
    }
}
