using ConsoleAppMisc.Models;
using System;
using Xunit;

namespace ConsoleAppMisc.Tests.xUnit.Models
{
    public class CakeTests
    {
        [Fact]
        public void BakeTheCakeGoodTempTimeTest()
        {
            //Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("strabarry","cream", time, temp );

            //Act
            bool cakeNotDone = testCake.BakedAndDone;
            bool result = testCake.BakeTheCake(temp, time);

            //Assert
            Assert.False(cakeNotDone);
            Assert.True(result);
            Assert.True(testCake.BakedAndDone);
        }

        [Theory]
        [InlineData(1, 0.9)]// 1 == 100% | 0.9 == 90%
        [InlineData(0.9, 1)]
        [InlineData(0.9, 0.8)]
        public void BakeTheCakeBadTempTimeTest(double tempOffset, double timeOffset)
        {
            //Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("strabarry", "cream", time, temp);

            //Act
            bool cakeNotDone = testCake.BakedAndDone;
            bool result = testCake.BakeTheCake(temp * tempOffset, time * timeOffset);

            //Assert
            Assert.False(cakeNotDone);
            Assert.False(result);
            Assert.False(testCake.BakedAndDone);
        }

        [Fact]
        public void BurnTheCakeTest()
        {
            //Arrange
            TimeSpan time = new TimeSpan(0, 45, 0);
            double temp = 175.2;
            Cake testCake = new Cake("strabarry", "cream", time, temp);
            bool cakeNotDone = testCake.BakedAndDone;

            //Act
            Exception result = Assert.Throws<Exception>( () => testCake.BakeTheCake((temp*3), (time*3)));

            //Assert
            Assert.False(cakeNotDone);
            Assert.Contains("burnt", result.Message);
            Assert.False(testCake.BakedAndDone);
        }
    }
}
