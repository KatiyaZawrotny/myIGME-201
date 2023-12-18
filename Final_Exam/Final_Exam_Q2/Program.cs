using System;


namespace Final_Exam_Q2
{
    //MyQueue replicates the Queue<int> data structure
    class MyQueue
    {
        //List to represent items in our queue
        private List<int> items = new List<int>();

        //Adds an item to the back of the queue
        public void Enqueue(int n)
        {
            items.Add(n);
        }
        
        //Removes the item at the front of the queue and returns it
        public int Dequeue()
        {
            if (items.Count == 0)
            {
                throw new Exception("The queue is empty.");
            }

            int dequeuedItem = items[0];
            items.RemoveAt(0);
            return dequeuedItem;
        }

        //Returns the item at the front of the queue
        public int Peek()
        {
            if (items.Count == 0)
            {
                throw new Exception("The queue is empty.");
            }

            return items[0];
        }
    }
}