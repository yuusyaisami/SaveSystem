using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaveSystem;

namespace SaveSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Filec.WriteLine("hello.txt", "へろーーーーーーー🏠", 2);
            Filec.WriteLine("hello.txt", "へろーーーーーーー🚓", 4);
            string str = Filec.ReadLine("hello.txt", 2);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
