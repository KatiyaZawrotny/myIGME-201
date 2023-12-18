using System;

namespace Stack 
{
    //MyStack creates a replica of the Stack<int> data structure
    class MyStack
    {
        //List to represent the items in our stack
        private List<int> items = new List<int>();

        //Adds a new item to the stack at the top
        public void Push(int n)
        {
            items.Add(n);
        }

        //Takes the top item out of the stack and returns it
        public int Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty.");
            }

            int prevIndex = items.Count - 1;
            int popped = items[prevIndex];
            items.RemoveAt(prevIndex);
            return popped;
        }

        //returns the item at the top of the stack without modifying it
        public int Peek()
        {
            if (items.Count == 0)
            {
                throw new Exception("The stack is empty.");
            }

            return items[items.Count - 1];
        }
    }
    
}