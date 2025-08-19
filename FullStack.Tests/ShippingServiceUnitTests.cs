using FluentAssertions;
using FullStack.Domain;

namespace FullStack.Tests
{
    public class ShippingServiceUnitTests
    {
        [Fact]
        public void Calculate_ReturnsExpectedIE()
        {
            // sut = system under test
            var sut = new ShippingService();
            decimal result = sut.Calculate(10, "IE");
            result.Should().Be(4.99m);
          //  Assert.Equal(4.99m,result);
        }


        [Theory]
        [InlineData(10,"IE",4.99)]
        [InlineData(50,"IE",0)]
        [InlineData(75,"IE",0)]
        [InlineData(20,"US",9.99)]
        public void Calculate_ReturnsExpected(decimal subtotal, string country, decimal expected)
        {
            // sut = system under test
            var sut = new ShippingService();
            decimal result = sut.Calculate(subtotal, country);
            result.Should().Be(expected);

        }

        [Fact]
        public void Calculate_NegativeSubtotal_Throws()
        {
            var sut = new ShippingService();
            var act = () => sut.Calculate(-1, "IE");
            act.Should().Throw<ArgumentOutOfRangeException>();
        }
    }
}