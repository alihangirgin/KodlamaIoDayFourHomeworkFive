using System;
using System.Collections;
using System.Collections.Generic;

namespace DayFourHomeworkFive
{
    class Program
    {
        static void Main(string[] args)
        {
            //You can use <int,int>,<int,string>,<string,string>,<string,int>
            MyEditor<int, string> dictionary = new MyEditor<int,string>();
            dictionary.Add(3, "YAPRAK");
            dictionary.Add(1, "AA");
            dictionary.Add(2, "CC");
            dictionary.Add(1, "BB");
            dictionary.Add(2, "DD");
            dictionary.Add(1, "MMMMM");


            foreach (var item in dictionary.Dictionary)
            {
                Console.Write("Key:{" + item.Key + "} -> " );
                var iteration = 1;
                foreach (var value in item.Value)
                {
                    if(iteration <item.Value.Count)
                    {
                        Console.Write("Value:{" + value + "}, ");
                    }
                    else
                    {
                        Console.WriteLine("Value:{" + value + "}");
                    }  
                    iteration++;
                }
                
            }


        }
    }
}
