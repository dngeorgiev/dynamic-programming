using System;
using System.Collections.Generic;

namespace GridTraveler
{
    // Get m(rows) and n(columns) and find out how much posibilities the traveler has to move if he's only allowed to move down and right
    class GridTraveler
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(GetPossibleMoves(3, 3));
            Console.WriteLine(GetPossibleMoves(5, 3));
            Console.WriteLine(GetPossibleMoves(8, 8));
            Console.WriteLine(GetPossibleMoves(30, 30));
            Console.WriteLine(GetPossibleMoves(50, 50));
        }

        private static ulong GetPossibleMoves(int row, int col, Dictionary<string, ulong> memo = null)
        {
            string key = row + "," + col;
            if (memo != null && memo.ContainsKey(key)) return memo[key];
            if (row == 1 && col == 1) return 1;
            if (row == 0 || col == 0) return 0;

            if (memo == null) memo = new Dictionary<string, ulong>();
            memo[key] = GetPossibleMoves(row - 1, col, memo) + GetPossibleMoves(row, col - 1, memo);

            return memo[key];
        }
    }
}
