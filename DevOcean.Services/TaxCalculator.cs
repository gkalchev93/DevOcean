using DevOcean.Model;

namespace DevOcean.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public PayCheck GetPayCheck(double grossSalary)
        {
            var payCheck = new PayCheck()
            {
                GrossSalary = grossSalary
            };

            if (payCheck.GrossSalary > TaxSettings.MinIncomeTax)
            {
                var taxable = (payCheck.GrossSalary - TaxSettings.MinIncomeTax);

                payCheck.IncomeTax = taxable * TaxSettings.IncomeTaxPerc;

                if (taxable >= TaxSettings.MaxContributionTax)
                {
                    payCheck.ContributionTax = TaxSettings.MaxContributionTax * TaxSettings.ContributionTaxPerc;
                }
                else
                {
                    payCheck.ContributionTax = taxable * TaxSettings.ContributionTaxPerc;
                }
            }

            return payCheck;
        }
    }
}
