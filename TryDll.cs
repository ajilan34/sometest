using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class TryDll
    {
        public TryDll()
        {
            Assembly assembly = Assembly.Load("ClassLibrary001");
            Type[] assembly_types = assembly.GetTypes();
            foreach (Type item in assembly_types)
            {
                Console.WriteLine(item);
            }
            Type assembly_c1 = assembly.GetType("ClassLibrary001.Class1");
            ConstructorInfo assembly_c1_construct0 = assembly_c1.GetConstructor(new Type[]{ });
            object c1 = assembly_c1_construct0.Invoke(null);
            MemberInfo[] assembly_c1_memberinfos = assembly_c1.GetMembers();
            foreach (MemberInfo item in assembly_c1_memberinfos)
            {
                Console.WriteLine(item);
            }

            MethodInfo assembly_c1_class1 = assembly_c1.GetMethod("spk1");
            assembly_c1_class1.Invoke(c1,null);
        }
    }
}
