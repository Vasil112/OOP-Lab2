namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть n: ");
            string n = Console.ReadLine();
            Console.Write("Введіть k: ");
            string k = Console.ReadLine();
            Console.WriteLine("Який приклад бажаєте розв'язати? ");
            Console.Write("1: 1^n+2^(n/2)+ ... + k^(n/k)\n2: 1^k+2^k+ ... +n^k\n3: 1/n+2/n^2+3/n^3+ ... +k/n^k\nВведіть: ");
            string s = Console.ReadLine();
            if (double.TryParse(n, out double inN) &&
            double.TryParse(k, out double inK) &&
            int.TryParse(s, out int inS) &&

            inN >= 0 && inK >= 0)
            {
                switch (inS)
                {
                    case 1:
                        double number = 0;
                        while (inK>0)
                        {
                            double v = Math.Pow(inK, (inN / inK));
                            inK -= 1;
                            number += v;
                        }
                        Console.WriteLine($"Відповідь: {number}");
                        break;
                    case 2:
                        double number_2 = 0;
                        while (inN>0)
                        {
                            double v_2 = Math.Pow(inN, inK);
                            inN -= 1;
                            number_2 += v_2;
                        }
                        Console.WriteLine($"Відповідь: {number_2}");
                        break;
                    case 3:
                        double number_3 = 0;
                        while (inK>0)
                        {
                            double v_3 = inK / (Math.Pow(inN, inK));
                            inK -= 1;
                            number_3 += v_3;
                        }
                        Console.WriteLine($"Відповідь: {number_3}");
                        break;
                    default:
                        double number_4 = 0;
                        while (inK > 0)
                        {
                            double v = Math.Pow(inK, (inN / inK));
                            inK -= 1;
                            number_4 += v;
                        }
                        Console.WriteLine($"Відповідь: {number_4}");
                        break;

                }
                    
            }
            else
            {
                Console.WriteLine("Введіть коректні дані");

            }
        }
    }

}