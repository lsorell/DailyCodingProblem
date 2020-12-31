namespace HelperLibrary
{
    public class Node
    {
        public int Val;
        public Node Next;
        public Node(int val = 0, Node next = null)
        {
            this.Val = val;
            this.Next = next;
        }
    }
}