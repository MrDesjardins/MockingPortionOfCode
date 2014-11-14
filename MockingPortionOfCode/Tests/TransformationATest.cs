using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MockingPortionOfCode
{
    using ClassesToTest;
    using Moq;

    [TestClass]
    public class TransformationATest
    {
        [TestMethod]
        public void MyTest()
        {
            //Arrange
            var whatWeWantToTest = new MyConcreteImplementation(100);
            var mock = new Mock<IMyInterface>();
            mock.Setup(d => d.TransformationA()).Callback(whatWeWantToTest.TransformationA);
            // -- We do nothing for B --

            // Act
            mock.Object.TransformationA();

            //Assert
            Assert.AreEqual(102, whatWeWantToTest.Counter);

        }
    }
}
