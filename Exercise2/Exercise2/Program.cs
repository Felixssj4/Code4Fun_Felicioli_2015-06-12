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
            List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<double> ld = new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10 };
            List<string> ls = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            
            LinkedList<int> lli = new LinkedList<int>(li);
            LinkedList<double> lld = new LinkedList<double>(ld);
            LinkedList<string> lls = new LinkedList<string>(ls);
            
            try 
            { 
                Console.Write(GetNthElemntOfList(4, lli).ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            Console.Write("\r\n");

            try
            {
                Console.Write(GetNthElemntOfList(6, lld).ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            Console.Write("\r\n");

            try 
            { 
                Console.Write(GetNthElemntOfList(8, lls).ToString());
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
