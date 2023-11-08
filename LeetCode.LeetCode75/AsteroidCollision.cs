namespace LeetCode.LeetCode75;

public class AsteroidCollision
{
    public class Solution
    {
        public int[] AsteroidCollision(int[] asteroids)
        {
            var stack = new Stack<int>();

            for (int i = 0; i < asteroids.Length; i++)
            {
                int asteroid = asteroids[i];

                while (stack.Count > 0 && asteroid != 0)
                {
                    var previous = stack.Pop();
                    
                    if (!HaveCollision(previous, asteroid))
                    {
                        stack.Push(previous);

                        break;
                    }

                    asteroid = CollisionResult(previous, asteroid);            
                }

                if (asteroid != 0)
                {
                    stack.Push(asteroid);
                }

            }

            var resultStack = new Stack<int>();

            foreach(var asteroid in stack)
            {
                resultStack.Push(asteroid);
            }

            return resultStack.ToArray();
        }

        private static bool HaveCollision(int a, int b) => (a > 0 && b < 0);

        private static int CollisionResult(int a, int b)
        {
            if (Math.Abs(a) > Math.Abs(b)) 
            {
                return a;
            }
            
            if (Math.Abs(a) < Math.Abs(b))
            {
                return b;
            }

            return 0;
        }
    }
}
