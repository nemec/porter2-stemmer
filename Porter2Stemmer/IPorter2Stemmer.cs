
namespace Porter2Stemmer
{
    public interface IPorter2Stemmer : IStemmer
    {
        /// <summary>
        /// Vowel characters used for stemming.
        /// </summary>
        char[] Vowels { get; }

        /// <summary>
        /// Valid doubled letters used for stemming.
        /// </summary>
        string[] Doubles { get; }

        /// <summary>
        /// Li- endings used for stemming.
        /// </summary>
        char[] LiEndings { get; }

        /// <summary>
        /// R1 is the region after the first non-vowel following a vowel, 
        /// or the end of the word if there is no such non-vowel. 
        /// This definition may be modified for certain exceptional words.
        /// </summary>
        int GetRegion1(string word);

        /// <summary>
        /// R2 is the region after the first non-vowel following a vowel in 
        /// R1, or the end of the word if there is no such non-vowel.
        /// </summary>
        int GetRegion2(string word);
    }
}
