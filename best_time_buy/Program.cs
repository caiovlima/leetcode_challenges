namespace best_time_buy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int MaxProfit(int[] prices)
    {
        if (prices == null || prices.Length == 0)
        {
            return 0;
        }

        int maxProfit = 0;
        int minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            // Se o preço atual é menor que o mínimo anterior, atualizamos o mínimo
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
            // Caso contrário, calculamos o lucro potencial e atualizamos o máximo
            else
            {
                int profit = prices[i] - minPrice;
                maxProfit = Math.Max(maxProfit, profit);
            }
        }

        return maxProfit;

    }
}
