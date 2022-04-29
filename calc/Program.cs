using System;

namespace калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action;

            Console.WriteLine("Введите первое число:");
            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: `+`, `-`, `*`, `/`, `^`, `sqrt`, `%`");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Ошибка");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }
                    break;
                case "^":
                    Console.WriteLine(Math.Pow(firstValue, secondValue));
                    break;
                case "sqrt":

                    Console.WriteLine(Math.Sqrt(firstValue));
                    break;
                case "%":
                    Console.WriteLine(firstValue % secondValue);
                    break;
                default:
                    Console.WriteLine("Ошибка!");
                    break;




            }

        }
    }
}


