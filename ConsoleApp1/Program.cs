namespace Program
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть значення x");
            string x = Console.ReadLine();
            Console.WriteLine("Введіть значення y");
            string y = Console.ReadLine();
            Console.WriteLine("Введіть значення z");
            string z = Console.ReadLine();
            double s;
            if ((double.TryParse(x, out double Inx)) && (double.TryParse(y, out double Iny)) && (double.TryParse(z, out double Inz)))
            {
                s = Math.Pow(3 + Math.Tan(Inx) - (Iny / 2), (1 / 3)) / (Math.Pow(Inx, 2) + Math.Pow(Inz, 3) + 4);
                Console.WriteLine(Math.Round(s,3));
            }
            else
            {
                Console.WriteLine("Невірні дані");
            }
            
            }
        }
}