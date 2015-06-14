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
            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<double> listDouble = new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10 };
            List<string> listString = new List<string>() { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            
            LinkedList<int> linkedListInt = new LinkedList<int>(listInt);
            LinkedList<double> linkedListDouble = new LinkedList<double>(listDouble);
            LinkedList<string> linkedListString = new LinkedList<string>(listString);
            
            try 
            { 
                Console.Write(GetNthElemntOfList(4, linkedListInt).ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            Console.Write("\r\n");

            try
            {
                Console.Write(GetNthElemntOfList(6, linkedListDouble).ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }

            Console.Write("\r\n");

            try 
            { 
                Console.Write(GetNthElemntOfList(8, linkedListString).ToString());
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
                
            Console.ReadKey();
        }

        public static T GetNthElemntOfList<T>(int N, LinkedList<T> lista)
        {
            LinkedListNode<T> node1 = lista.First;
            LinkedListNode<T> node2 = lista.First;
            int count = 1;

            if (N <= 0)
                throw new Exception("Il numero dell'elemento richiesto deve essere maggiore di 0 ");

            while (node2.Next != null)
            {
                count++;
                if (count > N)
                    node1  = node1.Next;
                node2 = node2.Next;
            }

            if (count < N)
                throw new Exception("La lista non contiene " + N + " elementi.");


            return node1.Value;
        }
    }
}
