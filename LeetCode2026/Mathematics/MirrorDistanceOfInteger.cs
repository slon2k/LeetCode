namespace LeetCode2026.Mathematics;

// 3783. Mirror Distance of an Integer
// The mirror distance of an integer x is the absolute difference between x and reverse(x), where reverse(x) denotes the integer formed by reversing the digits of x.
// Leading zeros are omitted after reversing, for example reverse(120) = 21.
// Given an integer x, return the mirror distance of x.

public class MirrorDistanceOfIntegerSolution
{
    public int MirrorDistance(int x)
    {
        int reversed = Reverse(x);
        return Math.Abs(x - reversed);
    }
    
    private int Reverse(int x)
    {
        int result = 0;
        
        while (x > 0)
        {
            result = result * 10 + x % 10;
            x /= 10;
        }
        
        return result;
    }
}