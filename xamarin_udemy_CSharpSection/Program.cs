using System;

namespace xamarin_udemy_CSharpSection
{
    class Program
    {
        static int n1 = 432, n2 = 543;
        static void Main(string[] args)
        {            
            var addition = Add();
            var substraction = Substract();
            var multiplication = Multiply();
            var division = Divide();

            Console.WriteLine(addition);
            Console.WriteLine(substraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(division);

            Console.ReadLine();
        }

        private static int Add()
        {         
            return n1 + n2;
        }

        private static int Substract()
        {
            return n1 - n2;
        }

        private static int Multiply()
        {
            return n1 * n2;
        }

        private static int Divide()
        {
            return n1 / n2;
        }
    }
}
