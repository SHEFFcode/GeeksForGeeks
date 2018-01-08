using System;
namespace GeeksForGeeks.DataStructures
{
    public class CustomLinkedList
    {
        Node headNode; // head node of the linked list
        Node tailNode;

        class Node
        {
            public int? data; // the value of this node
            public Node next; // the pointer to the next node

            public Node(int? passedInData)
            {
                if (passedInData != null) {
                    data = (int)passedInData; // set the data on creation
                }
            }
        }

        public CustomLinkedList()
        {
            if (headNode == null)
            {
                headNode = new Node(null);
                tailNode = headNode;
            }
        }

        public void AddNode(int data) {
            if (headNode.data == null)
            {
                headNode.data = data;
            } 
            else 
            {
                var nodeToInsert = new Node(data);
                tailNode.next = nodeToInsert;
                tailNode = nodeToInsert;
            }
        }

        public void TraverseLinkedList()
        {
            var currentNode = headNode;
            do
            {
                if (currentNode.data == null)
                {
                    break;
                } 
                else 
                {
                    Console.WriteLine(currentNode.data);
                    currentNode = currentNode.next;
                }
            } while (currentNode != null);
        }
    }
}
