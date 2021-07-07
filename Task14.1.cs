using System;
using System.Collections;
using System.Collections.Generic;
namespace Hello
{
    class Program
    {
        static string[] CreateArray(string[] array)
        {
            string text;
            Console.WriteLine("Enter sentence:");
            text = Console.ReadLine();
            array = text.Split(' ', ',', '.');
            return array;
        }
        static void CreateList(List<string> list,string[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                list.Add(array[i]);
            }
        }
        static Dictionary<string,string> CreateDictionary(Dictionary<string,string> dict)
        {
            dict.Add("My", "Моята");
            dict.Add("car", "кола");
            dict.Add("fast", "бърза");
            return dict;
        }
        static void Modify(List<string> list,Dictionary<string,string> dict)
        {
            foreach(string item in dict.Keys)
            {
                for(int i=0;i<list.Count;i++)
                {
                    if (item ==list[i])
                    {
                        list[i] = dict[item];
                    }
                }
            }
        }
        static void PrintList(List<string> list)
        {
            for(int i=0;i<list.Count;i++)
            {
                Console.Write("{0} ",list[i]);
            }
        }
        static void Main()
        {

            string[] array = null;
            List<string> list = new List<string>();
            Dictionary<string, string> dict = new Dictionary<string, string>();
            array = CreateArray(array);
            CreateList(list, array);
            CreateDictionary(dict);
            Modify(list, dict);
            PrintList(list);
        }
    }
}

