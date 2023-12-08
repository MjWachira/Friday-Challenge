using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class CapitalizeWordsMethodTest
    {
        [Test]
        public void CapitalizeWords_WithSingleWord_ShouldReturnCapitalizedWord()
        {
            // Arrange
            string input = "hello";

            // Act
            string result = CapitalizeWordsMethod.CapitalizeWords(input);

            // Assert
            Assert.That(result, Is.EqualTo("Hello"));
        }

        [Test]
        public void CapitalizeWords_WithMultipleWords_ShouldReturnCapitalizedWords()
        {
            // Arrange
            string input = "hello there users";

            // Act
            string result = CapitalizeWordsMethod.CapitalizeWords(input);

            // Assert
            Assert.That(result, Is.EqualTo("Hello There Users"));
        }

        [Test]
        public void CapitalizeWords_WithLeadingTrailingSpaces_ShouldReturnCapitalizedWords()
        {
            // Arrange
            string input = "   hello there users   ";

            // Act
            string result = CapitalizeWordsMethod.CapitalizeWords(input);

            // Assert
            Assert.That(result, Is.EqualTo("Hello There Users"));
        }

       
        [Test]
        public void CapitalizeWords_WithEmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            string input = "";

            // Act
            string result = CapitalizeWordsMethod.CapitalizeWords(input);

            // Assert
            Assert.That(result, Is.EqualTo(string.Empty));
        }
    }

}
