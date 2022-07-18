using NUnit.Framework;
using System.Threading;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Search_by_Name()
        {
            Thread.Sleep(250);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void Search_by_Id()
        {
            Thread.Sleep(380);

            Assert.AreEqual(0, 0);
        }

        [Test]
        public void TestRegister()
        {
            Thread.Sleep(200);

            Assert.AreEqual(0, 0);
        }


        [Test]
        public void TestSignIn()
        {
            Thread.Sleep(280);

            Assert.AreEqual(0, 0);
        }

    }
}