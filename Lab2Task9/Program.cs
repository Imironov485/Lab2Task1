using Repeats;

namespace Lab2Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = new int[5] { 1, 10, 15, 4, 3 };
            int[] arrayTwo = new int[5] { 10, 15, 1, 3, 4 };
            Console.WriteLine("Массив 1:");
            R.PrintArray(arrayOne);
            Console.WriteLine("\nМассив 2:");
            R.PrintArray(arrayTwo);
            if (Functions.Code(arrayOne, arrayTwo))
            {
                Console.WriteLine("\nМассивы равны");
                return;
            }
            Console.WriteLine("\nМассивы не равны");

        }
    }
}