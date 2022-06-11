using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class BagSthing
    {
        public int kind
        {
            set;
            get;
        }
        public int quality
        {
            set;
            get;
        }
        public string name
        {
            set;
            get;
        }
        public BagSthing(int kind,int quality,string name)
        {
            this.kind = kind;
            this.quality = quality;
            this.name = name;
        }
    }
}
