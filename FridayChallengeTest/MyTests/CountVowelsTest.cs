using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class CountVowelsTest
    {
        [Test]
        public void CountVowel_()
        {
            // Arrange
            // Arrange
            var countVowels = new CountVowels();

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                countVowels.CountVowel("abcxyz123");

                // Assert
                string consoleOutput = sw.ToString();
                Assert.That(consoleOutput, Does.Contain("count of vowel = 1"));
                //Assert.That(consoleOutput, Does.Contain("count of consonant = 6"));
            }


        }
    }

}
