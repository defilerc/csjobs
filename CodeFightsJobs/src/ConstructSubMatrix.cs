using System.Collections.Generic;
using System.Linq;

namespace CodeFights
{
    public class ConstructSubMatrix
    {
        public int[][] ConstructSubmatrix(int[][] matrix, int[] rowsToDelete, int[] columnsToDelete) 
        {
            var submatrix = new List<List<int>>();

            var iDest = 0;
            var jDest = 0;

            for (var i = 0; i < matrix.Length; i++) {
                if (rowsToDelete.Contains(i)) {
                    continue;
                }
                var row = new List<int>();

                for (var j = 0; j < matrix[0].Length; j++) {
                    if (columnsToDelete.Contains(j)) {
                        continue;
                    }
                    jDest++;

                    row.Add(matrix[i][j]);
                }

                iDest++;
                jDest = 0;

                submatrix.Add(row);
            }

            return submatrix.Select(a => a.ToArray()).ToArray();
        }
    }
}