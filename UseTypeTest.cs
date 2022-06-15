using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace test0605
{
    class UseTypeTest
    {
        public UseTypeTest()
        {
            Type t01 = Type.GetType("test0605.TypeTest");//必须先获取类对象的类型，这是第一步
            MemberInfo[] t01mis = t01.GetMembers();
            for (int i = 0; i < t01mis.Length; i++)
            {
                Console.WriteLine(t01mis[i]);
            }
            Console.WriteLine("***********以上获取全部类中的公有成员***************");
            //下面实际上是反射的实例化
            ConstructorInfo construct0 = t01.GetConstructor(new Type[0]);//这里表示获取无参的，即无参构造
            //construct0.Invoke(null); //这是最原始的写法，返回的是object类型
            TypeTest t01_class_instance = construct0.Invoke(null) as TypeTest;
            Console.WriteLine(t01_class_instance.a);
            Console.WriteLine("*****************已经通过反射拿到了typetest类，默认实例化了？**********************");
            Console.WriteLine("应该是的，因为是从无参构造获取的，所以拿到的是typetest类的实例化！");
            //来个多参数的构造
            ConstructorInfo construct2 = t01.GetConstructor(new Type[] { typeof(int), typeof(string) });
            TypeTest t01_class_instance2 = construct2.Invoke(new object[] { 11122, "123" }) as TypeTest;
            Console.WriteLine(t01_class_instance2.a);
            Console.WriteLine("*******************多个参数的构造函数也输入了**********************");
            Console.WriteLine("*****************下面进行公共变量的读写*******************");
            Console.WriteLine("反射其实也卡死了实例化这一点，想要用先进行构造函数进行实例化");
            FieldInfo[] fieldinfos = t01.GetFields();
            foreach (FieldInfo item in fieldinfos)
            {
                Console.WriteLine(item);
            }
            FieldInfo fieldinfo = t01.GetField("a");
            Console.WriteLine(fieldinfo.GetValue(t01_class_instance2));
            fieldinfo.SetValue(t01_class_instance2, 666666);
            Console.WriteLine(fieldinfo.GetValue(t01_class_instance2));
            Console.WriteLine("************接下来进行方法的获取**************");
            Console.WriteLine("************对string进行方法的获取**************");
            Type mystring = typeof(string);
            MethodInfo[] mystringinfos = mystring.GetMethods();
            foreach (MethodInfo item in mystringinfos)
            {
                Console.WriteLine(item);
            }
            MethodInfo mysub = mystring.GetMethod("Substring", new Type[] { typeof(int) });
            string test01string = "我在家里玩DNF，汽配！！！";
            test01string = mysub.Invoke(test01string, new object[] { 3 }) as string;
            Console.WriteLine(test01string);
            Console.WriteLine("*********Type这个方法里还有很多其他的方法**************");
            Console.WriteLine("*************除了直接使用Type实例化外，使用Activator实例化Type类会更加方便快捷*****************");
            Type newTypeTest = typeof(TypeTest);
            TypeTest tt = Activator.CreateInstance(newTypeTest,1212123) as TypeTest;//这里传入的数字过长的话可能被认为是long？从而报错类型不符
            //Activator.CreateInstance(newTypeTest, 8788787878787);
            Console.WriteLine(tt.a);
        }
    }
}
