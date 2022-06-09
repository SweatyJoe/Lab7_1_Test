using Lab7_1;
using Xunit;

namespace TestLab7
{
    public class UnitTest1
    {
        [Fact]
        public void getSumVectorsTest1()
        {
            // Arrange
            Vector vector1 = new Vector(25, 14, -13);
            Vector vector2 = new Vector(0.21f, 1.23f, 43.21f);
            Vector expected = new Vector(25.21f, 15.23f, 30.21f);

            // Act
            Vector actual = new Vector(0, 0, 0);
            actual = actual.sumVectors(vector1, vector2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void multiplication_3_14_Test1()
        {
            // Arrange
            float number = 3;
            Vector vector = new Vector(2, 6, -13);
            Vector expected = new Vector(6, 18, -39);

            // Act
            Vector actual = new Vector(0, 0, 0);
            actual = actual.multiplication(vector, number);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}