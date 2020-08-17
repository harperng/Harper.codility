using Microsoft.VisualStudio.TestTools.UnitTesting;
using Harper.Codiliy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace Harper.Codiliy.Tests
{
    [TestClass()]
    public class FrogJmpTests
    {
        [TestMethod()]
        public void solutionTest_01()
        {
            var solution = new FrogJmp();

            int X = 10;
            int Y = 85;
            int D = 30;

            int expected = 3;
            int actual = solution.Solution( X, Y, D);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void solutionTest_02()
        {
            var solution = new FrogJmp();

            int X = 20;
            int Y = 95;
            int D = 20;

            int expected = 4;
            int actual = solution.Solution(X, Y, D);

            Assert.AreEqual(expected, actual);
        }
    }
}