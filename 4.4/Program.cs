using System.Text;
using System.Text.RegularExpressions;

namespace _4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string inputText = " Trần Hưng Đạo ";
            string outputText = RemoveExtraSpaces(inputText);
            Console.WriteLine($"Chuỗi sau khi loại bỏ dấu cách thừa: \"{outputText}\"");
        }

        static string RemoveExtraSpaces(string text)
        {
            text = Regex.Replace(text, @"\s+", " ");

            text = text.Trim();

            return text;
        }
    }
}
