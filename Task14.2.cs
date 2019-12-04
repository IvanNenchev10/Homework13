using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApplication133
{
    class Program
    {
        static void FillList(List<string> list)
        {
            string word;
            int counter = 0;
            while(counter<20)
            {
                Console.WriteLine("Enter word {0}:",counter+1);
                word = Console.ReadLine();
                list.Add(word);
                counter++;
            }
        }
        static void PrintList(List<string> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                Console.Write("{0}, ", list[i]);
            }
        }
        static void ModifyList(List<string> list)
        {
            string word;
            for(int i=0;i<list.Count;i++)
            {
                int counter = 1;
                word = list[i];
                for(int j=i+1;j<list.Count;j++)
                {
                    if(word==list[j])
                    {
                        list.RemoveAt(j);
                        counter++;
                    }
                }
                Console.WriteLine("Word {0} appears {1} times in the list",word,counter);
            }
        }
        static void Main()
        {
            List<string> list = new List<string>();
            FillList(list);
            PrintList(list);
            Console.WriteLine();
            ModifyList(list);
        }
    }
}
