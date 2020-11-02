using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Calculator.Sum();

            //class Math
            double pi = Math.PI;

            byte byteType = 25;
            int age = byteType;
            byte resultValue = (byte)age;

            string txtNumber = "24h";
            int num = Convert.ToInt32(txtNumber);

            long @long = num;

            int devision = 9 / 7;
        }
    }
}
