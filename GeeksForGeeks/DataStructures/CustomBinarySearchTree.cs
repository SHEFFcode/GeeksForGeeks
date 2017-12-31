using System;
using System.Collections.Generic;

namespace GeeksForGeeks.DataStructures
{
    public class CustomBinarySearchTree
    {
        class Node
        {
            public int storedValue;
            public Node leftChild;
            public Node rightChild;
            public Node(int value)
            {
                storedValue = value;
            }
        }

        Node root;
        int size;

        public void Insert(int value)
        {
            if (root == null)
            {
                root = new Node(value);
                size++;
            }
            else
            {
                FindAndInsert(root, value);
            }
        }

        private void FindAndInsert(Node currentNode, int value)
        {
            if (value > currentNode.storedValue)
            {
                if (currentNode.rightChild == null)
                {
                    currentNode.rightChild = new Node(value);
                    size++;
                }
                else
                {
                    FindAndInsert(currentNode.rightChild, value);
                }
            }
            else
            {
                if (value < currentNode.storedValue)
                {
                    if (currentNode.leftChild == null)
                    {
                        currentNode.leftChild = new Node(value);
                        size++;
                    }
                    else
                    {
                        FindAndInsert(currentNode.leftChild, value);
                    }
                }
            }
        }

        public bool Search(int target)
        {
            return Traverse(root, target);
        }

        private bool Traverse(Node currentNode, int target)
        {
            if (currentNode == null)
            {
                return false;
            }
            else if (currentNode.storedValue == target)
            {
                return true;
            }

            if (target > currentNode.storedValue)
            {
                Traverse(currentNode.rightChild, target);
            }
            else
            {
                Traverse(currentNode.leftChild, target);
            }
            return false;
        }

        public void Delete(int deleteValue)
        {
            var temp = new List<int>();
            RoundUp(root, temp, deleteValue);

            if (temp.Count == size)
            {
                Console.WriteLine($"Item {deleteValue} does not exist in this tree");
            }
            else
            {
                root = null;
                size = 0;
                int toInsert;
                for (int i = 0; i < temp.Count; i++)
                {
                    toInsert = temp[i];
                    Insert(toInsert);
                }
                Console.WriteLine($"Item {deleteValue} has been deleted.");
            }
            Console.WriteLine(root);
            Console.WriteLine(size);
        }

        private void RoundUp(Node currentNode, List<int> temp, int deleteValue)
        {
            if (currentNode == null)
            {
                return;
            }
            else if (currentNode.storedValue != deleteValue)
            {
                temp.Add(currentNode.storedValue);
            }
            RoundUp(currentNode.leftChild, temp, deleteValue);
            RoundUp(currentNode.rightChild, temp, deleteValue);
        }
    }
}
