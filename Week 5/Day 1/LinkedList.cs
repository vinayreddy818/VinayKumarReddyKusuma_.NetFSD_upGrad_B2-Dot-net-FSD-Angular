using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleWeek5Day1
{
    internal class LinkedList
    {
        Node head;

        // Insert at end
        public void Insert(int id, string name)
        {
            Node newNode = new Node(id, name);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }

        // Delete by ID
        public void Delete(int id)
        {
            if (head == null) return;

            if (head.Id == id)
            {
                head = head.Next;
                return;
            }

            Node temp = head;
            while (temp.Next != null && temp.Next.Id != id)
            {
                temp = temp.Next;
            }

            if (temp.Next != null)
            {
                temp.Next = temp.Next.Next;
            }
        }

        // Display list
        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Id + " - " + temp.Name);
                temp = temp.Next;
            }
        }
    }

    internal class Node
    {
        public int Id;
        public string Name;
        public Node Next;

        public Node(int id, string name)
        {
            Id = id;
            Name = name;
            Next = null;
        }
    }

    internal class MainClass
    {
       public static void Main()
        {
            LinkedList list = new LinkedList();

            list.Insert(101, "John");
            list.Insert(102, "Sara");
            list.Insert(103, "Mike");

            list.Delete(102);

            Console.WriteLine("Employee List After Deletion:");
            list.Display();
        }
    }

}
