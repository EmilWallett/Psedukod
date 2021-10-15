using System;

namespace Psedukod
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfAtemps = 0;
            Random random = new Random();
            int tal = random.Next(1, 101);

            Console.WriteLine("välj ett tal mellan 1 och 100");

            while (true) {
                int atempt = int.Parse(Console.ReadLine());

                if(atempt == tal) {
                    Console.WriteLine("du har rätt tal!!");
                    Console.WriteLine("du försökte " + numberOfAtemps + " gånger");
                    break;

                } else if(atempt < tal) {
                    Console.WriteLine("talet är större");
                    numberOfAtemps += 1;
                } else {
                    Console.WriteLine("talet är mindre");
                    numberOfAtemps += 1;
                }
            }
        }
    }
}
