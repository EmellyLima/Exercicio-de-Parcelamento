using System;
using System.Globalization;
using Entities;
using Services;

namespace Parcelamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contact data ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy ", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contract c = new Contract(number, date, value);
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(c, months);


            Console.WriteLine("Instalment: ");
            foreach (Installment installment in c.installments)
            {
                Console.WriteLine(installment);
            }



        }
    }
}
