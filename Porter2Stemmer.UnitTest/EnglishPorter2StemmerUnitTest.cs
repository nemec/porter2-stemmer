using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Porter2Stemmer.UnitTest
{
    [TestClass]
    public class EnglishPorter2StemmerUnitTest
    {
        [StemmingData, TestMethod]
        public void Stem_WithBatchData_StemsAllWordsCorrectly(string unstemmed, string expected)
        {
            var stemmer = new EnglishPorter2Stemmer();

            var stemmed = stemmer.Stem(unstemmed).Value;

            Assert.AreEqual(expected, stemmed);
        }

        class StemmingDataAttribute : Attribute, ITestDataSource
        {
            public IEnumerable<object[]> GetData(MethodInfo methodInfo)
            {
                using (var stream = typeof(StemmingDataAttribute).Assembly
                    .GetManifestResourceStream("Porter2Stemmer.UnitTest.data.csv"))
                {
                    using (var reader = new StreamReader(stream))
                    {
                        var line = reader.ReadLine();
                        while(reader.ReadLine() != null)
                        {
                            var splittedLine = line.Split(',');
                            yield return new object[] 
                            {
                                splittedLine.First(),
                                splittedLine.Skip(1).First()
                            };
                            line = reader.ReadLine();
                        }
                    }
                }
            }

            public string GetDisplayName(MethodInfo methodInfo, object[] data)
            {
                if (data != null)
                {
                    return string.Format(CultureInfo.CurrentCulture, "{0} ({1})", methodInfo.Name, string.Join(",", data));
                }
                return null;
            }
        }
    }
}
