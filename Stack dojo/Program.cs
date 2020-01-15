using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack_dojo
{
    class Program
    {
        static void Main(string[] args)
        {            
            int capacity = 20;
            Stack<string> stack = new Stack<string>(capacity);

            Console.WriteLine("Enter String to Push :");

            stack.push("Adam");
            stack.push("Eva");
            stack.push("Mendez");
           
            string[] Elements = stack.GetAllStackElements();

            Console.WriteLine("Stack Content:");

            foreach (string str in Elements)
            {
                Console.WriteLine(str);
            }

            stack.Pop();
            string[] Elements1 = stack.GetAllStackElements();

            foreach (string str in Elements1)
            {
                Console.WriteLine(str);
            }


            stack.Peep(1);

            Console.WriteLine("\n Stack position in 1 is: " + stack.Peep(1));

            Console.WriteLine(stack.Count);

        }


        class Stack<T> 
        {

            int capacity = 30;
            T[] stack;
            int top;

           public Stack(int maxElements)
            {
                capacity = maxElements;
                stack = new T[capacity];
            }

            public int push(T Element)
            {
                try
                {
                        top = top + 1;
                        stack[top] = Element;
                    
                }
                catch
                {

                    throw new Exception("Stack is full");

                }
                return 0;

            }
            public T[] GetAllStackElements()
            {
                T[] Elements = new T[top + 1];
                Array.Copy(stack, 0, Elements, 0, top + 1);
                return Elements;
            }

            public T Pop()
            {
                T RemovedElement;
                T temp = default(T);

                if (!(top <= 0))
                {
                    RemovedElement = stack[top];
                    top = top - 1;
                    return RemovedElement;
                }
                return temp;
            }

            public T Peep(int positon)
            {
                T temp = default(T);
                if(positon < capacity && positon >= 0)
                {
                    return stack[positon];
                }
                return temp;
            }

            public int Count { get { return stack.Length; } }

         

        }


    }
}
