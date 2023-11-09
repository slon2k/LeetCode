namespace LeetCode.LeetCode75;

public class Dota2Senate
{
    public class Solution
    {
        public string PredictPartyVictory(string senate)
        {
            int dire = 0;
            int radiant = 0;

            var senateList = new List<char>();

            foreach (var senator in senate)
            {
                senateList.Add(senator);
                
                if (senator == 'D')
                {
                    dire++;
                }

                if (senator == 'R')
                {
                    radiant++;
                }
            }

            int i = 0;

            while (dire > 0 && radiant > 0)
            {
                var senator = senateList[i];



                int j = i + 1;
                j %= senateList.Count;

                while (true)
                {                   
                    if (senateList[j] == 'D' && senator == 'R')
                    {
                        senateList[j] = 'B';
                        dire--;

                        break;
                    }

                    if (senateList[j] == 'R' && senator == 'D')
                    {
                        senateList[j] = 'B';
                        radiant--;

                        break;
                    }

                    if (senator == 'B')
                    {
                        break;
                    }

                    j++;
                    j %= senateList.Count;
                }

                i++;
                i %= senateList.Count;
            }

            return dire > 0 ? "Dire" : "Radiant";

        }
    }
}
