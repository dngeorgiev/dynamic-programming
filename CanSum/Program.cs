using System;
using System.Collections.Generic;

namespace CanSum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CanSum(7, new List<int> { 2, 3 })); // true
            Console.WriteLine(CanSum(7, new List<int> { 5, 3, 4, 7 })); // true
            Console.WriteLine(CanSum(7, new List<int> { 2, 4 })); // false
            Console.WriteLine(CanSum(8, new List<int> { 2, 3, 5 })); // true
            Console.WriteLine(CanSum(300, new List<int> { 7, 14 })); // false
        }

        private static bool CanSum(int target, List<int> numbers, Dictionary<int, bool> memo = null)
        {
            if (memo != null && memo.ContainsKey(target)) return memo[target];
            if (target == 0) return true;
            if (target < 0) return false;

            if (memo == null) memo = new Dictionary<int, bool>();
            foreach (var num in numbers)
            {
                var remainder = target - num;
                if (CanSum(remainder, numbers, memo))
                {
                    memo[target] = true;
                    return memo[target];
                }
            }

            memo[target] = false;
            return memo[target];
        }
    }
}
