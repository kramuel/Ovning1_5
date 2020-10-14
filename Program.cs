using System;

namespace Ovning1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            double x1, x2, y1, y2, dist;


            Console.WriteLine("Beräkna avståndet mellan två punkter.");

            Console.Write("Ange x-koordinaten för p1:  ");
            userInput = Console.ReadLine();
            x1 = Convert.ToDouble(userInput);

            Console.Write("Ange y-koordinaten för p1:  ");
            userInput = Console.ReadLine();
            y1 = Convert.ToDouble(userInput);

            Console.Write("Ange x-koordinaten för p2:  ");
            userInput = Console.ReadLine();
            x2 = Convert.ToDouble(userInput);

            Console.Write("Ange y-koordinaten för p2:  ");
            userInput = Console.ReadLine();
            y2 = Convert.ToDouble(userInput);

            double xsq = (x2 - x1) * (x2 - x1);
            double ysq = (y2 - y1) * (y2 - y1);

            dist = Math.Sqrt(xsq + ysq);

            Console.WriteLine("Avståndet är :  " + dist.ToString("F2"));

            Console.ReadKey();
        }
    }
}
