namespace LeetCode.LeetCode150.Stack;

public class MinStack
{
    private readonly Stack<(int value, int min)> stack;

    public MinStack()
    {
        stack = new Stack<(int value, int min)>();
    }

    public void Push(int val)
    {
        if (stack.Count > 0)
        {
            var (_, min) = stack.Peek();

            stack.Push((val, Math.Min(min, val)));
        } else
        {
            stack.Push((val, val));
        }

    }

    public void Pop()
    {
        if (stack.Count > 0)
        {
            stack.Pop();
        }
    }

    public int Top()
    {
        if (stack.Count > 0)
        {
            var (value, _) = stack.Peek();
            return value;
        } else
        {
            throw new InvalidOperationException("Stack is empty");
        }
    }

    public int GetMin()
    {
        if (stack.Count > 0)
        {
            var (_, min) = stack.Peek();
            return min;
        } else
        {
            throw new InvalidOperationException("Stack is empty");
        }
    }
}
