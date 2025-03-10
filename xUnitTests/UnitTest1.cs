using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Calculator
{
    public class UnitTest1
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
    }
}