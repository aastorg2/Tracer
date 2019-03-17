using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Benchmarks
{
    public class StackA
    {
        internal int size;
        internal Stack<int> s;

        public StackA(int size)
        {
            size = 0;
            s = new Stack<int>(size);
        }

        public void push(int a)
        {
            s.Push(a);
            size += 1;
        }

        public int peekA()
        {
            return s.Peek();
        }

        public override string ToString()
        {
            return $"Size is: {size} + Stack is: {s.ToArray()}";
        }
    }
}
