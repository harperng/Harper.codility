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
    public class CyclicRotationTests
    {
        [TestMethod()]
        public void SolutionTest_01()
        {
            var solution = new CyclicRotation();
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] expected = new int[] { 6, 3, 8, 9, 7 };
            int[] actual = solution.Solution(A,K);

        }
        [TestMethod()]
        public void SolutionTest_02()
        {
            var solution = new CyclicRotation();
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] expected = new int[] {7, 6, 3, 8, 9 };
            int[] actual = solution.Solution(A, K);

        }
        [TestMethod()]
        public void SolutionTest_03()
        {
            var solution = new CyclicRotation();
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] expected = new int[] { 9, 7, 6, 3, 8 };
            int[] actual = solution.Solution(A, K);

        }
        public void SolutionTest_04()
        {
            var solution = new CyclicRotation();
            int[] A = new int[] { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] expected = new int[] { 9, 7, 6, 3, 8 };
            int[] actual = solution.Solution(A, K);

        }
    }
}