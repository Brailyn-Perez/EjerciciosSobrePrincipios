
namespace KISS
{
    public class RestaurantBill
    {
        public decimal CalculateTotal(decimal[] prices, decimal? tipPercentage)
        {
            decimal total = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                total += prices[i];
            }

            if (tipPercentage.HasValue)
            {
                total += total * (tipPercentage.Value / 100);
            }
            else
            {
                total += total * 0.10m;
            }
            return total;
        }
    }
}
