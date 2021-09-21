using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingNUnboxing
{
    class Program
    {
        public void add(object a, object b)
        {
            Console.WriteLine((int)a + (int)b);
        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.add(4, 5);
            Console.ReadLine();
        }
    }
}
