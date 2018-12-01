﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moemi_Hagiyama_Lab03_Ex2_LinkedListLibrary
{
    // class to represent one node in a list
    public class ListNode<T>
    {
        // automatic read-only property Data
        public T Data { get; private set; }

        // automatic property Next
        public ListNode<T> Next { get; set; }

        // constructor to create ListNode that refers to dataValue
        // and is last node in list
        public ListNode(T dataValue) : this(dataValue, null) { }

        // constructor to create ListNode that refers to dataValue
        // and refers to next ListNode in List
        public ListNode(T dataValue, ListNode<T> nextNode)
        {
            Data = dataValue;
            Next = nextNode;
        }
    }

    // class List declaration
    public class List<T>
    {
        protected ListNode<T> firstNode;
        protected ListNode<T> lastNode;
        private string name; // string like "list" to display

        // construct empty List with specified name
        public List(string listName)
        {
            name = listName;
            firstNode = lastNode = null;
        }

        public ListNode<T> FirstNode
        {
            get
            {
                return firstNode;
            }
        }
        public ListNode<T> LastNode
        {
            get
            {
                return lastNode;
            }
        }

        // construct empty List with "list" as its name 
        public List() : this("list") { }

        // Insert T at front of List. If List is empty, 
        // firstNode and lastNode will refer to same T.
        // Otherwise, firstNode refers to new node.
        public void InsertAtFront(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                firstNode = new ListNode<T>(insertItem, firstNode);
            }
        }

        // Insert T at end of List. If List is empty, 
        // firstNode and lastNode will refer to same T.
        // Otherwise, lastNode's Next property refers to new node.
        public void InsertAtBack(T insertItem)
        {
            if (IsEmpty())
            {
                firstNode = lastNode = new ListNode<T>(insertItem);
            }
            else
            {
                lastNode = lastNode.Next = new ListNode<T>(insertItem);
            }
        }

        // remove first node from List
        public T RemoveFromFront()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = firstNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                firstNode = firstNode.Next;
            }

            return removeItem; // return removed data
        }

        // remove last node from List
        public T RemoveFromBack()
        {
            if (IsEmpty())
            {
                throw new EmptyListException(name);
            }

            T removeItem = lastNode.Data; // retrieve data

            // reset firstNode and lastNode references
            if (firstNode == lastNode)
            {
                firstNode = lastNode = null;
            }
            else
            {
                ListNode<T> current = firstNode;

                // loop while current.Next is not lastNode
                while (current.Next != lastNode)
                {
                    current = current.Next; // move to next node
                }

                // current is new lastNode
                lastNode = current;
                current.Next = null;
            }

            return removeItem; // return removed data
        }

        // return true if List is empty
        public bool IsEmpty()
        {
            return firstNode == null;
        }

        // output List contents
        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                Console.Write($"The {name} is: ");

                ListNode<T> current = firstNode;

                // output current node data while not at end of list
                while (current != null)
                {
                    Console.Write($"{current.Data} ");
                    current = current.Next;
                }

                Console.WriteLine("\n");
            }
        }
        public void Search(T search)
        {
            if (IsEmpty())
            {
                Console.WriteLine($"Empty {name}");
            }
            else
            {
                ListNode<T> current = firstNode;
                while (current != null)
                {
                    if (current.Data.Equals(search))
                    {
                        Console.WriteLine($"the data found : Search data{search}");
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }

        }

        public double Count()
        {
            ListNode<T> current = firstNode;
            double count = 0;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            Console.WriteLine($"the number of contents of the list is {count}");
            return count;
        }

        public double Avg()
        {
            ListNode<T> current = firstNode;
            double sum = 0;
            double ave = 0;
            while (current != null)
            {
                double result = 0;
                double.TryParse(current.Data.ToString(), out result);
                sum = sum + result;
                Console.WriteLine($"current sum is:{sum}");
                current = current.Next;
            }

            ave = sum / Count();
            return ave;
        }

        public string getFirst()
        {
            return firstNode.Data.ToString();
        }
    }

    // class EmptyListException declaration
    public class EmptyListException : Exception
    {
        // parameterless constructor
        public EmptyListException() : base("The list is empty") { }

        // one-parameter constructor
        public EmptyListException(string name)
           : base($"The {name} is empty") { }

        // two-parameter constructor
        public EmptyListException(string exception, Exception inner)
           : base(exception, inner) { }
    }
}
