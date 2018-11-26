using No6;
using System.Linq;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            // Act
            int[] result =  Generator.GenerateSequence<int>(10, (x1, x2) =>  x1 + x2 , 1, 1).ToArray();

            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence2()
        {
            int[] result = Generator.GenerateSequence<int>(10, (x1, x2) => 6 * x2 - 8 * x1, 1, 2).ToArray();

            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] result = Generator.GenerateSequence<double>(10, (x1, x2) => x2 + x1 / x2, 1, 2).ToArray();

            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            for ( int i = 0; i < result.Length; i++)
            {
                Assert.AreEqual(result[i], expected[i], 0.0000001);
            }
        }
    }
}
