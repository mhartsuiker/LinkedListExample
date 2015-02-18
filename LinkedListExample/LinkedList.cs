using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    public class LinkedList<T>
    {
        private class Node
        {
            public Node next;
            public T data;
        }

        private Node head = null;

        public void AddNode(T data)
        {
            Node newNode = new Node();
            newNode.next = head;
            newNode.data = data;
            head = newNode; 
        }

        public void PrintLinkedListItems()
        {
            Node currentNode = head;

            while (currentNode != null)
            {
                Console.WriteLine(currentNode.data);
                currentNode = currentNode.next;
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        } 
    }
}
