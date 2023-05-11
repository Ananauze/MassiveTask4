using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassiveTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            string userInput = "";
            int[] numbers = new int[0];
            bool isInMenu = true;
            string wordForExit = "Exit";
            string wordForSum = "Sum";

            while (isInMenu)
            {
                Console.WriteLine("\nПривет! Это программа 'Запоминатор-2000'.");
                Console.WriteLine("Введите число, что бы добавить его в массив.");
                Console.WriteLine($"Введите {wordForSum}, что бы получить сумму всех введенных чисел.");
                Console.Write($"Введите {wordForExit}, для выхода из программы: ");
                userInput = Console.ReadLine();
                
                if (userInput == wordForExit)
                {
                    Console.WriteLine("\nПриходите, я всегда рад помочь!");
                    isInMenu = false;
                    break;
                }
                else if (userInput == wordForSum)
                {
                    int numbersSum = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbersSum += numbers[i];
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nСумма введенного массива: {numbersSum}!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    int[] templateNumbers = new int[numbers.Length + 1];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        templateNumbers[i] = numbers[i];
                    }

                    templateNumbers[templateNumbers.Length - 1] = Convert.ToInt32(userInput);
                    numbers = templateNumbers;
                    Console.WriteLine($"\nВы добавили число {userInput}!");
                }
            }
        }
    }
}
