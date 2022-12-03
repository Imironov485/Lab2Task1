using Repeats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Task8
{
    internal class Functions
    {
        public static int[] Search(int[] array)
        {
            int value = R.IntTryParse();
            bool trySearch = false;
            int count = 0;
            int arrayIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    count++;
                    trySearch = true;
                }
            }
            if (trySearch)
            {
                int[] result = new int[count];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == value)
                    {
                        result[arrayIndex] = i;
                        arrayIndex++;
                    }
                }
                return result;

            }
            else
            {
                int[] result = Array.Empty<int>();
                return result;
            }

        }
    }
}
