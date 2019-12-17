using System;
using NUnit.Framework;

namespace ProxyPattern.Tests
{
    [TestFixture]
    public class ProxyTest
    {
        [Test]
        public void Internet_ConnectToGoogle_ReturnConnectedToGoogle()
        {
            var internet = new InternetProxy();
            var calculatedResult = internet.ConnectTo("google.com");
            const string expectedResult = "Connected to: google.com";
            Assert.That(expectedResult, Is.EqualTo(calculatedResult));
        }

        [Test]
        public void Internet_ConnectToGoogle_ThrowsException()
        {
            var internet = new InternetProxy();
            Assert.Throws<Exception>(() => internet.ConnectTo("abc.com"));
        }
    }
}