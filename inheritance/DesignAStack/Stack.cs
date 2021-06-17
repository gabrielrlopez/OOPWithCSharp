using System;
using System.Collections.Generic;

namespace OOP_With_CSharp
{
    public class Stack
    {
        private List<object> StackList { get; set; }

        public Stack()
        {
            StackList = new List<object>();
        }
        public void Push(object obj)
        {
            object convert = obj;
            StackList.Add(convert);
            System.Console.WriteLine("The object was successfully placed on top of the stack.");
        }

        public object Pop()
        {
            if (StackList.Count > 0)
            {
                var lastIndex = StackList.Count;
                var lastItem = StackList[lastIndex - 1];
                StackList.Remove(lastItem);
                return lastItem;
            }
            else
            {
                System.Console.WriteLine("There are no items in the stack to remove.");
                return null;
            }
        }

        public void Clear()
        {
            StackList.Clear();
            System.Console.WriteLine("The stack was successfully cleared.");
        }
    }
}