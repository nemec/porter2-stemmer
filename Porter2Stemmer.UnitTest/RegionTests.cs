using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porter2Stemmer.UnitTest
{
    [TestClass]
    public class RegionTests
    {
        [TestMethod]
        public void GetRegion1_WithWordContainingRegion1AndRegion2_ProvidesCorrectRangeForRegion1()
        {
            // Arrange
            const string word = "beautiful";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.GetRegion1(word);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void GetRegion2_WithWordContainingRegion1AndRegion2_ProvidesCorrectRangeForRegion2()
        {
            // Arrange
            const string word = "beautiful";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.GetRegion2(word);

            // Assert
            Assert.AreEqual(7, actual);
        }

        [TestMethod]
        public void GetRegion1_WithWordContainingOnlyRegion1_ProvidesCorrectRangeForRegion1()
        {
            // Arrange
            const string word = "beauty";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.GetRegion1(word);

            // Assert
            Assert.AreEqual(5, actual);
        }

        [TestMethod]
        public void GetRegion2_WithWordContainingOnlyRegion1_ProvidesRangeWithLength0()
        {
            // Arrange
            const string word = "beauty";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.GetRegion2(word);

            // Assert
            Assert.AreEqual(0, actual - word.Length);
        }

        [TestMethod]
        public void GetRegion1_WithWordContainingNeitherRegion_ProvidesRangeWithLength0()
        {
            // Arrange
            const string word = "beau";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.GetRegion1(word);

            // Assert
            Assert.AreEqual(0, actual - word.Length);
        }

        [TestMethod]
        public void GetRegion2_WithWordContainingNeitherRegion_ProvidesRangeWithLength0()
        {
            // Arrange
            const string word = "beau";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.GetRegion2(word);

            // Assert
            Assert.AreEqual(0, actual - word.Length);
        }
    }
}
