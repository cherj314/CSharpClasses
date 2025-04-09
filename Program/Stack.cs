using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Program
{
    public class Stack
    {
        public List<object> list;
        public Stack()
        {
            this.list = new List<object>();
        }
        public void Push(object obj)
        {
            if (obj != null) {
                list.Add(obj);
            }
            else
                throw new InvalidOperationException("Exception thrown.");
        }
        public object Pop()
        {
            if (list.Count > 0)
            {
                object obj = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return obj;
            }
            else
                return null;
        }
        public void Clear()
        {

        }
    }
}
