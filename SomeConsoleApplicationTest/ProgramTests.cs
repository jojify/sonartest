using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeConsoleApplication;


namespace SomeConsoleApplicationTest
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AlwaysReturnsTrue_ReturnsTrue()
        {
            // Arrange & Act
            var actual = Program.AlwaysReturnsTrue();

            // Assert
            Assert.IsTrue(actual);
        }
    }
}
