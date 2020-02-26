using System;
using Xunit;

namespace SumofBiggestNeighbor.Tests
{
    public class SolverTests
    {
        [Fact]
        public void InputSet1_ShouldReturn10()
        {
            var solver = new Solver();
            var input = new[] { 1, 2, 1, 5, 5, 3, 3, 3, 4 };

            var result = solver.Challenge(input);

            Assert.Equal(10, result);
        }

        [Fact]
        public void InputSet2_ShouldReturn12()
        {
            var solver = new Solver();
            var input = new[] { 1, 6, 1, 2, 6, 1, 6, 6 };

            var result = solver.Challenge(input);

            Assert.Equal(12, result);
        }

        [Fact]
        public void InputSet3_ShouldReturn2()
        {
            var solver = new Solver();
            var input = new[] { 1, 6, 1, 2, 6, 1, 6, 6, 1, 1, 1, 1 };

            var result = solver.Challenge(input);

            Assert.Equal(2, result);
        }

        [Fact]
        public void InputSet4_ShouldReturn12()
        {
            var solver = new Solver();
            var input = new[] { 6, 6 };

            var result = solver.Challenge(input);

            Assert.Equal(12, result);
        }

        [Fact]
        public void InputSet5_ShouldThrow()
        {
            var solver = new Solver();
            var input = new[] { 6 };

            Assert.Throws<ArgumentException>(() => solver.Challenge(input));
        }

        [Fact]
        public void InputSet6_ShouldReturn7()
        {
            var solver = new Solver();
            var input = new[] { 6, 1, 6, 1 };

            var result = solver.Challenge(input);

            Assert.Equal(7, result);
        }
    }
}
