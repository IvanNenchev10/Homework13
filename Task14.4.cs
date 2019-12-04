using System;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApplication135
{
    class Program
    {
        class MyException:Exception
        {
            public MyException(string message) : base(message) { }
        }
        static char[] CreateArray(char[] array)
        {
            string text;
            Console.WriteLine("Enter text:");
            text = Console.ReadLine();
            array = text.ToCharArray();
            return array;
        }
        static void CheckLetters(char[] array,Stack stack)
        {
            for(int i=0;i<array.Length;i++)
            {
                if(array[i]=='{')
                {
                    stack.Push(array[i]);
                }
                if(array[i]=='}')
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch(InvalidOperationException)
                    {
                        Console.WriteLine("You cannot pop element from an empty stack");
                    }
                }
            }
        }
        static int Size(Stack stack)
        {
            return stack.Count;
        }
        static void Main()
        {
            char[] array = null;
            array = CreateArray(array);
            Stack stack = new Stack();
            CheckLetters(array, stack);
            if(Size(stack)==0)
            {
                Console.WriteLine("Number of '{' is equal to number of '}'");
            }
            else
            {
                Console.WriteLine("Number of '{' is not equal to number of '}'");
            }
        }
    }
}
