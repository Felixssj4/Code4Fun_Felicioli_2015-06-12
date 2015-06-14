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
            int n = 50;

            Console.Write("Random Array\r\n\r\n");

            int[] arr = RandomArray(n);
            for (int x = 0; x < n; x++)
                Console.Write(arr[x] + " ");

            arr = arr.OrderBy(x => x).ToArray();

            Console.Write("\r\n\nRight Array \r\n\r\n");

            for (int x = 0; x < n; x++)
                Console.Write(arr[x] + " ");

            Console.ReadKey();
        }

        public static int[] RandomArray(int N)
        {
            int[] array = new int[N];

            List<int> app = new List<int>();

            for (int x = 1; x <= N; x++)
            {
                app.Add(x);
            }

            Random rnd = new Random();
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
    }
}
