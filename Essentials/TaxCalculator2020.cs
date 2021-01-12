namespace Edgias.DesignPatterns.Essentials
{
    public class TaxCalculator2020 : ITaxCalculator
    {
        public decimal CalculateTax(decimal salary)
        {
            decimal percentage = 0.5M;
            return salary * percentage;
        }
    }
}