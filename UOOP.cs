 static void Main()
    {
        Console.Write("Number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        // Input the matrix
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Enter elements for row {i + 1}, separated by space:");
            string[] parts = Console.ReadLine().Split();

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = int.Parse(parts[j]);
            }
        }

        // Find minimum elements per column
        int[] minElements = new int[cols];

        for (int col = 0; col < cols; col++)
        {
            int min = matrix[0, col];
            for (int row = 1; row < rows; row++)
            {
                if (matrix[row, col] < min)
                {
                    min = matrix[row, col];
                }
            }
            minElements[col] = min;
        }

        // Print the matrix
        Console.WriteLine("The matrix is:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],5}");
            }
            Console.WriteLine();
        }

        // Print the minimum elements row
        Console.WriteLine("Minimum elements per column:");
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{minElements[j],5}");
        }
        Console.WriteLine();
    }
