using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using wrapper;

namespace wrapper_test
{
    [TestFixture]
    public class Testings
    {
        [Test]
        public void Wrap_words_fitting_in_line()
        {
            var sut = new Wrapper();
            //Mock.NonPublic.Arrange<string[]>(sut, "Split_into_words", "zeile1 zeile2")
            //              .Returns(new[] { "zeile1", "zeile2" }).MustBeCalled();
            //Mock.NonPublic.Arrange<string>(sut, "Create_lines_from_words", new[] { "zeile1", "zeile2" }, 6)
            //              .Returns("zeile1\nzeile2").MustBeCalles();    

            var result = sut.Wrap("zeile1 zeile2", 6);

            Assert.AreEqual("zeile1\nzeile2", result);
            //Mock.Assert(sut);
        }
    }
}
