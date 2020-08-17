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
    public class OddOccurrencesInArrayTests
    {
        [TestMethod()]
        public void SolutionTest_01()
        {
            var solution = new OddOccurrencesInArray();
            int[] A = new int[] { 9, 3, 9, 3, 9, 7, 9 };
            int[] expected = new int[] {7};
            int actual = solution.Solution(A);
            Assert.AreEqual(expected, actual);
        }
    }
}