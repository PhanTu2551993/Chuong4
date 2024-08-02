namespace Chương_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập một số nguyên ở hệ thập phân: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(decimalNumber, 2);

            Console.WriteLine($"Dãy nhị phân của {decimalNumber} là: {binaryNumber}");
        }
    }
}
