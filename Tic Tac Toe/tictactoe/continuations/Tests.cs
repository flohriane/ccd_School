using System;
using System.Diagnostics;
using NUnit.Framework;

namespace continuations
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            SomeFunction p = x => x - 1;
            ActionInt w = x => Debug.WriteLine(x);
            ActionInt v = x => Debug.WriteLine("hello: {0}", x);

            f2(1, v);
        }

        int f(int x) => x + 1;
        int g(int y) => y * 2;

        void f2(int x, ActionInt onX)
        {
            onX(x + 1);
            onX(x + 2);
            onX(x * 2);
        }
        
        
    }

    delegate int SomeFunction(int skdjföslkdj);

    delegate void ActionInt(int x);
}