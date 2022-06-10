using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class MyMoney:IComparable<MyMoney>
    {
        public int money
        {
            get;
        }

        public MyMoney(int money)
        {
            this.money = money;
        }

        public int CompareTo(MyMoney other)
        {
            if (this.money < other.money)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        
    }
}
