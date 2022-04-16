using System;
using System.Collections;
using System.Collections.Generic;

namespace CreatingStackException
{
    public class ExampleStackException : Exception
    {
        public ExampleStackException() : base() { }
        public ExampleStackException(string message) : base(message) { }
        public ExampleStackException(string message, Exception innerException) : base(message, innerException) { }

    }
}

namespace CreatingMyStack
{
    interface ICloneable
    {
        void Push();
        void Pop();
    }
    public class MyStack : ICloneable
    {
        private List<int> stack = new List<int>();
        private int _top;
        public int Top { get { return _top; } set { this._top = value; } }
        private int _stackSize;
        public int StackSize { get { return _stackSize; } set { this._stackSize = value; } }

        public void Push()
        {
            try
            {
                if (stack.Count == _stackSize)
                {
                    throw new CreatingStackException.ExampleStackException("Stack size is equal to the total numbers of elememnts, so push is not possible.");
                }
                stack.Add(this._top);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        public void Pop()
        {
            try
            {
                if (stack.Count == 0)
                {
                    throw new CreatingStackException.ExampleStackException("Stack size is (-1),so pop is not possible.");
                }
                stack.RemoveAt(stack.Count - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        public void DisplayStack()
        {
            foreach (int i in stack)
            {
                Console.WriteLine("Printing the stack");
                Console.WriteLine(i);
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            MyStack stack = new MyStack();
            stack.StackSize = 3;
            stack.Top = 10;
            stack.Push();
            stack.Top = 20;
            stack.Push();
            stack.DisplayStack();
            stack.Pop();
            stack.DisplayStack();
            stack.Pop();
            stack.Pop();
        }
    }
}
