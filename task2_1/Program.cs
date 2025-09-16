namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення a");
            string a = Console.ReadLine();
            Console.WriteLine("Введіть значення b");
            string b = Console.ReadLine();
            Console.WriteLine("Введіть значення c");
            string c = Console.ReadLine();
            if ((double.TryParse(a, out double Ina)) && (double.TryParse(b, out double Inb)) && (double.TryParse(c, out double Inc)))
            {
                double d = Inb * Inb - 4 * Ina * Inc;
                Console.WriteLine($"Дискримінант: {d}");
                if (d > 0)
                {
                    double x1 = (-Inb + Math.Sqrt(d)) / (2 * Ina);
                    double x2 = (-Inb - Math.Sqrt(d)) / (2 * Ina);
                    Console.WriteLine($"Корені рівнення: x1: {x1}, х2: {x2}");
                }
                else if (d == 0)
                {
                    double x = -Inb / (2 * Ina);
                    Console.WriteLine($"Коренm рівнення: x: {x}");
                }
                else 
                {
                    Console.WriteLine("Не має розв'язку");
                }
            }
            else
            {
                Console.WriteLine("Невірні дані");
            }
        }
    }
}