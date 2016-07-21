using FluentAssertions;
using NUnit.Framework;
using ServiceStackServer;

namespace ServiceStackServer2Tests
{
    [TestFixture]
    public class DateTimeServiceTests
    {
        [Test]
        public void GetCurrentDateTimeAsUtc_ShouldBeAsExpected()
        {
            var dt = new TestMe().GetCurrentDateTimeAsUtc();

            dt.Year.Should().Be(2016);
        }

        //[Test]
        //public void GetCurrentDateTimeAsUtc_ShouldFail()
        //{
        //    var dt = new TestMe().GetCurrentDateTimeAsUtc();

        //    dt.Year.Should().Be(2017);
        //}
    }
}