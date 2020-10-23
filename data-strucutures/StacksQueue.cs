namespace Stacks_and_Queues
{
     class Queues
    {
        // attributes of the queue
        private int head;
        private int tail;
        private int size;
        private int[] Q;

        //constructor
        public Queues()
        {
            head = tail = 1;         //Queue is empty
            size = 10;               //Size of the array
            Q = new int[size];       //empty array of size 10
        }



        /*
         * Method name: enQueue(Q, x)
         * parameters: Queue Q and int x
         * return :    void
         * Algorithm:
         *       1.Q[Q.tail] = x
         *       2.If Q.tail == Q.length
         *       3.    Q.tail = 1
         *       4.else Q.tail = Q.tail + 1
         */
        public void enQueue(Queues q, int x)
        {
            q.Q[q.tail] = x;           //insert the new element at the tail
            if (q.tail == q.Q.Length-1)
                q.tail = 1;
            else 
                q.tail++;
        }
        /*
        * Method name: deQueue(Q)
        * parameters: Queue Q 
        * return :    int x
        * Algorithm:
        *       1.x = Q[Q.head]
        *       2.If Q.head == Q.length
        *       3.    Q.head = 1
        *       4.else Q.head = Q.head + 1
        *       5.return x
        */
        public int deQueue(Queues q)
        {
            int x = 0;

            x = q.Q[q.head];
            if (q.head == q.Q.Length-1)
                q.head = 1;
            else
                q.head++;

            return x;
        }

      /*
       * function name: PRINT()
       * parameter: Queue Q
       * return: VOID
       * algorithms
       *      1. i = Q.head;
       *      2. while i != Q.tail
       *      3.     print Q[i]
       *      4.     if i + 1 == Q.Length
       *      5.        i = 1;
       *      6.     else i++;
       *      7. END while
       */
        public void print(Queues q)
        {
            Console.WriteLine("Elements in the Queue from the head to tail order: ");
            int i = q.head;

            while (i != q.tail)
            {
                Console.Write("{0}, ", q.Q[i]);        //print each element in the queue
                if ((i + 1) == q.Q.Length-1)
                    i = 1;
                else
                    i++;
            }
        }
    }

    //--------------------------------------------------------------------------------------------------------------------------------------
    // class implements stack
    public class Stacks
    {
        //field
        private int top;
        private int size;
        private int[] S;

        //constructor
        public Stacks()
        {
            top = 0;
            size = 10;
            S = new int[size];
        }

        /* 
         * function name: STACK-EMPTY(S)
         * paramenter Stack s
         * return type bool
         * algorithm:
         *      1. if S.top == 0
         *      2.    return TRUE
         *      3. else return FALSE
         */       
        public bool stackEmpty(Stacks s)
        {
            if (s.S[s.top] == 0)
                return true;            // return true when empty else false
            else return false;
        }

        /*
         * function name: PUSH
         * parameter int x and Stack s
         * return void
         * algorithms
         *      1. top += 1
         *      2. S[S.top] = x
         */      
        public void push(int x, Stacks s)
        {
            s.top++;          //increment top by one
            s.S[s.top] = x;  //insert the new value at the top
            
        }

        /*
         * function name: POP
         * parameter Stack s
         * return int
         * algorithms
         *      1. if STACK-EMPTY(S) 
         *      2.    erro "underflow"
         *      3. else top -= 1
         *      4.    S[S.top] = x
         */      
        public int pop(Stacks s)
        {
            int item = 0;    //item to be returne

            if (stackEmpty(s))     //when stack is empty s[s.top] = x
                Console.WriteLine("Error underflow");
            else
            {
                s.top--;                //decrement
                item = s.S[s.top + 1];  //the item removed from stack exists in array but was removed from stack
            }

            return item;
        }

        /*
         * function name: PRINT()
         * parameter Stacks s
         * return VOID
         * algorithms
         *      1. for i = 0 to S.top
         *      2.     print S[i]
         *      3. END for
         */      
        public void print(Stacks s)
        {
            Console.WriteLine("Elements in the stack from the top to bottom order: ");

            for (int i = s.top; i > 0; i--)
            {
                Console.Write("{0}, ",s.S[i]);
            }
        }
    }

    //----------------------------------------------------------------------------------------------------------------------------------------
    // class Program implements main method
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            //int input, x = 0;

            Stacks s = new Stacks();    //an instance of stack created
            Queues q = new Queues();    //an instance of queue created

            Console.WriteLine("WELCOME TO STACKS AND QUEUES");

            //push operation
            s.push(1,s);
            s.push(2, s);

            Console.WriteLine("Before the Stacks was poped");
            s.print(s);

            //pop operation
            Console.WriteLine("The element poped from the stack: {0}", s.pop(s));
            Console.WriteLine("The element poped from the stack: {0}", s.pop(s));

            //push operation
            s.push(10, s);
            s.push(24, s);
            s.push(12, s);
            s.push(20, s);

            //print all the elements
            Console.WriteLine("Stack after end of all operations:");
            s.print(s);

            //Queues
            //enqueue operation
            q.enQueue(q, 5);
            q.enQueue(q, 50);
            q.enQueue(q, 70);
            q.enQueue(q, 8);

            //print all the elements
            Console.WriteLine("Before the queue was deQueued");
            q.print(q);

            //deQueue operation
            Console.WriteLine("The element dequeued from Queue: {0}",q.deQueue(q));
            Console.WriteLine("The element dequeued from Queue: {0}", q.deQueue(q));

            //enqueue operation
            q.enQueue(q, 9);
            q.enQueue(q, 7);
            q.enQueue(q, 10);
            q.enQueue(q, 2);
            q.enQueue(q, 3);
            q.enQueue(q, 81);

            //print all the elements
            Console.WriteLine("Queue end of operations:");
            q.print(q);
        }
    }
}