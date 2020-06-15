using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP6_3
{
    class Triangle
    {
        private bool Triangl;
        private double Alph;
        private double Bet;
        private double Gamm;

        public Triangle(int l1, int l2, int l3)
        {
            double Alpha = (Math.Acos((Math.Pow(l1, 2) + Math.Pow(l2, 2) - Math.Pow(l3, 2)) / (2 * l1 * l2))) * (180 / Math.PI);
            double Beta = (Math.Acos((Math.Pow(l2, 2) + Math.Pow(l3, 2) - Math.Pow(l1, 2)) / (2 * l2 * l3))) * (180 / Math.PI);
            double Gamma = (Math.Acos((Math.Pow(l3, 2) + Math.Pow(l1, 2) - Math.Pow(l2, 2)) / (2 * l1 * l3))) * (180 / Math.PI);

            if ((l1 + l2 > l3) && (l2 + l3 > l1) && (l1 + l3 > l2))
            {
                Triangl = true;

                Alph = Alpha;
                Bet = Beta;
                Gamm = Gamma;
            }
            else
            {
                Triangl = false;
            }

        }

        public void Display()
        {
            if (Triangl == true)
            {
                Console.WriteLine($"\nТреугольник можно построить\n\n" +
                                  $"Углы\n" +
                                  $"Alpha : {Alph.ToString("##.##")}" +
                                  $"\nBeta : {Bet.ToString("##.##")}" +
                                  $"\nGamma: {Gamm.ToString("##.##")}");
            }
            else
                Console.WriteLine("\nТреугольник нельзя построить");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Triangle trget = new Triangle(7, 7, 7);
            trget.Display();
            Triangle trget1 = new Triangle(6, 8, 4);
            trget1.Display();
            Triangle trget2 = new Triangle(32, 4, 13);
            trget2.Display();
            Console.ReadKey();
        }
    }
}
