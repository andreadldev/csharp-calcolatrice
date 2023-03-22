using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public static class CalcHelper
    {
        public static int Somma(int num1, int num2) => num1 + num2;
        public static double Somma(double num1, double num2) => num1 + num2;

        public static int Differenza(int num1, int num2) => num1 - num2;
        public static double Differenza(double num1, double num2) => num1 - num2;

        public static int Moltiplicazione(int num1, int num2) => num1 * num2;
        public static double Moltiplicazione(double num1, double num2) => num1 * num2;

        public static int ValoreAssoluto(int num) => Math.Abs(num);
        public static double ValoreAssoluto(double num) => Math.Abs(num);

        public static int Minimo(int num1, int num2) => num1 < num2 ? num1 : num2;
        public static double Minimo(double num1, double num2) => num1 < num2 ? num1 : num2;

        public static int Massimo(int num1, int num2) => num1 > num2 ? num1 : num2;
        public static double Massimo(double num1, double num2) => num1 > num2 ? num1 : num2;
}
