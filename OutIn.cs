using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class Father
    {

    }
    class Son : Father
    {

    }
    delegate T OutTest<out T>();
    delegate void InTest<in T>();
    class OutIn
    {
        OutTest<Father> Of = () =>
        {
            return new Father();
        };
        OutTest<Son> Os = () =>
        {
            return new Son();
        };
        InTest<Father> If = ()=>{};
        InTest<Son> Is = () => { };
        public OutIn()
        {
            OutTest<Son> test = Os;
            OutTest<Father> test2 = Os;

            InTest<Son> test3 = If;
        }
        
    }
}
