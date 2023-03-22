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

        public static int Potenza(int x, int y) => (int)Math.Pow(x, y);
}
