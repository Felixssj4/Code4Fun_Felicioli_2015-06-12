using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 1, 2, 3, 4, 5 };
            
            LinkedList<int> ll = new LinkedList<int>(l);

            try 
            { 
                Console.Write(GetNthElemntOfList(0, ll).ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
                
            Console.ReadKey();
        }

        public static T GetNthElemntOfList<T>(int N, LinkedList<T> lista)
        {
            LinkedListNode<T> n1 = lista.First;
            LinkedListNode<T> n2 = lista.First;
            int count = 1;

            if (N <= 0)
                throw new Exception("Il numero dell'elemento richiesto deve essere maggiore di 0 ");

            while (n2.Next != null)
            {
                count++;
                if (count > N)
                    n1 = n1.Next;
                n2 = n2.Next;
            }

            if (count < N)
                throw new Exception("La lista non contiene " + N + " elementi.");


            return n1.Value;
        }
    }
}
