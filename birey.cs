using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genetik_algoritma
{
    public class birey
    {
        private static Random rand = new Random();
        private const double minValue = -5;
        private const double maxValue = 5;

        public double X { get; set; }
        public double Y { get; set; }
        public double Fitness { get; private set; }

        public birey()
        {
            X = RandomGen();
            Y = RandomGen();
            FitnessHesapla();
        }

        public birey(double x, double y)
        {
            X = x;
            Y = y;
            FitnessHesapla();
        }

        public void FitnessHesapla()
        {
            Fitness = ((2 * Math.Pow(X, 2)) - (1.05*Math.Pow(X,4)) + ((Math.Pow(X, 6)) / 6) + (X*Y) + (Math.Pow(Y,2)));
        }

        private static double RandomGen()
        {
            return minValue + (maxValue - minValue) * rand.NextDouble();
        }
    }
}
