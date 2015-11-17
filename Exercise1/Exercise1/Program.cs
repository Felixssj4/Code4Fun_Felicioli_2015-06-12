using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 30;

            Console.Write("Random Array 1\r\n\r\n");

            int[] arr1 = RandomArrayWithList(n);
            for (int x = 0; x < n; x++)
                Console.Write(arr1[x] + " ");
            /*gbcgbsb*/
            arr1 = arr1.OrderBy(x => x).ToArray();

            Console.Write("\r\n\nRight Array 1\r\n\r\n");

            for (int x = 0; x < n; x++)
                Console.Write(arr1[x] + " ");

            Console.Write("\r\n\r\nRandom Array 2\r\n\r\n");

            int[] arr2 = RandomArrayWithoutList(n);
            for (int x = 0; x < n; x++)
                Console.Write(arr2[x] + " ");

            arr2 = arr2.OrderBy(x => x).ToArray();

            Console.Write("\r\n\nRight Array 2\r\n\r\n");

            for (int x = 0; x < n; x++)
                Console.Write(arr2[x] + " ");

            Console.ReadKey();
        }

        public static int[] RandomArrayWithList(int N)
        {
            int[] array = new int[N];

            List<int> app = new List<int>();

            for (int x = 1; x <= N; x++)
            {
                app.Add(x);
            }

            Random rnd = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
            int rndIndex = 0;
            int index = 0;

            while (app.Count > 0)
            {
                rndIndex = rnd.Next(0, app.Count() - 1);
                array[index] = app[rndIndex];
                app.RemoveAt(rndIndex);
                index++;
            }
            return array;
        }

        public static int[] RandomArrayWithoutList(int N)
        {
            int[] array = new int[N];

            int[] app = new int[N];

            for (int x = 1; x <= N; x++)
            {
                app[x-1] = (x);
            }

            Random rnd = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));
            int rndIndex = 0;

            for (int i = 0; i < N; i++)
            {
                int[] tmp = new int[N - i - 1];
                rndIndex = rnd.Next(0, N - i - 1);
                array[i] = app[rndIndex];
                int k = 0;
                for (int j = 0; j < (N - i); j++)
                {
                    if (app[j] != array[i])
                    {
                        tmp[k] = app[j];
                        k++;
                    }
                }
                app = new int[N - i - 1];
                app = tmp;
            }
            return array;
        }
    }
}
