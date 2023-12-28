namespace LeetCode.LeetCode150.Stack;

public class SimplifyPath
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new();

            while (path.IndexOf("//") != -1)
            {
                path = path.Replace("//", "/");
            }

            var folders = path.Split('/');

            foreach (var folder in folders.Where(f => f != ""))
            {
                if (folder == "..")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                } else if (folder == ".")
                {
                    continue;
                } else
                {
                    stack.Push(folder);
                }
            }

            string result = "";

            while (stack.Count > 0)
            {
                result = "/" + stack.Pop() + result;
            }

            return result == "" ? "/" : result;
        }
    }
}
