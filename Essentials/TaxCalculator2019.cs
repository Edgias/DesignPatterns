namespace Edgias.DesignPatterns.Essentials
{
    public class TaxCalculator2019 : ITaxCalculator
    {
        public decimal CalculateTax(decimal salary)
        {
            decimal percentage = 0.25M;
            return salary * percentage;
        }
    }
}