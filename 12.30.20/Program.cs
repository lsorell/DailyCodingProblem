using System;
using System.Collections.Generic;
using HelperLibrary;

namespace _12._30._20
{
    class Program
    {
        // Given a linked list of numbers and a pivot k, partition the linked list so that all nodes less than k come before nodes greater than or equal to k.
        // For example, given the linked list 5 -> 1 -> 8 -> 0 -> 3 and k = 3, the solution could be 1 -> 0 -> 5 -> 8 -> 3.
        static void Main(string[] args)
        {
            Node test1 = Helpers.BuildLinkedList(new List<int> { 5, 1, 8, 0, 3 });
            Node result1 = PivotLinkedList(test1, 3);
            Node test2 = Helpers.BuildLinkedList(new List<int> { 5, 1, 8, 0, 3, 0, 0, 4, 3 });
            Node result2 = PivotLinkedList(test2, 8);
            Helpers.PrintLinkedList(result1);
            Helpers.PrintLinkedList(result2);
        }

        public static Node PivotLinkedList(Node head, int pivot)
        {
            Node lessPntr = null;
            Node greaterPntr = null;
            Node lessHead = null;
            Node greaterHead = null;
            while (head != null)
            {
                Node n = new Node(head.Val);
                if (head.Val < pivot)
                {
                    if (lessHead == null)
                    {
                        lessHead = lessPntr = n;
                    }
                    else
                    {
                        lessPntr.Next = n;
                        lessPntr = lessPntr.Next;
                    }
                }
                else
                {
                    if (greaterHead == null)
                    {
                        greaterHead = greaterPntr = n;
                    }
                    else
                    {
                        greaterPntr.Next = n;
                        greaterPntr = greaterPntr.Next;
                    }
                }
                head = head.Next;
            }

            if (lessHead == null)
            {
                return greaterHead;
            }

            lessPntr.Next = greaterHead;
            return lessHead;
        }
    }
}
