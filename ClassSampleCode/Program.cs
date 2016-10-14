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


        /// <summary>
        /// Box unbox sample
        /// </summary>
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
            // "new" func on dervied class not called with like override
            A a = new B();
            a.Fun();

            // box unbox sample
            ObjectTO();

            // static member init sample
            Console.WriteLine("C.X is {0}", C.X.ToString());
            Console.WriteLine("D.Y is {0}", D.Y.ToString());

            // struct vs class
            //var stru = new StruSample();
            StruSample stru;
            stru.a = 2;
            var cla = new claSample();
            Console.WriteLine("Struct member a is {0}", stru.a);
            Console.WriteLine("Class member a is {0}", cla.a);

            TestDeleg.RunNormal();
            TestDeleg.RunMultiBind();

            TestEnvent.RunNormal();

            TestGen.RunSample();

            TestGenCol.RunSample();


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

    /// <summary>
    /// Static member variable init sample
    /// </summary>
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

    class claSample
    {
        public int a;

    }
    struct StruSample
    {
        public int a;
    }

    /// <summary>
    /// Compile error
    /// </summary>
    //struct StruSample1: StruSample
    //{
    //    public int a;
    //}

    interface iTestDefine
    {
        //public event A;
        void TestMethod();

    }



    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);
    class TestDeleg
    {
        public delegate void GreetingDelegate(string name);

        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
        //注意此方法，它接受一个GreetingDelegate类型的参数，该参数是返回值为空，参数为string类型的方法
        private static void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }

        public static void RunNormal()
        {
            GreetPeople("Jimmy Zhang", EnglishGreeting);
            GreetPeople("张子阳", ChineseGreeting);
        }

        public static void RunMultiBind()
        {
            GreetingDelegate delegate1;
            delegate1 = EnglishGreeting; // 先给委托类型的变量赋值
            delegate1 += ChineseGreeting; // 给此委托变量再绑定一个方法
                                          // 将先后调用 EnglishGreeting 与 ChineseGreeting 方法
            GreetPeople("Jimmy Zhang", delegate1);
        }
    }

    class TestEnvent
    {
        public delegate void GreetingDelegate(string name);

        class GreetingManager
        {
            //这一次我们在这里声明一个事件
            public event GreetingDelegate MakeGreet;
            public void GreetPeople(string name)
            {
                MakeGreet(name);
            }
        }
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("Morning, " + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好, " + name);
        }
        public static void RunNormal()
        {
            GreetingManager gm = new GreetingManager();
            //gm.MakeGreet = EnglishGreeting; // 编译错误1
            gm.MakeGreet += EnglishGreeting; // 编译通过
            gm.MakeGreet += ChineseGreeting;
            gm.GreetPeople("Jimmy Zhang");
        }
    }

    //泛型用例
    class TestGen
    {
        class MyHelper<T>
        {
            public static void AddAndPrint(T t1, T t2)
            {
                Console.WriteLine(string.Format("The value is {0}", t1.ToString() + "@" + t2.ToString()));
            }
        }

        public static void RunSample()
        {
            MyHelper<int>.AddAndPrint(100, 120);
            MyHelper<float>.AddAndPrint(100.123F, 120F);
            MyHelper<double>.AddAndPrint(100.456D, 120.666D);
            
        }

    }


    class TestGenCol
    {

        class MyNode<T>
        {
            public MyNode(T t)
            {
                this.Data = t;
            }
            public T Data { get; set; }
            public MyNode<T> Next { get; set; }
            public override string ToString()
            {
                return Data.ToString();
            }
        }

        class MyList<T>
        {
            public MyNode<T> Head { get; set; }
            public MyList(T t)
            {
                Head = new MyNode<T>(t);
            }
            public void Append(T t)
            {
                MyNode<T> temp = this.Head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                MyNode<T> newNode = new MyNode<T>(t);
                temp.Next = newNode;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                MyNode<T> temp = this.Head;
                int index = 0;
                do
                {
                    sb.Append(string.Format("The {0} Element is {1}\n", index, temp.Data.ToString()));
                    index++;
                    temp = temp.Next;
                }
                while (temp != null);
                return sb.ToString();
            }
        }

        public static void RunSample() {
            MyList<string> myList = new MyList<string>("first");
            myList.Append("second");
            MyList<int> mylist2 = new MyList<int>(12);
            mylist2.Append(1231);
            Console.WriteLine(mylist2.ToString());
        }
    }

}
