using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace stack
{
    [TestFixture]
    class Stack_Tests
    {
        [Test]
        public void PushUndCount()
        {
            var stack = new Stack();
            stack.push(10);
            var result = stack.count();
            Assert.AreEqual(1, result);
        }
        [Test]
        public void PushUndPop()
        {
            var stack = new Stack();
            stack.push(20);
            var result = stack.pop();
            Assert.AreEqual(20,result);
        }

        [Test]
        public void PushTwoEntries()
        {
            var stack = new Stack();
            stack.push(10);
            stack.push(15);
            var result = stack.count();
            Assert.AreEqual(2,result);
        }
        [Test]
        public void PopTwoEntries()
        {
            var stack = new Stack();
            stack.push(20);
            stack.push(30);
            Assert.AreEqual(30, stack.pop());
            Assert.AreEqual(20, stack.pop());
        }
    }
}
