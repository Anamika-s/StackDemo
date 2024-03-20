namespace QueueDemo
{
    internal class Program
    {
        static int[] Num = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int front = -1, rear=-1;
        static void Main(string[] args)
        {
          
            
                string ch = "y";
                while (ch == "y".ToLower())
                {
                    int choice = Menu();
                    switch (choice)
                    {
                        case 1:
                            {
                                Console.WriteLine("Enter element to insert");
                                int data = byte.Parse(Console.ReadLine());
                                int rear = Enqueue(data);
                                if (rear >= Num.Length - 1)
                                    Console.WriteLine("Overflow");
                                else
                                    Console.WriteLine("Rear points to " + rear);
                                break;
                            }
                        case 2:
                            {
                                int front = Dequeu();
                                if (front == -1 || (front == rear && rear == Num.Length-1))
                                    Console.WriteLine("Underflow");
                                else
                                    Console.WriteLine("front points to " + front);
                                break;
                            }
                        case 3:
                            Display(); break;
                    }

                    Console.WriteLine("Do you want to repeat");
                    ch = Console.ReadLine();

                }

            }

            private static int Menu()
            {
                //System.Int32 // int 
                //    System.String string
                //    System.Byte // byte
                int choice;
                Console.WriteLine(" MENU ");
                Console.WriteLine("1. Insert Element");
                Console.WriteLine("2. Delete Element");
                Console.WriteLine("3. Display Elements of the stack");
                Console.WriteLine("Enter youir choice");
                choice = byte.Parse(Console.ReadLine());
                return choice;
            }

            static int Enqueue(int data)
            {
            if (rear == front && rear == -1)
            {
                front = rear = 0;
                Num[front] = data;
            }
            else
                Num[++rear] = data;
            return rear;
            }


            static int Dequeu()
            {
            --front;
            return front;
            }

            static void Display()
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(Num[i]);
                }
            }
        }
    }
   