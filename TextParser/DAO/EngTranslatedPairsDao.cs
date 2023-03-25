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
    }
}
