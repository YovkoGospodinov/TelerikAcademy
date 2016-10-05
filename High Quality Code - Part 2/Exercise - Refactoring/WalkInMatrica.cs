using System;

namespace Refactoring
{
    public class WalkInMatrix
    {
        public static void Main()
        {
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int matrixSize = 0;
            while (!int.TryParse(input, out matrixSize) || matrixSize < 0 || matrixSize > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            FillMatrix(matrixSize);
        }

        private static void DirectionChange(ref int rowUpdater, ref int colUpdater)
        {
            int[] rowDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int steps = rowDirections.Length;
            int indexDirection = 0;
            for (int i = 0; i < steps; i++)
            {
                if (rowDirections[i] == rowUpdater && colDirections[i] == colUpdater)
                {
                    indexDirection = i;

                    break;
                }
            }

            if (indexDirection == steps - 1)
            {
                rowUpdater = rowDirections[0];
                colUpdater = colDirections[0];

                return;
            }

            rowUpdater = rowDirections[indexDirection + 1];
            colUpdater = colDirections[indexDirection + 1];
        }

        private static bool HasEmptyCellArraund(int[,] matrix, int x, int y)
        {
            int[] rowDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] colDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int steps = rowDirections.Length;
            int matrixSize = matrix.GetLength(0);
            for (int i = 0; i < steps; i++)
            {
                bool xOutOfMatrix = x + rowDirections[i] >= matrixSize || x + rowDirections[i] < 0;
                bool yOutOfMatrix = y + colDirections[i] >= matrixSize || y + colDirections[i] < 0;
                if (xOutOfMatrix)
                {
                    rowDirections[i] = 0;
                }

                if (yOutOfMatrix)
                {
                    colDirections[i] = 0;
                }

                bool hasEmpyCellArround = matrix[x + rowDirections[i], y + colDirections[i]] == 0;

                if (hasEmpyCellArround)
                {
                    return true;
                }
            }

            return false;
        }

        private static int[] FindEmptyCell(int[,] matrix)
        {
            int matrixSize = matrix.GetLength(0);
            int[] emptyCellCoords;

            for (int currentRow = 0; currentRow < matrixSize; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrixSize; currentCol++)
                {
                    if (matrix[currentRow, currentCol] == 0)
                    {
                        emptyCellCoords = new int[] { matrix[currentRow, currentCol], currentRow, currentCol };

                        return emptyCellCoords;
                    }
                }
            }

            return null;
        }

        private static void FillMatrix(int matrixSize)
        {
            int[,] matrix = new int[matrixSize, matrixSize];
            int steps = matrixSize;
            int stepsCount = 1;
            int rowCoordinate = 0;
            int colCoordinate = 0;
            int rowUpdater = 1;
            int colUpdater = 1;

            while (true)
            {
                matrix[rowCoordinate, colCoordinate] = stepsCount;

                bool hasReachedDeadEnd = !HasEmptyCellArraund(matrix, rowCoordinate, colCoordinate);
                bool hasNoEmptyCells = hasReachedDeadEnd && FindEmptyCell(matrix) == null;

                if (hasNoEmptyCells)
                {
                    PrintMatrix(matrix);
                    break;
                }
                else if (hasReachedDeadEnd)
                {
                    var cellCoordinates = FindEmptyCell(matrix);
                    matrix[cellCoordinates[1], cellCoordinates[2]] = stepsCount;
                }
                else
                {
                    MoveToEmptyCell(matrix, ref rowCoordinate, ref colCoordinate, rowUpdater, colUpdater, matrixSize, ref stepsCount);
                }
            }
        }

        private static void MoveToEmptyCell(
            int[,] matrix,
            ref int rowCoordinate,
            ref int colCoordinate,
            int rowUpdater,
            int colwUpdater,
            int cellsNumber,
            ref int stepsCount)
        {
            while (rowCoordinate + rowUpdater >= cellsNumber || rowCoordinate + rowUpdater < 0
                   || colCoordinate + colwUpdater >= cellsNumber || colCoordinate + colwUpdater < 0 ||
                   matrix[rowCoordinate + rowUpdater, colCoordinate + colwUpdater] != 0)
            {
                DirectionChange(ref rowUpdater, ref colwUpdater);
            }

            rowCoordinate += rowUpdater;
            colCoordinate += colwUpdater;

            stepsCount++;
        }

        private static void PrintMatrix(int[,] matrix)
        {
            int matrixSize = matrix.GetLength(0);

            for (int currentRow = 0; currentRow < matrixSize; currentRow++)
            {
                for (int currentCol = 0; currentCol < matrixSize; currentCol++)
                {
                    Console.Write("{0,3}", matrix[currentRow, currentCol]);
                }

                Console.WriteLine();
            }
        }
    }
}
