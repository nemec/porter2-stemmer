using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porter2Stemmer.UnitTest
{
    [TestClass]
    public class MarkingVowelsAsConsonants
    {
        [TestMethod]
        public void MarkVowelsAsConsonants_WithInitialY_MarksYAsConsonant()
        {
            const string word = "youth";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("Youth", actual);
        }

        [TestMethod]
        public void MarkVowelsAsConsonants_WithYAfterVowel_MarksYAsConsonant()
        {
            const string word = "boy";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("boY", actual);
        }

        [TestMethod]
        public void MarkVowelsAsConsonants_WithYBetweenTwoVowels_MarksYAsConsonant()
        {
            const string word = "boyish";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("boYish", actual);
        }

        [TestMethod]
        public void MarkVowelsAsConsonants_WithYAfterConsonant_DoesNotMarkYAsConsonant()
        {
            const string word = "fly";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("fly", actual);
        }

        [TestMethod]
        public void MarkVowelsAsConsonants_WithVowelOnlyFollowingY_DoesNotMarkYAsConsonant()
        {
            const string word = "flying";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("flying", actual);
        }

        [TestMethod]
        public void MarkVowelsAsConsonants_WithNoVowelsButY_DoesNotMarkAnyYAsConsonant()
        {
            const string word = "syzygy";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("syzygy", actual);
        }

        [TestMethod]
        public void MarkVowelsAsConsonants_WithDoubledY_MarksFirstButNotSecondYAsConsonant()
        {
            const string word = "sayyid";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.MarkYsAsConsonants(word);

            // Assert
            Assert.AreEqual("saYyid", actual);
        }
    }
}
