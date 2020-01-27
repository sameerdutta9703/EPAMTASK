using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MockChecking;
using Moq;
using UnitTestingMock;

namespace MajorTestingMOQProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Mock<MockCheckingclass> mock = new Mock<MockCheckingclass>();
            mock.Setup(x => x.sendMsg()).Returns(true);

            var send = new UnitTestingMockClass();
            Assert.IsTrue(send.sendMsgToUser(mock.Object));

        }
    }
}
