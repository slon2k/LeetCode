namespace LeetCode2026.Graphs;

// 1306. Jump Game III
// Given an array of non-negative integers arr, you are initially positioned at start index of the array. 
// When you are at index i, you can jump to i + arr[i] or i - arr[i], check if you can reach any index with value 0.
// Notice that you can not jump outside of the array at any time.

public class JumpGameIII
{
    public bool CanReach(int[] arr, int start) 
    {
        var visited = new HashSet<int>();
        var queue = new Queue<int>();
        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            var index = queue.Dequeue();
            if (arr[index] == 0)
            {
                return true;
            }

            var nextIndex1 = index + arr[index];
            if (nextIndex1 < arr.Length && !visited.Contains(nextIndex1))
            {
                queue.Enqueue(nextIndex1);
                visited.Add(nextIndex1);
            }

            var nextIndex2 = index - arr[index];
            if (nextIndex2 >= 0 && !visited.Contains(nextIndex2))
            {
                queue.Enqueue(nextIndex2);
                visited.Add(nextIndex2);
            }
        }

        return false;        
    }    
}