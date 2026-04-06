namespace LeetCode2026.Simulations;

// 874. Walking Robot Simulation
// A robot on an infinite plane starts at (0, 0) and faces north. The robot can receive one of three instructions:
// -2: Turn left 90 degrees.
// -1: Turn right 90 degrees.
// 1 <= k <= 9: Move forward k units, one unit at a time.
// Some of the grid squares are obstacles. The ith obstacle is at grid point obstacles[i] = (xi, yi). If the robot runs into an obstacle, it will stay in its current location (on the block adjacent to the obstacle) and move onto the next command.
// Return the maximum squared Euclidean distance that the robot reaches at any point in its path (i.e. if the distance is 5, return 25).


public class WalkingRobotSimulationSolution
{
    public int RobotSim(int[] commands, int[][] obstacles)
    {
        var obstacleSet = new HashSet<(int, int)>(obstacles.Select(o => (o[0], o[1])));
        var robot = new Robot();
        int maxDist = 0;

        foreach (int cmd in commands)
        {
            if (cmd == -2) robot.TurnLeft();
            else if (cmd == -1) robot.TurnRight();
            else
            {
                robot.Move(cmd, obstacleSet);
                maxDist = Math.Max(maxDist, robot.X * robot.X + robot.Y * robot.Y);
            }
        }

        return maxDist;
    }

    public class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Direction { get; private set; } // 0: north, 1: east, 2: south, 3: west

        private static readonly int[] dx = [0, 1, 0, -1];
        private static readonly int[] dy = [1, 0, -1, 0];

        public void TurnLeft()
        {
            Direction = (Direction + 3) % 4;
        }

        public void TurnRight()
        {
            Direction = (Direction + 1) % 4;
        }

        public void Move(int k, HashSet<(int, int)> obstacles)
        {
            for (int i = 0; i < k; i++)
            {
                int nx = X + dx[Direction];
                int ny = Y + dy[Direction];
                if (obstacles.Contains((nx, ny))) break;
                X = nx;
                Y = ny;
            }
        }
    }
}
