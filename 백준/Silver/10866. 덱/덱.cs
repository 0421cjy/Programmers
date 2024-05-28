using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

public partial class Program
{
    static void Main(string[] args)
    {
        var sw = new StreamWriter(Console.OpenStandardOutput());
        var sr = new StreamReader(Console.OpenStandardInput());

        var sb = new StringBuilder();

        var deque = new MyDeque();

        var input = Console.ReadLine();
        var count = Int32.Parse(input);

        for (int i = 1; i <= count; i++)
        {
            var input2 = Console.ReadLine().Split();
            switch (input2[0]) 
            {
                case "push_back": deque.PushBack(Int32.Parse(input2[1])); break;
                case "push_front": deque.PushFront(Int32.Parse(input2[1])); break;
                case "pop_front":
                    {
                        sb.AppendLine(deque.PopFront().ToString());
                        break;
                    }
                case "pop_back":
                    {
                        sb.AppendLine(deque.PopBack().ToString());
                        break;
                    }
                case "size":
                    {
                        sb.AppendLine(deque.Size().ToString());
                        break;
                    }
                case "empty":
                    {
                        sb.AppendLine(deque.IsEmpty() ? "1" : "0");
                        break;
                    }
                case "front":
                    {
                        if (deque.IsEmpty())
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine(deque.Front().ToString());
                        }

                        break;
                    }
                case "back":
                    {
                        if (deque.IsEmpty())
                        {
                            sb.AppendLine("-1");
                        }
                        else
                        {
                            sb.AppendLine(deque.Back().ToString());
                        }

                        break;
                    }
                default: new InvalidEnumArgumentException(); break;
            }
        }

        sw.Write(sb.ToString());
        sw.Close();
        sr.Close();
    }

    public class MyDeque
    {
        private List<int> q;

        public MyDeque()
        {
            q = new List<int>();
        }

        public void PushFront(int item)
        {
            var newQueue = new int[q.Count + 1];
            newQueue[0] = item;

            q.CopyTo(newQueue, 1);
            q = newQueue.ToList();
        }

        public void PushBack(int item)
        {
            q.Add(item);
        }

        public int PopFront()
        {
            if (q.Count <= 0)
            {
                return -1;
            }

            var front = q[0];

            var array = new int[q.Count - 1];
            q.CopyTo(1, array, 0, q.Count - 1);

            q = array.ToList();

            return front;
        }

        public int PopBack()
        {
            if (q.Count <= 0)
            {
                return -1;
            }

            var back = q.Last();

            var array = new int[q.Count - 1];
            q.CopyTo(0, array, 0, q.Count - 1);

            q = array.ToList();

            return back;
        }

        public int Size()
        {
            return q.Count;
        }

        public bool IsEmpty() 
        {
            return (q.Count <= 0 ? true : false);
        }

        public int Front()
        {
            return q[0];
        }

        public int Back()
        {
            return q[q.Count - 1];
        }
    }
}