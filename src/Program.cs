using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public class Program
    {
        private static bool IsValidDigit(int number) => number >= 0 && number <= 9;

        private static bool Contains(int[] array, int value) => array.Length == 0 ? false : Array.BinarySearch(array, value) >= 0;

        public static bool IsSudokuPuzzleSolved(int[][] puzzle)
        {
            //  here we're assuming the matrix is a square
            var length = puzzle.LongLength;
            Dictionary<int, int[]> cols = new Dictionary<int, int[]>();
            for (int rowIndex = 0; rowIndex < length; rowIndex++)
            {
                var row = puzzle[rowIndex];

                for (int colIndex = 0; colIndex < length; colIndex++)
                {
                    if (!cols.ContainsKey(colIndex))
                    {
                        cols.Add(colIndex, new int[length]);
                    }

                    var cell = row[colIndex];
                    var rowSegment = new int[colIndex];
                    Array.Copy(row, rowSegment, colIndex);

                    if (IsValidDigit(cell) && !Contains(rowSegment, cell))
                    {
                        var col = cols[colIndex];
                        col[rowIndex] = cell;

                        var colSegment = new int[rowIndex];
                        Array.Copy(col, colSegment, rowIndex);
                        if (!Contains(colSegment, cell))
                        {
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}