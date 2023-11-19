using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using ReverseWordsOrder;

namespace ReverseOrderTest
{
    [TestClass]
    public class ReverseTest
    {
        [TestMethod]
        public void Order()
        {
            // Arrange
            string[] expected = { "Case 1: test a is this", "Case 2: foobar", "Case 3: base your all" };
            string[] inputArray = { "this is a test", "foobar", "all your base" };
            var reverser = new Reverser(new ReverseOrder(3, inputArray));

            // Act
            reverser.Reverse();

            // Assert
            Assert.AreEqual(expected[0], reverser._reverseOrder._strings[0]);
            Assert.AreEqual(expected[1], reverser._reverseOrder._strings[1]);
            Assert.AreEqual(expected[2], reverser._reverseOrder._strings[2]);
        }
    }
}