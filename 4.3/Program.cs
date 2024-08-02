namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Nhập số phần tử của dãy a: ");
                int m = int.Parse(Console.ReadLine());
                double[] a = new double[m];
                Console.WriteLine("Nhập các phần tử của dãy a:");
                for (int i = 0; i < m; i++)
                {
                    a[i] = double.Parse(Console.ReadLine());
                }

                Console.Write("Nhập số phần tử của dãy b: ");
                int n = int.Parse(Console.ReadLine());
                double[] b = new double[n];
                Console.WriteLine("Nhập các phần tử của dãy b:");
                for (int i = 0; i < n; i++)
                {
                    b[i] = double.Parse(Console.ReadLine());
                }

                double[] c = MergeSortedArrays(a, b);

                Console.WriteLine("Dãy c sau khi hợp và sắp xếp là:");
                foreach (double num in c)
                {
                    Console.Write(num + " ");
                }
            }

            static double[] MergeSortedArrays(double[] a, double[] b)
            {
                int m = a.Length;
                int n = b.Length;
                double[] c = new double[m + n];
                int i = 0, j = 0, k = 0;

                while (i < m && j < n)
                {
                    if (a[i] <= b[j])
                    {
                        c[k++] = a[i++];
                    }
                    else
                    {
                        c[k++] = b[j++];
                    }
                }

                while (i < m)
                {
                    c[k++] = a[i++];
                }

                while (j < n)
                {
                    c[k++] = b[j++];
                }

                return c;
            }
        }
    }
}
