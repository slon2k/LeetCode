namespace LeetCode2026.Simulations;

// 2069. Walking Robot Simulation II
// A width x height grid is on an XY-plane with the bottom-left cell at (0, 0) and the top-right cell at (width - 1, height - 1). The grid is aligned with the four cardinal directions ("North", "East", "South", and "West"). A robot is initially at cell (0, 0) facing direction "East".

// The robot can be instructed to move for a specific number of steps. For each step, it does the following.

// Attempts to move forward one cell in the direction it is facing.
// If the cell the robot is moving to is out of bounds, the robot instead turns 90 degrees counterclockwise and retries the step.
// After the robot finishes moving the number of steps required, it stops and awaits the next instruction.

// Implement the Robot class:

// Robot(int width, int height) Initializes the width x height grid with the robot at (0, 0) facing "East".
// void step(int num) Instructs the robot to move forward num steps.
// int[] getPos() Returns the current cell the robot is at, as an array of length 2, [x, y].
// String getDir() Returns the current direction of the robot, "North", "East", "South", or "West".

// 
// Your Robot object will be instantiated and called as such:
// Robot obj = new Robot(width, height);
//  obj.Step(num);
//  int[] param_2 = obj.GetPos();
//  string param_3 = obj.GetDir();
//  

public class Robot 
{
    private readonly int width;
    private readonly int height;
    private int x;
    private int y;
    private int direction; // 0: North, 1: East, 2: South, 3: West
    private long totalSteps = 0;
    private static readonly string[] directions = ["North", "East", "South", "West"];


    public Robot(int width, int height) 
    {
        if (width == 1 && height == 1)
            throw new ArgumentException("Grid must be larger than 1x1.");
        this.width = width;
        this.height = height;
        this.x = 0;
        this.y = 0;
        this.direction = 1; // Initially facing East
    }
    
    public void Step(int num) 
    {
        int perimeter = 2 * (width + height - 2);
        totalSteps += num;
        int p = (int)(totalSteps % perimeter);

        if (p == 0) {
            x = 0; y = 0; direction = 2; // South: completed a full cycle
        } else if (p < width) {
            x = p; y = 0; direction = 1; // East: bottom edge
        } else if (p <= width + height - 2) {
            x = width - 1; y = p - (width - 1); direction = 0; // North: right edge
        } else if (p <= 2 * width + height - 3) {
            x = 2 * width + height - 3 - p; y = height - 1; direction = 3; // West: top edge
        } else {
            x = 0; y = perimeter - p; direction = 2; // South: left edge
        }
    }
    
    public int[] GetPos() 
    {
        return [x, y];
    }
    
    public string GetDir() {
        return directions[direction];
    }
}

