using System;

namespace DevOcean.Model
{
    public class PayCheck
    {
        public double GrossSalary { get; set; }
        public double IncomeTax { get; set; }
        public double ContributionTax { get; set; }

        public double NetSalary
        {
            get
            {
                return GrossSalary - IncomeTax - ContributionTax;
            }
        }

        public override string ToString() => 
                   "Paycheck " + Environment.NewLine +
                   $"Gross Salary: {GrossSalary}" + Environment.NewLine +
                   $"Incomet Tax: {IncomeTax}" + Environment.NewLine +
                   $"Contirbution Tax: {ContributionTax}" + Environment.NewLine +
                   $"Net Amount: {NetSalary}";
    }
}
