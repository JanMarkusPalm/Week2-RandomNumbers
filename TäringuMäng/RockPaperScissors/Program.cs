using System;

namespace TäringuMäng
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string esimenemängija = "Guacamoleniggapenis";
            int plr1 = rnd.Next(1, 7);

            Random rnd2 = new Random();
            string teinemängija = "banaan";
            int plr2 = rnd.Next(1, 7);

            Console.WriteLine(esimenemängija + " viskas täringuga numbri " + plr1);
            Console.WriteLine(teinemängija + " viskas täringuga numbri " + plr2);

            if (plr1 < plr2)
            {
                Console.WriteLine(esimenemängija + " võitis!");
            }
            else if (plr1 > plr2)
            {
                Console.WriteLine(teinemängija + " võitis!");
            }
            else
            {
                Console.WriteLine("VIIK!");
            }

        }
    }
}
