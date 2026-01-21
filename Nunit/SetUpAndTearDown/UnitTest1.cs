using NUnit.Framework;

namespace DatabaseTests
{
    [TestFixture]
    public class DatabaseConnectionTests
    {
        private DatabaseConnection db;

        // Runs BEFORE each test
        [SetUp]
        public void Setup()
        {
            db = new DatabaseConnection();
            db.Connect();
        }

        // Runs AFTER each test
        [TearDown]
        public void TearDown()
        {
            db.Disconnect();
        }

        [Test]
        public void Connect_EstablishesConnection()
        {
            Assert.IsTrue(db.IsConnected);
        }

        [Test]
        public void Disconnect_ClosesConnection()
        {
            db.Disconnect();
            Assert.IsFalse(db.IsConnected);
        }
    }
}
