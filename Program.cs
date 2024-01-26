using System.Globalization;
using System.Numerics;
using AbstractMethodsEx.Entities;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Taxes> taxes = new List<Taxes>();
        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double anual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (ch == 'i' || ch == 'I')
            {
                Console.Write("Health expenditures: ");
                double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                taxes.Add(new Individual(name, anual, health));
            }
            else
            {
                Console.Write("Number of employees: ");
                int number = int.Parse(Console.ReadLine());
                taxes.Add(new Company(name, anual, number));
            }


        }

        Console.WriteLine();
        Console.WriteLine("TAXES PAID: ");
        double sum = 0.0;
        foreach(Taxes list in taxes)
        {
            Console.WriteLine(list.Name 
                + ": $ " 
                + list.Total().ToString("F2", CultureInfo.InvariantCulture));
            sum += list.Total();
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));




    }
}