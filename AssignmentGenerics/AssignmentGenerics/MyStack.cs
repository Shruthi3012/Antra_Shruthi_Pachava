using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentGenerics
{
    internal class MyStack<T>
    {
        Stack<T> _stack;

        public MyStack()
        {
            _stack = new Stack<T>();
        }
        public int Count()
        {
            return _stack.Count;
        }
        public T Pop()
        {
            return _stack.Pop();
        }
        public void Push(T item)
        {
            _stack.Push(item);
        }
    }
   
}
