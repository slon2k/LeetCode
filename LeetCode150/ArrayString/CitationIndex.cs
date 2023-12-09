namespace LeetCode.LeetCode150.ArrayString;

public class CitationIndex
{
    public class Solution
    {
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);

            int length = citations.Length;

            int index = 0;

            for (int i = 0; i < length; i++)
            {
                int papers = length - i;
                int citation = citations[i];

                if(citation >= papers && papers > index)
                {
                    index = papers;
                }
            }

            return index;
        }
    }
}
