using TextParser.Models;

namespace TextParser.DAO
{
    internal class EngTranslatedPairsDao : IEngTranslatedPairsDao
    {
        private HashSet<EngTranslatedPair> engTranslatedPairs;

        public void SetEngTranslatedPairs(HashSet<EngTranslatedPair> engTranslatedPairs)
        {
            this.engTranslatedPairs = engTranslatedPairs;
        }

        public HashSet<EngTranslatedPair> GetEngTranslatedPairs()
        {
            return this.engTranslatedPairs;
        }

        public HashSet<EngTranslatedPair> GetOnlyUnknownEngTranslatedPairs()
        {
            return this.engTranslatedPairs.Where(pair => pair.engWord.IsKnown == false).ToHashSet();
        }

        public void SetKnownWordValue(string word, bool isKnown)
        {
            foreach (EngTranslatedPair pair in this.engTranslatedPairs)
            {
                if (pair.engWord.Word == word)
                {
                    pair.engWord.IsKnown = isKnown;
                    return;
                }
            }
        }
    }
}
