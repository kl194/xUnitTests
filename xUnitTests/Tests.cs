using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Calculator
{
    public class Tests
    {
        [Fact]
        public void Сheck_Add()
        {
            //Arrange
            int[] f1 = { 1, 2 };
            int[] f2 = { 2, 2 };

            //Act
            int[] f = Calculator.Add(f1, f2);

            //Assert
            Assert.Equal(6, f[0]);
            Assert.Equal(4, f[1]);
        }

        [Fact]
        public void Сheck_Subtract()
        {
            //Arrange
            int[] f1 = { 2, 2 };
            int[] f2 = { 1, 2 };

            //Act
            int[] f = Calculator.Subtract(f1, f2);

            //Assert
            Assert.Equal(2, f[0]);
            Assert.Equal(4, f[1]);
        }

        [Fact]
        public void Сheck_Multiply()
        {
            //Arrange
            int[] f1 = { 1, 2 };
            int[] f2 = { 2, 2 };

            //Act
            int[] f = Calculator.Multiply(f1, f2);

            //Assert
            Assert.Equal(2, f[0]);
            Assert.Equal(4, f[1]);
        }

        [Fact]
        public void Сheck_Divide()
        {
            //Arrange
            int[] f1 = { 2, 2 };
            int[] f2 = { 1, 2 };

            //Act
            int[] f = Calculator.Divide(f1, f2);

            //Assert
            Assert.Equal(4, f[0]);
            Assert.Equal(2, f[1]);
        }
        [Fact]
        public void Сheck_Add_Minus()
        {
            //Arrange
            int[] f1 = { -1, 2 };
            int[] f2 = { -2, 2 };

            //Act
            int[] f = Calculator.Add(f1, f2);

            //Assert
            Assert.Equal(-6, f[0]);
            Assert.Equal(4, f[1]);
        }

        [Fact]
        public void Сheck_Subtract_Minus()
        {
            //Arrange
            int[] f1 = { -2, 2 };
            int[] f2 = { -1, 2 };

            //Act
            int[] f = Calculator.Subtract(f1, f2);

            //Assert
            Assert.Equal(-2, f[0]);
            Assert.Equal(4, f[1]);
        }

        [Fact]
        public void Сheck_Multiply_Minus()
        {
            //Arrange
            int[] f1 = { -1, 2 };
            int[] f2 = { 2, 2 };

            //Act
            int[] f = Calculator.Multiply(f1, f2);

            //Assert
            Assert.Equal(-2, f[0]);
            Assert.Equal(4, f[1]);
        }

        [Fact]
        public void Сheck_Divide_Minus()
        {
            //Arrange
            int[] f1 = { -2, 2 };
            int[] f2 = { 1, 2 };

            //Act
            int[] f = Calculator.Divide(f1, f2);

            //Assert
            Assert.Equal(-4, f[0]);
            Assert.Equal(2, f[1]);
        }


    }
}