using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp7;


namespace ConsoleApp7.UnitTests
{
    [TestClass]
    public class FindUniqueNamesWithVowelsTests

    {
        [TestMethod]
        public void GetUniqueWords_StartsWithVowel_ReturnsTrue() 
        {
            //Arrange
            var findunique = new ConsoleApp7.FindUniqueNamesWithVowels();

            //Act

           var result= FindUniqueNamesWithVowels.GetUniqueWords(new string[] { "Amazon", "Youtube", "Uber", "good" },
                new string[] { "Amazon", "Elephant", "Youtube", "good" });

            //Assert

            Assert.IsTrue(result);

        }
    }
}
