using System;
using Moemi_Hagiyama_Lab03_Ex2_LinkedListLibrary;

namespace Moemi_Hagiyama_Lab03_Ex2_LinkedListTest
{
    class ListTest
    {
        static void Main()
        {
            var list = new List<double>();

            // use List insert methods       
            list.InsertAtFront(30.45);
            list.InsertAtFront(56.34);
            list.InsertAtBack(23.78);
            list.InsertAtBack(12.23);


            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("<< Empty List Exception test >>");
            Console.WriteLine("list contents:");
                              list.Display();
            Console.WriteLine("-------------------------------------------");

            // get first data
            try
            {
                Console.WriteLine($"First element: {list.GetFirst()}");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // get last data
            try
            {
                Console.WriteLine($"Last element: {list.GetLast()}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // preparing for the test of exception (EmptyListException)
            while (!list.IsEmpty())
            {
                list.RemoveFromBack();
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("<< Empty List Exception test >>");
            Console.WriteLine("list contents:");
                                list.Display();
            Console.WriteLine("-------------------------------------------");


            try
            {
                Console.WriteLine($"First element: {list.GetFirst()}");
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Console.WriteLine($"Last element: {list.GetLast()}");
            }
            catch (EmptyListException emptyListException)
            {
                Console.Error.WriteLine($"\n{emptyListException}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    public static class ExtendLinkedListLibrary
    {
        public static T GetFirst<T>(this List<T> list)
        {
            if (!list.IsEmpty())
            {
                return list.FirstNode.Data;
            }
            else
            {
                throw new EmptyListException();
            }
            
        }
        public static T GetLast<T>(this List<T> list)
        {
            if (!list.IsEmpty())
            {
                return list.LastNode.Data;
            }
            else
            {
                throw new EmptyListException();
            }
        }
    }

}
