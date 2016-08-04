using FluentAssertions;
using NUnit.Framework;
using Microsoft.SqlServer.Management.Smo;
using ServiceStackServer2;

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

        [Test]
        public void ConnectionTestLocalHost()
        {
            var server = new Server();
            server.ConnectionContext.ConnectionString = "Data Source=(local);Initial Catalog=master;Integrated security=true";
            var db = new Database(server, "master");
            var r = db.ExecuteWithResults("SELECT * FROM sys.[databases]");
            r.Should().NotBe(null);
        }

        [Test]
        public void ConnectionTestDev02Ip15()
        {
            var server = new Server();
            server.ConnectionContext.ConnectionString = "Server=192.168.128.15,1433;Database=FMS;User ID=damu;Password=pXfeN5wT;Max Pool Size=1024";
            var db = new Database(server, "master");
            var r = db.ExecuteWithResults("SELECT * FROM sys.[databases]");
            r.Should().NotBe(null);
        }

        [Test]
        public void ConnectionTestProdIp51()
        {
            var server = new Server();
            server.ConnectionContext.ConnectionString = "Server=192.168.128.51,1433;Database=FMS;User ID=ikasEhuFAmiZ;Password=UQy4EZYdaZY2;Max Pool Size=1024";
            var db = new Database(server, "master");
            var r = db.ExecuteWithResults("SELECT * FROM sys.[databases]");
            r.Should().NotBe(null);
        }

        [Test]
        public void ConnectionTestAzureProd()
        {
            var server = new Server();
            server.ConnectionContext.ConnectionString = "Server=13.94.159.4,1433;;Database=FMS;User ID=ikasEhuFAmiZ;Password=UQy4EZYdaZY2;Max Pool Size=1024";
            var db = new Database(server, "master");
            var r = db.ExecuteWithResults("SELECT * FROM sys.[databases]");
            r.Should().NotBe(null);
        }

        [Test]
        public void ConnectionTestAzureDev()
        {
            var server = new Server();
            server.ConnectionContext.ConnectionString = "Server=13.94.159.4,1434;Database=FMS;User ID=damu;Password=pXfeN5wT;Max Pool Size=1024";
            var db = new Database(server, "master");
            var r = db.ExecuteWithResults("SELECT * FROM sys.[databases]");
            r.Should().NotBe(null);
        }
    }
}