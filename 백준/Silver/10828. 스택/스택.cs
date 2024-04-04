using System;
using System.Collections.Generic;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack();
        var sb = new StringBuilder();

        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 0; i < count; i++) 
        {
            var command = Console.ReadLine().Split();
            switch (command[0]) 
            {
                case "push":
                    {
                        var n = Int32.Parse(command[1]);
                        stack.push(n); 
                    }
                    break;
                case "pop":
                    {
                        sb.AppendLine(stack.pop().ToString());
                    }
                    break;
                case "size": sb.AppendLine(stack.size().ToString()); break;
                case "empty": sb.AppendLine(stack.empty().ToString()); break;
                case "top": sb.AppendLine(stack.top().ToString()); break;
            }
        }

        Console.WriteLine(sb.ToString());
    }

    public class Stack
    {
        private List<int> m_stack = new List<int>();
        private int m_index;

        public Stack() 
        {
            m_index = -1;
        }

        public void push(int number)
        {
            m_index++;

            if (m_stack.Count <= m_index)
            {
                m_stack.Add(number);
            }
            else
            {
                m_stack[m_index] = number;
            }
        }

        public int pop()
        {
            return (m_index == -1) ? -1 : m_stack[m_index--];
        }

        public int empty()
        {
            return (m_index == -1) ? 1 : 0;
        }

        public int size()
        {
            return m_index + 1;
        }

        public int top()
        {
            return (m_index == -1) ? -1 : m_stack[m_index];
        }
    }
}