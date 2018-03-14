using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = new string[8] { "a","b","C","d","a","f","gh","h"};
            List<CString> strList = new List<CString>();
            foreach (string s in strArray)
            {
                strList.Add(new CString(s));
            }
            Console.WriteLine("oringal List");
            strList.ForEach(c => Console.Write(c+","));
            Console.WriteLine();
            
            strList.Sort();
            Console.WriteLine("sorted list");
            strList.ForEach(c => Console.Write(c + ","));
            Console.WriteLine();

            strList.Sort(CString.CompDesc);
            Console.WriteLine("sorted with Comparasion Delegtae Impelmetation");
            strList.ForEach(c => Console.Write(c + ","));
            Console.WriteLine();
           

            strList.Reverse();
            Console.WriteLine("Revesred:");
            strList.ForEach(c => Console.Write(c + ","));
            Console.WriteLine();

            



















            Console.ReadLine();




        }
    }
}
