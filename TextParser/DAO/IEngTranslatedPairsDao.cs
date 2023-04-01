using TextParser.Models;

namespace TextParser.DAO
{
    internal interface IEngTranslatedPairsDao
    {
        void SetEngTranslatedPairs(HashSet<EngTranslatedPair> translatedWords);
        HashSet<EngTranslatedPair> GetEngTranslatedPairs();
        HashSet<EngTranslatedPair> GetOnlyUnknownEngTranslatedPairs();
        void SetKnownWordValue(string word, bool isKnown);
    }
}
