using System;
using System.Net.Http.Headers;

namespace A
{
    class Test
    {
        public void greetOne()
        {
            System.Console.WriteLine("Hai");
        }
    }
    namespace B
    {
        class Test
        {
            public void greetTwo()
            {
                System.Console.WriteLine("H");
            }
        }
        namespace C
        {
            class Test
            {
                public void greetThree()
                {
                    System.Console.WriteLine("Hope you are good");
                }
            }
            class Demo
            {
                static void Main(String[] argts)
                {
                    A.Test AT = new A.Test();
                    B.Test BT = new B.Test();
                    C.Test CT = new C.Test();

                    AT.greetOne();
                    BT.greetTwo();
                    CT.greetThree();

                }
            }
        }
    }
}
