using System;
using System.Text;
using System.Collections.Generic;

namespace HelperLibrary
{
    public static class Helpers
    {
        public static void PrintEnumerable<T>(IEnumerable<T> collection)
        {
            StringBuilder sb = new StringBuilder("[");
            foreach (var item in collection)
            {
                sb.Append(item.ToString() + ", ");
            }
            sb.Length = sb.Length - 2;
            sb.Append("]");

            Console.WriteLine(sb.ToString());
        }

        public static void PrintLinkedList(Node head)
        {
            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Append(head.Val + " -> ");
                head = head.Next;
            }
            sb.Length = sb.Length - 4;

            Console.WriteLine(sb.ToString());
        }

        public static Node BuildLinkedList(List<int> values)
        {
            Node head = null;
            Node pntr = null;
            foreach (int val in values)
            {
                Node n = new Node(val);
                if (head == null)
                {
                    head = pntr = n;
                }
                else
                {
                    pntr.Next = n;
                    pntr = pntr.Next;
                }
            }

            return head;
        }
    }
}