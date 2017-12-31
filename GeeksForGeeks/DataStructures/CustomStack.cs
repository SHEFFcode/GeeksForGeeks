using System;
namespace GeeksForGeeks.DataStructures
{
    public class CustomStack <T>
    {
        private readonly int MAX = 1000; // Max number of items in a stack
        int top; // will be used for the peak operation
        T[] container; // create a container to server as storage for the stack

        public CustomStack()
        {
            top = -1;
            container = new T[MAX];
        }

        public bool IsEmpty()
        {
            return (top < 0);
        }

        public bool Push(T item)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overfow");
                return false;
            }
            else
            {
                container[++top] = item;
                return true;
            }
        }

        public T Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return default(T);
            }
            else 
            {
                var item = container[top--];
                return item;
            }

        }

        public T Peek()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                return container[top];
            }
        }
    }

    public class CustomStackList <T>
    {

        public class StackNode 
        {
            public T nodeValue;
            public StackNode next;

            public StackNode(T data)
            {
                nodeValue = data;
                next = null;
            }
        }

        StackNode headNode;

        public bool IsEmpty()
        {
            return headNode == null;
        }

        public void Push(T data)
        {
            var nodeToAdd = new StackNode(data);
            nodeToAdd.next = this.headNode; // we add in reverse
            headNode = nodeToAdd; // new node is now at the top of the pringles can
        }

        public T Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack underflow");
                return default(T);
            }
            else
            {
                var data = headNode.nodeValue;
                headNode = headNode.next;
                return data;
            }
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                return default(T);
            }
            else
            {
                return headNode.nodeValue;
            }
        }
    }
}
