using System;
using Xunit;

namespace BadSuperbowlNamer.Tests
{
    public class NumberConverterTest
    {
        [Fact] //required attribute so that xUnit will detect this method as a test
        public void Number_One_Is_Converted_To_Roman_Numeral_Correctly()
        {
            //tests pass when no exceptions are thrown during the test - tests fail when any exception is thrown during the test

            //Arrange -> context that the test is run inside of, Given...
            var numberToTest = 1;
            var expectedOutcome = "I";

            //Act -> the actual thing we're testing, do this thing, When this happens...
            string actualOutcome = NumberConverter.Convert(1);

            //Assert -> lay out the expectationsin such a way that, if not met, exceptions are thrown, Then this should happen...
            Assert.Equal(expectedOutcome, actualOutcome);
        }
    }
}