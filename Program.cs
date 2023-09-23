using System.Globalization;
using TaxPayment.Entities;

namespace TaxPayment {

    internal class Program {

        static void Main(string[] args) {

            List<Tax> taxes = new List<Tax>();

            Console.Write("Number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {

                Console.WriteLine($"Tax payer {i} data:");
                Console.Write("Individual or company? (i/c)");
                char opt = char.Parse(Console.ReadLine());

                if (opt == 'i') {
                    Console.Write("Name: ");
                    String name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Helth expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxes.Add(new Individual(name, income, health));
                }
                else if (opt == 'c') {

                    Console.Write("Name: ");
                    String name = Console.ReadLine();
                    Console.Write("Annual Income: ");
                    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employers: ");
                    int employers = int.Parse(Console.ReadLine());
                    taxes.Add(new Company(name, income, employers));
                }
                else {

                    Console.WriteLine("Invalid type... Try again");
                    i -= 1;
                }
            }
            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("Taxes Paid: ");
            foreach (Tax tax in taxes) {
                Console.WriteLine(tax.ToString());
                sum += tax.TaxPayment();
                
            }
            Console.WriteLine();
            Console.WriteLine("Total Taxes: " + sum.ToString("F2", CultureInfo.InvariantCulture));







        }
    }
}
