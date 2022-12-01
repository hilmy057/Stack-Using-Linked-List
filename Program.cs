using System;

namespace Stack_Using_Linked_List
{
    class Node
    {
        public int info;
        public Node next;
        public Node(int i, Node n)
        {
            info = i ;
            next = n ;
        }
    }

    class Stacks
    {
        Node top; 

        public Stacks()
        {
            top = null; 
        }
        bool empty ()
        {
            if (top == null)
                return (true);
            else
                return (false); 
        }
        public void push (int element )
        { }
    }
}
    
