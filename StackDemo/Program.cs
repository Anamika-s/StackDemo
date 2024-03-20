namespace StackDemo
{
    internal class Program
    {
        static int[] Num = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        static int top = -1;
        static void Main(string[] args)
        {
            string ch = "y";
            while (ch == "y".ToLower())
            {
                int choice = Menu();
                switch(choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter element to insert");
                            int data = byte.Parse(Console.ReadLine());
                            int top = Push(data);
                            if (top >= Num.Length - 1)
                                Console.WriteLine("Overflow");
                            else
                                Console.WriteLine("Top points to " + top);
                            break;
                        }
                    case 2:
                        {
                            top = Pop();
                            if (top == -1)
                                Console.WriteLine("Underflow");
                            else
                                Console.WriteLine("Top points to " + top);
                            break;
                        }
                        case 3:
                        Display(); break;
                }
                
                Console.WriteLine("Do you want to repeat");
                ch =  Console.ReadLine();

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

        static int Push(int data)
        {
            if (top > Num.Length - 1)
                return Num.Length - 1;
            else

                Num[++top] = data;
            return top;    
            }


        static int Pop()
        {
           return --top;
        }

        static void Display()
        {
            for(int i = top; i >= 0; i--)
            {
                Console.WriteLine(Num[i]);
            }
        }
    }
}