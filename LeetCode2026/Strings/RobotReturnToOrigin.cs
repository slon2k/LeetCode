namespace LeetCode2026.Strings;

// 657. Robot Return to Origin
// There is a robot starting at the position (0, 0), the origin, on a 2D plane. Given a sequence of its moves, judge if this robot ends up at (0, 0) after it completes its moves.


public class RobotReturnToOriginSolution
{
    public bool JudgeCircle(string moves)
    {
        int x = 0, y = 0;

        foreach (char move in moves)
        {
            switch (move)
            {
                case 'U': y++; break;
                case 'D': y--; break;
                case 'L': x--; break;
                case 'R': x++; break;
            }
        }

        return x == 0 && y == 0;
    }
}

