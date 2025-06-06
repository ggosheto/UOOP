using System;

class Program
{
    static void Main()
    {
        // Read matrix size
        Console.Write("Enter number of rows and columns (e.g. 3 3): ");
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[,] ticket = new int[n, m];

        // Read matrix rows
        Console.WriteLine("Enter the matrix rows (numbers separated by space):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Row {i + 1}: ");
            string[] rowInput = Console.ReadLine().Split();
            for (int j = 0; j < m; j++)
            {
                ticket[i, j] = int.Parse(rowInput[j]);
            }
        }

        int mainDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        int sumAboveMainDiagonal = 0;
        int sumBelowMainDiagonal = 0;
        int evenOnMainDiagonalSum = 0;
        int evenOnOuterRowsSum = 0;
        int oddOnOuterColumnsSum = 0;

        // Calculate sums
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                int value = ticket[i, j];

                if (i == j) // on main diagonal
                {
                    mainDiagonalSum += value;
                    if (value % 2 == 0)
                    {
                        evenOnMainDiagonalSum += value;
                    }
                }

                if (i + j == n - 1) // on secondary diagonal
                {
                    secondaryDiagonalSum += value;
                }

                if (i < j) // above main diagonal
                {
                    sumAboveMainDiagonal += value;
                }

                if (i > j) // below main diagonal
                {
                    sumBelowMainDiagonal += value;
                }

                if (i == 0 || i == n - 1) // outer rows
                {
                    if (value % 2 == 0)
                    {
                        evenOnOuterRowsSum += value;
                    }
                }

                if (j == 0 || j == m - 1) // outer columns
                {
                    if (value % 2 == 1)
                    {
                        oddOnOuterColumnsSum += value;
                    }
                }
            }
        }

        // Check winning conditions
        bool isWinner = 
            mainDiagonalSum == secondaryDiagonalSum &&
            sumAboveMainDiagonal % 2 == 0 &&
            sumBelowMainDiagonal % 2 == 1;

        if (isWinner)
        {
            double prize = (sumBelowMainDiagonal + evenOnMainDiagonalSum + evenOnOuterRowsSum + oddOnOuterColumnsSum) / 4.0;
            Console.WriteLine("YES");
            Console.WriteLine($"Prize: {prize:F2}");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
