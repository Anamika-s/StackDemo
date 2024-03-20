namespace SingleLinkedList
{
    class Node
    {
        public int data;
        public Node next;
    }
    class SingleLinkedList
    {
        Node newNode, start=null, last, ptr, prev;
        public SingleLinkedList()
        {
            //newNode = new Node();
             
            //newNode.next = null;
        }
        

        public void InsertData(int data)
        {
            newNode = new Node();
            newNode.data = data;
            newNode.next = null;
            Console.WriteLine("newNode" + newNode.data);

            if(start!=null)
            Console.WriteLine("Start" + start.data);
            if(last!=null)
            Console.WriteLine("last " + last.data);
            if(start == null)
            {
                start = last = newNode;
                start.next = null;
                Console.WriteLine("STart Node added");
            }
            else if(newNode.data < start.data)
            {
                newNode.next = start;
                start = newNode;
                
                Console.WriteLine("Node added in beg");
            }
            else if(newNode.data >= last.data)
            {
                last.next = newNode;
                last = newNode;
                last.next = null;
                Console.WriteLine("Node added at end");
            }
            else
            {
                for(ptr= prev = start; ptr.next !=null;prev= ptr, ptr = ptr.next) {
                if(newNode.data >= prev.data && newNode.data < ptr.data) {
                        prev.next = newNode;
                        newNode.next = ptr;
                        break;
                    }
                }
            }

        }
        public void DispalyData()
        {
            for(ptr = start; ptr!=null; ptr = ptr.next)
            {
                Console.WriteLine(ptr.data);
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            list.InsertData(10);
            list.InsertData(20);
            list.InsertData(30);
            list.InsertData(1);
            list.InsertData(4);
            list.DispalyData();

        }
    }
}