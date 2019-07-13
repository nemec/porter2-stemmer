using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porter2Stemmer.UnitTest
{
    [TestClass]
    public class ReplaceYSuffixWithITests
    {
        [TestMethod]
        public void ReplaceYSuffix_PreceededByConsonant_ReplacesSuffixWithI()
        {
            const string word = "cry";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.Step1CReplaceSuffixYWithIIfPreceededWithConsonant(word);

            // Assert
            Assert.AreEqual("cri", actual);
        }

        [TestMethod]
        public void ReplaceYSuffix_PreceededByConsonantAsFirstLetterOfWord_DoesNotReplaceSuffix()
        {
            const string word = "by";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.Step1CReplaceSuffixYWithIIfPreceededWithConsonant(word);

            // Assert
            Assert.AreEqual("by", actual);
        }

        [TestMethod]
        public void ReplaceYSuffix_NotPreceededyConsonant_DoesNotReplaceSuffix()
        {
            const string word = "say";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.Step1CReplaceSuffixYWithIIfPreceededWithConsonant(word);

            // Assert
            Assert.AreEqual("say", actual);
        }
    }
}
