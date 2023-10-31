using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
     class StringsExercise
    {
        public void m1()
        {
            string name = "VAsanth";
            Console.WriteLine(name[0]);
            Console.WriteLine(name.Substring(3)); //start index ANS : anth
            Console.WriteLine(name.Substring(3, 2));//start index and length ANS: an
            Console.WriteLine(name.ElementAt(2));//index charecter return
            Console.WriteLine("COntains "+name.Contains("as"));//true or false
            char[] ch = { 'm', 'o' };
            // name1=name.CopyTo(1,ch,5,2));
            Console.WriteLine("To lowercase "+name.ToLower());
            Console.WriteLine(name);
            Console.WriteLine("Length "+name.Length);
            Console.WriteLine("Max "+name.Max());
            Console.WriteLine("Min " + name.Min());
            Console.WriteLine("Normalize " + name.Normalize());
            Console.WriteLine("Split " + name.Split('a'));
            Console.WriteLine("Index of char "+name.IndexOf('a'));
            Console.WriteLine("Index of String " + name.IndexOf("nt"));
            Console.WriteLine("Index of Insert " + name.Insert(3,"more"));
            Console.WriteLine("Index of Replace String " + name.Replace("a","A"));






            Console.ReadLine();

        }
    }
}
