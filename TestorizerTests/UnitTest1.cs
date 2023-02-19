using TesterWPF.Models;

namespace Tests
{
    [TestFixture]
    public class SessionTests
    {
        [TestCase(0, "0259")]
        [TestCase(1, "1360")]
        [TestCase(2, "2471")]
        [TestCase(3, "3582")]
        [TestCase(4, "4693")]
        [TestCase(5, "5704")]
        [TestCase(6, "6815")]
        [TestCase(7, "7926")]
        [TestCase(8, "8037")]
        [TestCase(9, "9148")]
        public void Test(int day, string expectetId)
        {
            Assert.AreEqual(expectetId, Session.GenerateQueueId(day));
        }

    }

    [TestFixture]
    public class DayGeneratorTests
    {
        [Test]
        public void FirstDayOfYear()
        {
            DateTime date = new DateTime(2023,1,1);
            Assert.AreEqual(0, Session.GetCurrentDay(date));
        }
        [Test]
        public void ElevenJanuary()
        {
            DateTime date = new DateTime(2023, 1, 11);
            Assert.AreEqual(0, Session.GetCurrentDay(date));
        }

        [Test]
        public void Today()
        {
            DateTime date = DateTime.Today;
            Assert.AreEqual(9, Session.GetCurrentDay(date));
        }
    }
}