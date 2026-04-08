namespace LeetCode2026.Simulations;

// 3653. Xor After Range Multiplication Queries I
// You are given an integer array nums of length n and a 2D integer array queries of size q, where queries[i] = [li, ri, ki, vi].
// For each query, you must apply the following operations in order:
// Set idx = li.
// While idx <= ri:
// Update: nums[idx] = (nums[idx] * vi) % (109 + 7)
// Set idx += ki.
// Return the bitwise XOR of all elements in nums after processing all queries.

public class XorAfterRangeMultiplicationQueriesISolution 
{
    private const int MOD = 1_000_000_007;

    public int XorAfterQueries(int[] nums, int[][] queries) {
        foreach (var query in queries) {
            int li = query[0], ri = query[1], ki = query[2], vi = query[3];
            for (int idx = li; idx <= ri; idx += ki) {
                nums[idx] = (int)((long)nums[idx] * vi % MOD);
            }
        }

        int result = 0;
        foreach (var num in nums) {
            result ^= num;
        }
        return result;
    }
}