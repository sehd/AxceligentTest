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
    }
}
