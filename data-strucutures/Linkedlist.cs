using System;

namespace Linkedlist
{ 
    /// <summary>
    /// Class name: Node 
    /// Description: this class creates node used in a singly linked list 
    /// </summary>
    public class Node
    {
        #region Field
        private int data { get; set; }
        private Node next { get; set; }
        #endregion

        #region Constructor
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
        #endregion
    }
    /// <summary>
    /// Class name: Linkedlist
    /// description: this class creates a linkedlist and contains methods that can be used to manipulate the linked list.
    /// </summary>
    public class Linkedlist
    {
        private Node front;

        #region Constructor
        public Linkedlist()
        {
            front = new Node(0, null);      //created an empty linked list
        }
        #endregion


        #region insert method
        public void insert(Node t)
        {
            Node temp = front;

           
        }
        #endregion
    }

    /// <summary>
    /// Class name: Program
    /// Description: This class contains the main method.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to linked list data structures.");
        }
    }
}
