using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class FirstTest
    {
        [Test]
        public void greet_whenCalled_ShouldReturnHello()
        {
            //TRIPPLE A =>AAA ARRANGE,ACT & ASSERT

            //ARRANGE
            var hello = new Test();

            // ACT

            var result = hello.greet();

            //ASSERT 

            Assert.That(result, Is.EqualTo(" HELLO "));
        }
    }
}
