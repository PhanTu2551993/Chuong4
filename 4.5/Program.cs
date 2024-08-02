namespace _4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ma trận vuông cấp 3
            double[,] matrix = { 
                { 1, 2, 3 },
                { 4, 5, 6 }, 
                { 7, 8, 10 } };

            // In ma trận ban đầu
            Console.WriteLine("Ma trận ban đầu:");
            PrintMatrix(matrix);

            // Tìm ma trận nghịch đảo
            double[,] inverseMatrix = GaussJordanInverse(matrix);

            if (inverseMatrix != null)
            {
                Console.WriteLine("Ma trận nghịch đảo:");
                PrintMatrix(inverseMatrix);
            }
            else
            {
                Console.WriteLine("Ma trận không có nghịch đảo.");
            }
        }

        static double[,] GaussJordanInverse(double[,] matrix)
        {
            int n = matrix.GetLength(0);

            // Tạo ma trận mở rộng
            double[,] augmentedMatrix = new double[n, 2 * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmentedMatrix[i, j] = matrix[i, j];
                    if (i == j)
                    {
                        augmentedMatrix[i, j + n] = 1;
                    }
                    else
                    {
                        augmentedMatrix[i, j + n] = 0;
                    }
                }
            }

            // Biến đổi hàng
            for (int i = 0; i < n; i++)
            {
                // Tìm hàng có giá trị lớn nhất tại cột i
                int maxRow = i;
                for (int k = i + 1; k < n; k++)
                {
                    if (Math.Abs(augmentedMatrix[k, i]) > Math.Abs(augmentedMatrix[maxRow, i]))
                    {
                        maxRow = k;
                    }
                }

                // Đổi hàng
                if (maxRow != i)
                {
                    for (int j = 0; j < 2 * n; j++)
                    {
                        double temp = augmentedMatrix[i, j];
                        augmentedMatrix[i, j] = augmentedMatrix[maxRow, j];
                        augmentedMatrix[maxRow, j] = temp;
                    }
                }

                // Kiểm tra xem có phải là ma trận không có nghịch đảo
                if (augmentedMatrix[i, i] == 0)
                {
                    return null;
                }

                // Chuẩn hóa hàng
                double pivot = augmentedMatrix[i, i];
                for (int j = 0; j < 2 * n; j++)
                {
                    augmentedMatrix[i, j] /= pivot;
                }

                // Khử các hàng khác
                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = augmentedMatrix[k, i];
                        for (int j = 0; j < 2 * n; j++)
                        {
                            augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
                        }
                    }
                }
            }

            // Trích xuất ma trận nghịch đảo
            double[,] inverse = new double[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    inverse[i, j] = augmentedMatrix[i, j + n];
                }
            }

            return inverse;
        }

        static void PrintMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
