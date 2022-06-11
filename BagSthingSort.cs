using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class BagSthingSort
    {
        public BagSthingSort(List<BagSthing> bagsthing)
        {
            Console.WriteLine("默认背包排序，类型-品质-姓名长度");
            bagsthing.Sort((BagSthing a, BagSthing b) =>
            {
                if (a.kind < b.kind)
                {
                    return -1;
                }
                else if (a.kind > b.kind)
                {
                    return 1;
                }
                else
                {
                    if (a.quality < b.quality)
                    {
                        return -1;
                    }
                    else if (a.quality > b.quality)
                    {
                        return 1;
                    }
                    else
                    {
                        if (a.name.Length < b.name.Length)
                        {
                            return -1;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            });
            foreach (BagSthing item in bagsthing)
            {
                Console.WriteLine("类型{0}，品质{1}，姓名{2}", item.kind, item.quality, item.name);
            }
        }
    }
}
