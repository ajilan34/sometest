using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class List_test
    {
        List<int> mylist = new List<int>();
        
        public List_test()
        {
            mylist.Add(7);
            mylist.Add(8);
            mylist.Add(4);
            mylist.Add(9);
            mylist.Add(14);
            mylist.Add(6);
            mylist.Add(4);
            mylist.Add(0);
            mylist.Add(2);
            mylist.Add(1);
            mylist.Add(44);
            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i]);
            }
            mylist.Sort();
            foreach (int num in mylist)
            {
                Console.WriteLine(num);
            }
        }
    }
}
