namespace LeetCode.LeetCode75;

public class OnlineStockSpan
{
    public class StockSpanner
    {
        private readonly int limit = 100_000;

        private int min = 0;

        private int max = 0;

        private readonly int[] priceSpans;

        private int count = 0;

        public StockSpanner()
        {
            priceSpans = new int[limit + 1];
            count = 0;
        }

        public StockSpanner(int limit)
        {
            this.limit = limit;
            priceSpans = new int[limit + 1];
            count = 0;
        }

        public int Next(int price)
        {
            if (count == 0)
            {
                min = price;
                max = price;
            }

            AddPrice(price);

            count++;

            return priceSpans[price];
        }

        private void AddPrice(int price)
        {
            if (price < min)
            {
                min = price;
            }
            
            if (price > max)
            {
                for (int i = max + 1; i <= price; i++)
                {
                    priceSpans[i] = priceSpans[max];
                }

                max = price;
            }

            for (int i = min; i < price ; i++)
            {
                priceSpans[i] = 0;
            };

            for (int i = price; i <= max; i++)
            {
                priceSpans[i]++;
            }
        }
    }
}
