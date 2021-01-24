using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetFibonacci(3));
            Console.WriteLine(GetFibonacci(6));
            Console.WriteLine(GetFibonacci(8));
            Console.WriteLine(GetFibonacci(80));
        }

        private static ulong GetFibonacci(int n, Dictionary<int, ulong> memo = null)
        {
            if (memo != null && memo.ContainsKey(n)) return memo[n];
            if (n <= 2) return 1;

            if (memo == null) memo = new Dictionary<int, ulong>();
            memo[n] = GetFibonacci(n - 1, memo) + GetFibonacci(n - 2, memo);

            return memo[n];
        }
    }
}
