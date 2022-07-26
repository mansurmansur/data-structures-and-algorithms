using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------
namespace Linkedlist
{ 
    /// <summary>
    /// Class name: Node 
    /// Description: this class creates node used in a singly linked list 
    /// </summary>
    public class Node
    {
        #region Field
        //properties
        public int data { get; set; }
        public Node next { get; set; }
        #endregion

        #region Constructor
        //creates an instance of Node class
        public Node(int data, Node next)
        {
            this.data = data;
            this.next = next;
        }
        #endregion

        #region CompareTo Method
        //compares two node using their data
        public int CompareTo(object obj)
        {
            if (obj != null)
                return 1;

            Node other = (Node)obj;  //casting

            if (other != null)
                return other.data - data;
            else
                return 1;
        }
        #endregion
    }
    //-----------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Class name: Linkedlist
    /// description: this class creates a linkedlist and contains methods that can be used to manipulate the linked list.
    /// </summary>
    public class Linkedlist
    {
        #region Field
        //properties
        private Node front;  //head of the linked list
        #endregion

        #region Constructor
        //creates an empty linkedlist 
        public Linkedlist()
        {
            front = new Node(0,null);
        }
        #endregion

        #region Insert Method
        //insert method
        public void Insert(Node t)
        {
            Node temp = front; 

            //when the list is empty
            if (temp.next == null)
            {
                temp.next = t;
            }
            else //if not empty
            {
                while (temp.next != null)
                    temp = temp.next;

                //insert
                temp.next = t;
            }
        }
        #endregion
        #region Delete Method
        //delete method
        //delete with key data
        public Node Delete(int key)
        {
            Node temp = front; Node prev = new Node(0, null);
            //to delete we need to find the node
            Node t = Search(key);

            while (temp != null && temp.data != t.data)
            {
                prev = temp;
                temp = temp.next;
            }

            if(temp.next != null)
            {
                prev.next = temp.next;
            }
            else
            {
                prev.next = null;
            }

            return t;
        }
        #endregion

        #region Search Method
        //find a node with the data
        public Node Search(int key)
        {
            Node temp = front;         //pointer

            while (temp != null && temp.data != key)
                temp = temp.next;

            return temp;
        }
        #endregion
        #region
        public void print()
        {
            Node temp = front;

            while(temp.next != null)
            {
                temp = temp.next;
                Console.WriteLine("{0}", temp.data);
            }
        }
        #endregion
    }
 //---------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Class name: Program
    /// Description: This class contains the main method.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to linked list data structures.");

            //5 nodes for testing
            Node a = new Node(2, null);
            Node b = new Node(1, null);
            Node c = new Node(5, null);
            Node d = new Node(4, null);
            Node e = new Node(7, null);

            //an instance of linkedlist
            Linkedlist list = new Linkedlist();

            //inserts the 5 nodes
            list.Insert(a);
            list.Insert(b);
            list.Insert(c);
            list.Insert(d);
            list.Insert(e);

            //search
            list.Delete(4);

            //print
            list.print();
        }
    }
}
