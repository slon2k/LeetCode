namespace LeetCode2026.BinarySearch;

// 1665. Minimum Initial Energy to Finish Tasks
// You are given an array tasks where tasks[i] = [actuali, minimumi]:

// actual i is the actual amount of energy you spend to finish the ith task.
// minimum i is the minimum amount of energy you require to begin the ith task.
// For example, if the task is [10, 12] and your current energy is 11, you cannot start this task. However, if your current energy is 13, 
// you can complete this task, and your energy will be 3 after finishing it.

// You can finish the tasks in any order you like.

// Return the minimum initial amount of energy you will need to finish all the tasks.

public class MinimumInitialEnergyToFinishTasks
{
    public int MinimumEffort(int[][] tasks)
    {
        var taskList = tasks
            .Select(t => (actual: t[0], minimum: t[1]))
            .OrderBy(t => t.actual - t.minimum);

        var energy = 0;
        var currentEnergy = 0;

        foreach (var (actual, minimum) in taskList)
        {
            if (currentEnergy < minimum)
            {
                energy += minimum - currentEnergy;
                currentEnergy = minimum;
            }

            currentEnergy -= actual;
        }

        return energy;
    }
}