using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c = new Client();
            c.OrderChicken();
            c.OrderPizza();


            Console.ReadLine();
        }
    }
}
