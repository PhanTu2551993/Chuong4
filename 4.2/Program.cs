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


            // Mảng lưu trữ các mức giá
            int[] prices = { 500, 550, 600, 650 };

            // Mảng lưu trữ các giới hạn tiêu thụ
            int[] limits = { 100, 150, 200};

            int cost = 0;
            int remainingKW = totalKW;

            for (int i = 0; i < limits.Length; i++)
            {
                if (remainingKW <= 0)
                    break;

                int kwAtCurrentRate = (i == 0) ? limits[i] : limits[i] - limits[i - 1];
                if (remainingKW <= kwAtCurrentRate)
                {
                    cost += remainingKW * prices[i];
                    remainingKW = 0;
                }
                else
                {
                    cost += kwAtCurrentRate * prices[i];
                    remainingKW -= kwAtCurrentRate;
                }
            }


            if (remainingKW > 0)
            {
                cost += remainingKW * prices[prices.Length - 1];
            }

            return cost;
        }
    }
}
