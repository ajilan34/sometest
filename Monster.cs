using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class Monster
    {
        public int health
        {
            set;
            get;
        }
        public int atk
        {
            set;
            get;
        }
        public int def
        {
            set;
            get;
        }
        public Monster(int health,int atk,int def)
        {
            this.health = health;
            this.atk = atk;
            this.def = def;
        }
    }
}
