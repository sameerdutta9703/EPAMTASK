using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;

namespace TestMVC
{
    [TestClass]
    public class UnitTest1
    {
        //For the Stub
        [TestMethod]
        public void TestMethod1()
        {
            //Act  
            StubExtensionManager stub = new StubExtensionManager();
            FileChecker checker = new FileChecker(stub);

            //Action  
            bool IsTrueFile = checker.CheckFile("myFile.whatever");

            //Assert  
            Assert.AreEqual(true, IsTrueFile);
        }
    }
}