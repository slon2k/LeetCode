namespace LeetCode.LeetCode150.BitManipulation;
internal class ReverseBits
{
    public class Solution
    {
        public uint reverseBits(uint n)
        {
            string str = n.ToString("B32");

            var array = str.ToCharArray();

            Array.Reverse(array);

            str = new string(array);

            return Convert.ToUInt32(str, 2);
        }
    }
}
