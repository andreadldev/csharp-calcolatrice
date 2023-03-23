using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class CalcHelper
    {
        public static int Somma(int x, int y) => x + y;
        public static double Somma(double x, double y) => x + y;

        public static int Differenza(int x, int y) => x - y;
        public static double Differenza(double x, double y) => x - y;

        public static int Moltiplicazione(int x, int y) => x * y;
        public static double Moltiplicazione(double x, double y) => x * y;

        public static int ValoreAssoluto(int num) => Math.Abs(num);
        public static double ValoreAssoluto(double num) => Math.Abs(num);

        public static int Minimo(int x, int y) => x < y ? x : y;
        public static double Minimo(double x, double y) => x < y ? x : y;

        public static int Massimo(int x, int y) => x > y ? x : y;
        public static double Massimo(double x, double y) => x > y ? x : y;

        public static double? Potenza(double x, double y)
        {
            if (y == 0) return 1;
            if (y < 0 && x == 0) return null;
            if (x == 0) return 0;
            if (x == 1) return 1;


        double result = x;

            for (int i = 1; i < ValoreAssoluto(y); i++)
                {
                    result *= x;
                }

            return y > 0 ? result : 1 / result;
        }
}
