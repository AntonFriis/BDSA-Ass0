using System;
using System.IO;
using Xunit;

namespace HelloWorld.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4, false)]
        [InlineData(100, false)]
        [InlineData(200, false)]
        [InlineData(400, false)]
        [InlineData(1582, false)]
        [InlineData(1583, false)]
        [InlineData(1584, true)]
        [InlineData(1800, false)]
        [InlineData(1600, true)]
        public void LeapYear_check(int year, bool expected)
        {
            Assert.Equal(expected, Program.IsLeapYear(year));
        }

        [Theory]
        [InlineData("1", "nay")]
        [InlineData("4", "nay")]
        [InlineData("1582", "nay")]
        [InlineData("1583", "nay")]
        [InlineData("1584", "yay")]
        [InlineData("1600", "yay")]
        [InlineData("1800", "nay")]
        [InlineData("test","Unable to parse 'test'")]
        public void Main_IsLeapYear_checks(string input, string output)
        {
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader(input);
            Console.SetIn(reader);
            Program.Main(Array.Empty<string>());

            var actual = writer.GetStringBuilder().ToString().Trim();
            
            Assert.Equal(output, actual);
        }
    }
}