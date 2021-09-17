using System;
using Xunit;
using ConsoleAppMisc;
using System.Collections.Generic;

namespace ConsoleAppMisc.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("8,8", 8.8)]
        [InlineData("7.7", 7.7)]
        public void AddNumberToListWithStringGoodInputTest(string goodInput, double goodNumberExpected)
        {
            //Arrange
            List<double> numberList = new List<double>();

            //Act
            bool result = Program.AddNumberToList(numberList, goodInput);

            //Assert
            Assert.True(result);
            Assert.Contains(goodNumberExpected, numberList);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("nine")]
        [InlineData("2a")]
        [InlineData("XI")]
        public void AddNumberToListWithStringBadInputTest(string badInput)
        {
            //Arrange

            List<double> numberList = new List<double>();

            //Act
            bool result = Program.AddNumberToList(numberList, badInput);

            //Assert
            Assert.False(result);
            Assert.Empty(numberList);
        }
    }
}
