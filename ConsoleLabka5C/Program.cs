using System;

namespace ConsoleLabka5C
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            Console.WriteLine("Возняк Софiя IС-01, 24 варiант");
            Console.WriteLine("Першi 10 п'ятизначних палiндромiв");
            int number = 100;
            while ((number < 999) && (counter < 10))
            {
                bool isPrime = true;
                int number1 = number / 100;
                int number2 = (number - number1 * 100) / 10;
                int pol = number * 100 + number2 * 10 + number1;

                for (int i = 2; i < pol / 2 && isPrime; i++)
                    if (pol % i == 0)
                        isPrime = false; 
                if (isPrime)
                {
                    counter++;
                    Console.WriteLine(pol);
                }
                if(counter < 10) 
                { 
                    number++; 
                }
            }
        }
    }
}
