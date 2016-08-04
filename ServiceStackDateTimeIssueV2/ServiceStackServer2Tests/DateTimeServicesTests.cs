using System.Data;
using System.Data.SqlClient;
using FluentAssertions;
using NUnit.Framework;
using Microsoft.SqlServer.Management.Smo;
using ServiceStackServer2;

namespace ServiceStackServer2Tests
{
    [TestFixture]
    public class DateTimeServiceTests
    {
        //[Test]
        //public void GetCurrentDateTimeAsUtc_ShouldBeAsExpected()
        //{
        //    var dt = new TestMe().GetCurrentDateTimeAsUtc();

        //    dt.Year.Should().Be(2016);
        //}

        //[Test]
        //public void GetCurrentDateTimeAsUtc_ShouldFail()
        //{
        //    var dt = new TestMe().GetCurrentDateTimeAsUtc();

        //    dt.Year.Should().Be(2017);
        //}

        //[Test]
        //public void ConnectionTestLocalHost()
        //{
        //    using (var connection = new SqlConnection("Data Source=(local);Initial Catalog=master;Integrated security=true;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //    }
        //}

        //[Test]
        //public void ConnectionTestDev02Ip15()
        //{
        //    using (var connection = new SqlConnection("Server=192.168.128.15,1433;Database=FMS;User ID=damu;Password=pXfeN5wT;Max Pool Size=1024;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //    }
        //}

        //[Test]
        //public void ConnectionTestProdIp51()
        //{
        //    using (var connection = new SqlConnection("Server=192.168.128.51,1433;Database=FMS;User ID=ikasEhuFAmiZ;Password=UQy4EZYdaZY2;Max Pool Size=1024;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //    }
        //}

        //[Test]
        //public void ConnectionTestAzureProd()
        //{
        //    using (var connection = new SqlConnection("Server=13.94.159.4,1433;;Database=FMS;User ID=ikasEhuFAmiZ;Password=UQy4EZYdaZY2;Max Pool Size=1024;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //    }
        //}

        //[Test]
        //public void ConnectionTestAzureDev()
        //{
        //    using (var connection = new SqlConnection("Server=13.94.159.4,1434;Database=FMS;User ID=damu;Password=pXfeN5wT;Max Pool Size=1024;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //        //const string str = "CREATE DATABASE AzureTests";

        //        //SqlCommand myCommand = new SqlCommand(str, connection);
        //        //myCommand.ExecuteNonQuery();
        //    }
        //}

        //[Test]
        //public void ConnectionTestAzureProdExternal()
        //{
        //    using (var connection = new SqlConnection("Server=195.69.130.51,1433;;Database=FMS;User ID=ikasEhuFAmiZ;Password=UQy4EZYdaZY2;Max Pool Size=1024;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //    }
        //}

        //[Test]
        //public void ConnectionTestAzureDevExternal()
        //{
        //    using (var connection = new SqlConnection("Server=195.69.130.15,1433;Database=FMS;User ID=damu;Password=pXfeN5wT;Max Pool Size=1024;Connection Timeout=5;"))
        //    {
        //        connection.Open();
        //        connection.State.Should().Be(ConnectionState.Open);
        //        connection.Close();
        //    }
        //}

        [Test]
        public void ConnectionTestAzureInternalDb()
        {
            using (var connection = new SqlConnection("Server=trackunit-unittest.database.windows.net,1433;Persist Security Info=False;User ID=unittest;Password=!Unit45T3st;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=5"))
            {
                connection.Open();
                connection.State.Should().Be(ConnectionState.Open);
                connection.Close();
            }
        }
    }
}