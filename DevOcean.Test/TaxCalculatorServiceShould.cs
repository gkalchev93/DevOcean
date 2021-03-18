using DevOcean.Services;
using NUnit.Framework;

namespace DevOcean.Test
{
    public class TaxCalculatorServiceShould
    {

        [DatapointSource]
        public double[] values = new double[] { 100, 200, 300, 999, 1000 };

        [Test]
        [Theory]
        public void NotIncludeTaxes(double salary)
        {
            Assume.That(salary <= TaxSettings.MinIncomeTax);

            var taxSrvc = new TaxCalculator();
            var payCheck = taxSrvc.GetPayCheck(salary);

            Assert.AreEqual(salary, payCheck.NetSalary);
        }

        [Test]
        public void TestCase1FromTask()
        {

            var taxSrvc = new TaxCalculator();
            var payCheck = taxSrvc.GetPayCheck(3400);

            Assert.AreEqual(2860, payCheck.NetSalary);
        }

        [Test]
        public void TestCase2FromTask()
        {

            var taxSrvc = new TaxCalculator();
            var payCheck = taxSrvc.GetPayCheck(980);

            Assert.AreEqual(980, payCheck.NetSalary);
        }
    }
}