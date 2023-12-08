using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class PalidromeTest
    {
        [Test]
        public void PalidRom_WithNonPalindromeString_ShouldReturnNotAPalidrome()
        {
            // Arrange
            var palindromeChecker = new Palidrome();
            var inputString = "Hello, World!";

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                palindromeChecker.Palid(inputString);

                // Assert
                string expectedOutput = "The entered string is not a palindrome." + Environment.NewLine;
                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }
    }
}