using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSampleCode
{
    class B : A
    {
        public B()
        {
            Console.WriteLine("B");
        }

        public new void Fun()
        {
            Console.WriteLine("B.Fun()");

        }



        private static void ObjectTO()
        {
            int i = 2000;
            object o = i;
            i = 2001;
            int j = (int)o;
            Console.WriteLine("i={0},o={1},j={2}", i, o, j);
        }

        static void Main(string[] args)
        {
            A a = new B();
            a.Fun();

            ObjectTO();

            Console.WriteLine("C.X is {0}", C.X.ToString());
            Console.WriteLine("D.Y is {0}", D.Y.ToString());

            Console.Read();

        }

    }
    public abstract class A
    {
        public A()

        {
            Console.WriteLine("A");
        }
        public virtual void Fun()
        {
            Console.WriteLine("A.Fun()");
        }
    }

    public class C
    {
        public static int X = D.Y;
        static C()
        {
            ++X;
        }
    }

    public class D
    {
        public static int Y = C.X;
        static D()
        {
            ++Y;
        }
    }
}
