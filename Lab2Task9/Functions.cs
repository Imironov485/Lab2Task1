
namespace Lab2Task9
{
    internal class Functions
    {
        public static bool Code(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
