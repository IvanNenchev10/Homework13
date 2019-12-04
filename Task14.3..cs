using System;
using System.Collections.Generic;
using System.Collections;
namespace ConsoleApplication134
{
    class Program
    {
        static string[] SplitText(string[] array)
        {
            string text;
            Console.WriteLine("Enter text:");
            text = Console.ReadLine();
            array=text.Split(' ', ',','.');
            return array;
        }
        static void CreateList(List<string> list,string[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                list.Add(array[i]);
            }
        }
        static void PrintList(List<string> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                Console.Write("{0} ", list[i]);
            }
        }
        static void ModifyList(List<string> list)
        {
            string word;
            for(int i=0;i<list.Count;i++)
            {
                word = list[i];
                bool result = true;
                for(int j=i+1;j<list.Count;j++)
                {
                    if(word==list[j])
                    {
                        result = false;
                        list.RemoveAt(j);
                    }
                }
                if(result==true)
                {
                    Console.Write("{0} ", word);
                }
                
            }
            
        }
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string[] array = null;
            array = SplitText(array);
            CreateList(list, array);
            Console.WriteLine("List is:");
            Console.WriteLine();
            PrintList(list);
            Console.WriteLine();
            Console.WriteLine("Words that appear only once in the text:");
            Console.WriteLine();
            ModifyList(list);
          
           
        }
    }
}
