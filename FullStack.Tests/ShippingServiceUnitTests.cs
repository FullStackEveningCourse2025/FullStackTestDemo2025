using FluentAssertions;
using FullStack.Domain;

namespace FullStack.Tests
{
    public class ShippingServiceUnitTests
    {
        [Fact]
        public void Calculate_ReturnsExpected()
        {
            // sut = system under test
            var sut = new ShippingService();
            decimal result = sut.Calculate(10, "IE");
            result.Should().Be(4.99m);
          //  Assert.Equal(4.99m,result);
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