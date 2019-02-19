class Node
    {
        public int data;
        public Node next;

        public Node (int d)
        {
            data = d;
            next = null;
        }
    }
    
 
class LinkedList
    {
        Node head;

        public LinkedList()
        {
            head = null;
        }

        public void addFront(int data)
        {
            Node newNode = new Node(data); //step 1
            newNode.next = head;  //step 2
            head = newNode; // step 3
        }
        public void addLast(int data)
        {
            Node newNode = new Node(data); //step 1
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node curr = head;
            while (curr.next != null)
            {
                curr = curr.next;
            }
            curr.next = newNode;
        }
        public void printList()
        {
            Console.Write("List:");
            Node curr = head;
            while (curr != null)
            {
                Console.Write(" {0} ", curr.data);
                curr = curr.next;
            }
            Console.WriteLine();
        }

        public void printReverse()
        {
            Console.Write("Reverse List:");
            printRevHelper(head);
            Console.WriteLine();
        }
        public void printRevHelper(Node c)
        {
            if (c == null) return;   
            printRevHelper(c.next);
            Console.Write(" {0} ", c.data);
        }
                public void addInOrder(int data)
        {
            Node newNode = new Node(data);
            if (head == null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node prev = head, curr = head.next;
                while (curr != null && curr.data < newNode.data)
                {
                    prev = curr;
                    curr = curr.next;
                }
                newNode.next = curr;
                prev.next = newNode;
            }
        }

        public void delete(int key)
        {
            Node curr = head, prev = null;
            if (curr != null && curr.data == key)
            {
                head = curr.next;
                return;
            }
            while (curr != null && curr.data != key)
            {
                prev = curr;
                curr = curr.next;
            }
            if (curr != null)
            {
                prev.next = curr.next;
            }
        }
    public void addInOderAndrew(int data)
        {
            Node newNode = new Node(data);
            if(head!=null || head.data >= newNode.data)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node prev = head, curr = head.next;
                while(curr!=null && curr.data < newNode.data)
                {
                    prev = curr;
                    curr = curr.next;
                }
                newNode.next = curr;
                prev.next = newNode;
            }
        }


public void deleteAndrew(int key)
        {
            Node curr = head, prev = null;
            if(curr!=null && curr.data == key)
            {
                head = curr.next;
                return;
            }
            while (curr != null && curr.data != key)
            {
                prev = curr;
                curr = curr.next;
            }
            if (curr != null)
            {
                prev.next = curr.next;
            }
        }

    }

   
