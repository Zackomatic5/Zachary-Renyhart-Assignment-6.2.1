namespace Zachary_Renyhart_Assignment_6._2._1
{
    internal class Program
    {
        //1. Write a C# program to implement a stack by using array with push and pop operations.
        static void Main(string[] args)
        {
            Stacky stacky = new Stacky(10);
            stacky.Push(1);
            stacky.Push(2);
            stacky.Push(3);
            stacky.Print();
            int var = stacky.Pop();
            Console.WriteLine($"This var is popped {var}");
            stacky.Print();

        }
        
        
    }
    internal class Stack
    {
        const int max = 1000;
        //This is creating a array holding 100 variables.
        int[] stack = new int[max];
        //The top is the pointer to the top of the stack
        int top;

        //X is a stack of integers
        internal bool Push(int x)
        {//If top or the "pointer" is greater tahn the max then stack overflow
            if (top >= max)
            {
                Console.WriteLine("Stack overflow");
                return false;
            }
            //Incremented index, this makes the increment go up before assigning the data to that position so nothing gets overwritten.
            stack[++top] = x;
            return true;
        }
        internal int Pop(int x)
        {
            //If top is less than 0!
            if (top <0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                //Return the top of the stack and then decrement
                return stack[top--];
            } //Your data always stops where the pointer is set
        }
    }

    internal class Stacky
    {
        int Pointer { get; set; }
        int[] Value { get; set; }
        int Size { get; set; }
        public Stacky(int size)
        {
            Pointer = 0;
            Size = size;
            Value = new int[size];
        }
        public void Push(int newValue)
        {
            if (Pointer == Size)
            {
                Console.WriteLine("Stack is full. Must pop prior to adding more values");
                return;
            }
            Value[Pointer++] = newValue;
            return;
        }
        public int Pop()
        {
            int var = Value[Pointer - 1];
            Pointer--;
            return var;
        }
        public void Print()
        {
            if (Pointer == 0)
            {
                Console.WriteLine("No Values in Array");
                return;
            }
            for (int i = 0; i < Pointer; i++)
            {
                Console.WriteLine(Value[i]);
            }
            return;
        }


    }
}

