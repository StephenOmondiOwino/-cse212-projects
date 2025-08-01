using System;
using System.Collections.Generic;
using System.Linq;

public class Recursion
{
    // PROBLEM 1: SUM OF SQUARES
    public static int SumSquaresRecursive(int n)
    {
        if (n <= 0)
            return 0;
        return n * n + SumSquaresRecursive(n - 1);
    }

    // PROBLEM 2: PERMUTATIONS
    public static void Permutations(List<string> results, string prefix, string remaining)
    {
        if (remaining.Length == 0)
        {
            results.Add(prefix);
            return;
        }

        for (int i = 0; i < remaining.Length; i++)
        {
            string newPrefix = prefix + remaining[i];
            string newRemaining = remaining.Substring(0, i) + remaining.Substring(i + 1);
            Permutations(results, newPrefix, newRemaining);
        }
    }

    // PROBLEM 3: CLIMB STAIRS MEMOIZATION
    public static int ClimbStairsMemo(int n, Dictionary<int, int>? memo = null)
    {
        if (memo == null)
            memo = new Dictionary<int, int>();

        if (n == 0 || n == 1)
            return 1;

        if (memo.ContainsKey(n))
            return memo[n];

        int result = ClimbStairsMemo(n - 1, memo) + ClimbStairsMemo(n - 2, memo);
        memo[n] = result;
        return result;
    }

    // PROBLEM 4: BINARY WILDCARD MATCHING
    public static void BinaryWildcardMatch(List<string> results, string pattern, string built = "")
    {
        if (pattern.Length == 0)
        {
            results.Add(built);
            return;
        }

        if (pattern[0] == '?')
        {
            BinaryWildcardMatch(results, pattern.Substring(1), built + "0");
            BinaryWildcardMatch(results, pattern.Substring(1), built + "1");
        }
        else
        {
            BinaryWildcardMatch(results, pattern.Substring(1), built + pattern[0]);
        }
    }
}
    // PROBLEM 5: SOLVE MAZE
    