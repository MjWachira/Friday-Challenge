using Friday_Challenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridayChallengeTest.MyTests
{
    [TestFixture]
    public class ArrayChunksTest
    {
        [Test]
        public void ArrayChunk_ArrayAndChunkSize_ShouldReturnCorrectChunks()
        {
            // Arrange
            var arrayChunks = new ArrayChunks();
            int[] sourceArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 4, 4 };
            int chunkSize = 3;

            // Act
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                arrayChunks.ArrayChunk(sourceArray, chunkSize);

                // Assert
                string expectedOutput =
                    "[ 1, 2, 3 ]" + Environment.NewLine +
                    "[ 4, 5, 6 ]" + Environment.NewLine +
                    "[ 7, 8, 9 ]" + Environment.NewLine +
                    "[ 10, 11, 12 ]" + Environment.NewLine +
                    "[ 4, 4 ]" + Environment.NewLine;

                Assert.That(sw.ToString(), Is.EqualTo(expectedOutput));
            }
        }
        
    }
       
}

