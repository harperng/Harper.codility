using Microsoft.VisualStudio.TestTools.UnitTesting;
using Harper.Codiliy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harper.Codiliy.Tests
{
    [TestClass()]
    public class PermMissingElemTests
    {
        [TestMethod()]
        public void solutionTest_01()
        {
            var solution = new PermMissingElem();
            int[] A = new int[] { 2,3,1,5 };
            int expected = 4;
            int actual = solution.Solution(A);
            Assert.AreEqual(expected, actual);
        }
    }
}