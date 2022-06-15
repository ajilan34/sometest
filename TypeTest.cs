using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class TypeTest
    {
        public int a = 0;
        public int b = 1;
        private int c = 3;
        public TypeTest()
        {

        }
        public TypeTest(int x)
        {
            this.a = x;
        }
        public TypeTest(int x,string y):this(x)
        {
            Console.WriteLine("输入了一个{0}", y);
        }
        public void fun001()
        {
            Console.WriteLine("方法001");
        }
        public void fun002()
        {
            Console.WriteLine("方法002");
        }
    }
}
