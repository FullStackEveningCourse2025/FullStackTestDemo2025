using FluentAssertions;
using FullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Tests
{
    public  class PersonTests
    {
        [Theory]
        [InlineData("Bruce","Wayne", "Hello, I am Bruce Wayne!")]
        [InlineData("Peter","Parker", "Hello, I am Peter Parker!")]

        public void Person_ReturnsCorrectGreeting(string first, string last, string expected)
        {
            // sut = system under test
            var sut = new Person() { First = first, Last = last };
            string greeting = sut.ToString();
            greeting.Should().Be(expected);

        }
    }
}
