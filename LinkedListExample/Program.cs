using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListExample
{
    class Program
    {   
        static void Main(string[] args)
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            for (int i = 0; i < 5; i++ )
            {
                linkedList.AddNode((i + 1).ToString());
            }

            linkedList.PrintLinkedListItems();
        }
    }
}
 