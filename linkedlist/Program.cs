using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.insert(12);
            list.insert(24);
            list.insert(36);
            list.insert(48);
            list.insert(60);
            list.insert(72);
            //list.pop();
            //list.remove(36);
            list.removeIndex(2);
            list.display();
            Console.WriteLine("List size is : {0}",list.Size);

            Console.ReadKey();

        }
    }
}
