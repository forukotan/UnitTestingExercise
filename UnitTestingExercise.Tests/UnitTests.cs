using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            var test1 = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                var actual = test1.Add(num1, num2, num3);
                

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(3,1,2)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:


            //Arrange
            var test2 = new Calculator();

            //Act
            var actual2 =test2.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual2);
        }

        [Theory]
        [InlineData(2,3,6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var test3 = new Calculator();
            //Act
            var actual3= test3.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual3);
        }

        [Theory]
        [InlineData(2,1,2)]
       
        // [InlineData(3,1,2)] this one should fail
        
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var test4 = new Calculator();

            //Act
            var actual4 = test4.divide(num1, num2);
            //Assert
            Assert.Equal(actual4,expected);
        }

    }
}
