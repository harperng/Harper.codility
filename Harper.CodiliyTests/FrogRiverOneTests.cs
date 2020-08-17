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
    public class FrogRiverOneTests
    {
        [TestMethod()]
        public void SolutionTest_01()
        {
            var solution = new FrogRiverOne();
            int[] A = new int[] { 1,3,1,4,2,3,5,4};
            int X=5;
            int expected = 6;
            int actual = solution.Solution(X,A);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void SolutionTest_02()
        {
            var solution = new FrogRiverOne();
            int[] A = new int[] { 1, 3, 1, 4, 2, 3, 5, 4 };
            int X = 5;
            int expected = 6;
            int actual = solution.Solution(X, A);
            Assert.AreEqual(expected, actual);
        }
    }
}