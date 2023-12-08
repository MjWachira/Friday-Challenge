using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class MostAppearingTest
    {
        [Test]
        public void MostAppearing_EmptyString_ReturnsErrorMessage()
        {
            // Arrange
            MostAppearingCharacter mostAppearingCharacter = new MostAppearingCharacter();
            string input = "asddd";

            // mostAppearingCharacter.MostAppearing(input);


            //Assert.That(mostAppearingCharacter, Is.EqualTo("d"));
            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                mostAppearingCharacter.MostAppearing(input);

                // Assert
                string expectedOutput = "The most appearing character is: 'd'" + Environment.NewLine;
                Assert.That(sw.ToString(), Does.Contain(expectedOutput));
            }

        }
  
    }

}

