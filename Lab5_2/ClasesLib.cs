using System;
namespace Lab5_2
{
    class River
    {
        public string Name;
        public double Depth;
        public double Length;
        public bool RiverSpeed;
        public int Speed;
        public string Region;
        public string Pool;
        public string Vityk;
        public void WriteDetail()
        {
            Console.WriteLine($"Назва річки: {Name}");
            Console.WriteLine($"Глибина річки: {Depth}");
            Console.WriteLine($"Довжина річки: {Length}");
            Console.WriteLine($"Чи швидкістна річка?: {(RiverSpeed ? "Так" : "Ні")}");
            Console.WriteLine($"Швидкість річки: {Speed}");
            Console.WriteLine($"В якій області річка: {Region}");
            Console.WriteLine($"До якого басейну відноситься: {Pool}");
            Console.WriteLine($"Звідки витікає: {Vityk}");
        }

        public string DetermineRiverSize()
        {
            if (Length > 1000)
            {
                return "Велика";
            }
            else if (Length >= 500)
            {
                return "Середня";
            }
            else
            {
                return "Маленька";
            }
        }

        public void WriteRiverSize()
        {
            string size = DetermineRiverSize();
            Console.WriteLine($"Річка {Name} є {size}.");
        }
    }
}