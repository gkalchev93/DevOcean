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
    }
}
