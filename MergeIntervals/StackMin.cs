using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeIntervals
{
    public class StackMin
    {
        struct MinStackElement
        {
            public int data;
            public int min;
        }

        int top = 0;
        List<MinStackElement> _stackMin = new List<MinStackElement>();

        public void Push(int data)
        {
            if (top == 0)
            {
                _stackMin.Add(new MinStackElement() { data = data, min = data });
            }
            else
            {
                var stackElement = new MinStackElement() { data = data, min = _stackMin[top - 1].min };
                if (stackElement.min > data)
                    stackElement.min = data;
                _stackMin.Add(stackElement);
            }
            top++;
        }
        public int Pop()
        {
            int data = _stackMin[top - 1].data;
            _stackMin.RemoveAt(top - 1);
            top--;
            return data;
        }
        public int GetMin()
        {
            if (top == 0)
                throw new Exception("Stack is empty.");
            var min = _stackMin[top - 1].min;
            return min;
        }
    }
}
