using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace stack
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void PushUndCount()
        {
            var stack = new Stack();
            stack.Push(10);
            var result = stack.Count();
            Assert.AreEqual(1, result);
        }

        [Test]
        public void PushUndPop()
        {
            var stack = new Stack();
            stack.Push(20);
            var result = stack.Pop();
            Assert.AreEqual(20, result);
        }

        [Test]
        public void PushTwoEntries()
        {
            var stack = new Stack();
            stack.Push(10);
            stack.Push(15);
            var result = stack.Count();
            Assert.AreEqual(2, result);
        }

        [Test]
        public void PopTwoEntries()
        {
            var stack = new Stack();
            stack.Push(20);
            stack.Push(30);
            Assert.AreEqual(30, stack.Pop());
            Assert.AreEqual(20, stack.Pop());
        }

        [Test]
        public void PopAndCount()
        {
            var stack = new Stack();

            stack.Push(2);
            stack.Push(4);
            stack.Push(8);
            Assert.AreEqual(3, stack.Count());
            Assert.AreEqual(8, stack.Pop());
            Assert.AreEqual(2,stack.Count());
            Assert.AreEqual(4, stack.Pop());    
            Assert.AreEqual(1, stack.Count());
        }

        [Test]
        public void PeekLastEntry()
        {
            var stack = new Stack();
            stack.Push(4);
            stack.Push(5);
            var stapelstelle = stack.Count()-1;
            Assert.AreEqual(5,stack.Peek(stapelstelle));
        }

        [Test]
        public void PeekFirstEntry()
        {
            var stack = new Stack();
            stack.Push(1);
            stack.Push(3);
            stack.Push(5);
            var stapelstelle = stack.Count()-stack.Count();
            Assert.AreEqual(1, stack.Peek(stapelstelle));
        }
    }
}
