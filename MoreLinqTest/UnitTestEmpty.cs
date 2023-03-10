using MoreLinq;
using NUnit.Framework;
using System.Linq;

namespace MoreLinqTest
{
    public class UnitTestEmpty
    {
        [Test]
        public void TestEmpty()
        {
            var result1 = Enumerable.Empty<int>();
            var result2 = MoreEnumerable.Empty<int>();
            Assert.AreEqual(result1, result2);
        }
    }
}