namespace _4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số KW tiêu thụ: ");
            int totalKW = int.Parse(Console.ReadLine());

            int totalCost = CalculateElectricityBill(totalKW);

            Console.WriteLine($"Tổng số tiền điện phải trả là: {totalCost} đồng");
        }

        static int CalculateElectricityBill(int totalKW)
        {
            int cost = 0;

            if (totalKW <= 100)
            {
                cost = totalKW * 500;
            }
            else if (totalKW <= 150)
            {
                cost = 100 * 500 + (totalKW - 100) * 550;
            }
            else if (totalKW <= 200)
            {
                cost = 100 * 500 + 50 * 550 + (totalKW - 150) * 600;
            }
            else
            {
                cost = 100 * 500 + 50 * 550 + 50 * 600 + (totalKW - 200) * 650;
            }

            return cost;
        }
    }
}
