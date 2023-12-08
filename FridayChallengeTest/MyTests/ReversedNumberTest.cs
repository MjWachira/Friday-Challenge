using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class ReversedNumberTest
    {
        [TestFixture]
        public class ReverseNumberTests
        {
            [Test]
            public void ReverseNumbers_WithPositiveInteger_ShouldReturnReversedNumber()
            {
                // Arrnge
                var numberReverser = new ReverseNumber();

                // Act
                int result = numberReverser.ReverseNumbers(123);

                // Assert
                Assert.That(result, Is.EqualTo(321));
            }
        }
    }
}
