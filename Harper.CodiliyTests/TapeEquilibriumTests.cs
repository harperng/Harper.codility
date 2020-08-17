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
    public class TapeEquilibriumTests
    {
        [TestMethod()]
        public void SolutionTest()
        {
            var solution = new TapeEquilibrium();
            int[] A = new int[] { 3,1,2,4,3};
            int expected = 1;
            int actual = solution.Solution(A);
            Assert.AreEqual(expected, actual);
        }
    }
}