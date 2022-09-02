using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    internal class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> installment {get; set: }

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = TotalValue;
            installment = New List<Installment>();
        }
        
        public void AddInstallment(Installment installment)
        {
            installments.Add(installment)
        }
    }
}
