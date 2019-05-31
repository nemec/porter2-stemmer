using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porter2Stemmer.UnitTest
{
    [TestClass]
    public class RemoveSPluralTests
    {
        [TestMethod]
        public void RemoveSPluralSuffix_WithWordEndingInApostrophe_RemovesSuffix()
        {
            const string word = "holy'";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.Step0RemoveSPluralSuffix(word);

            // Assert
            Assert.AreEqual("holy", actual);
        }

        [TestMethod]
        public void RemoveSPluralSuffix_WithWordEndingInApostropheS_RemovesSuffix()
        {
            const string word = "holy's";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.Step0RemoveSPluralSuffix(word);

            // Assert
            Assert.AreEqual("holy", actual);
        }

        [TestMethod]
        public void RemoveSPluralSuffix_WithWordEndingInApostropheSApostrophe_RemovesSuffix()
        {
            const string word = "holy's'";
            var stemmer = new EnglishPorter2Stemmer();

            // Act
            var actual = stemmer.Step0RemoveSPluralSuffix(word);

            // Assert
            Assert.AreEqual("holy", actual);
        }
    }
}
