namespace LeetCode.LeetCode75;

public class RecentCounter
{
    private int counter = 0;

    private Queue<int> queue = new Queue<int>();

    public RecentCounter()
    {
        counter = 0;
    }

    public int Ping(int t)
    {
        queue.Enqueue(t);

        counter++;

        while (queue.Count > 0) 
        {
            var item = queue.Peek();

            if (item >= t - 3000 && item <= t)
            {
                break;
            }

            queue.Dequeue();
            
            counter--;
        }

        return counter;
    }
}
