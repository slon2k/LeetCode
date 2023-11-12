namespace LeetCode.LeetCode75;

public class KeysAndRooms
{
    public class Solution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            HashSet<int> visited = new();
            HashSet<int> haveKey = new()
            {
                0
            };

            while (haveKey.Count > visited.Count)
            {
                var roomsToVisit = haveKey.Where(x => !visited.Contains(x)).ToList();

                foreach (var room in roomsToVisit)
                {
                    var keys = rooms[room];

                    visited.Add(room);

                    foreach (var key in keys)
                    {
                        if (!haveKey.Contains(key))
                        {
                            haveKey.Add(key);
                        }
                    }
                }
            }

            if (visited.Count == rooms.Count)
            {
                return true;
            }

            return false;
        }
    }
}
