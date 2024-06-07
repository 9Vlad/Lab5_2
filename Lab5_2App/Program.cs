using System;
using Lab5_2;

namespace Lab5_2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть кількість річок:");
            int numberOfRivers = int.Parse(Console.ReadLine());

            River[] rivers = new River[numberOfRivers];

            for (int i = 0; i < numberOfRivers; i++)
            {
                Console.WriteLine($"\nВведення даних для річки №{i + 1}:");
                rivers[i] = new River();

                Console.WriteLine("Введiть назву річки:");
                rivers[i].Name = Console.ReadLine();

                Console.WriteLine("Введiть глибину річки:");
                rivers[i].Depth = double.Parse(Console.ReadLine());

                Console.WriteLine("Введiть довжину річки:");
                rivers[i].Length = double.Parse(Console.ReadLine());

                Console.WriteLine("Чи є ця річка швидкісною?");
                rivers[i].RiverSpeed = Console.ReadLine().ToLower() == "так";

                Console.WriteLine("Введіть швидкість течії:");
                rivers[i].Speed = int.Parse(Console.ReadLine());

                Console.WriteLine("В якій області знаходиться річка?");
                rivers[i].Region = Console.ReadLine();

                Console.WriteLine("До якого басейну відноситься річка?");
                rivers[i].Pool = Console.ReadLine();

                Console.WriteLine("Звідки витікає річка?");
                rivers[i].Vityk = Console.ReadLine();
            }

            Console.WriteLine("\nІнформація про всі річки:");
            for (int i = 0; i < numberOfRivers; i++)
            {
                Console.WriteLine($"\nРічка №{i + 1}:");
                rivers[i].WriteDetail();
                rivers[i].WriteRiverSize();
            }

            Console.ReadLine();
        }
    }
}