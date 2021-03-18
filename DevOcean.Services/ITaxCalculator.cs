using DevOcean.Model;

namespace DevOcean.Services
{
    public interface ITaxCalculator
    {
        PayCheck GetPayCheck(double grossSalary);
    }
}
