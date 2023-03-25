using TextParser.Models;

namespace TextParser.DAO
{
    internal interface IEngTranslatedPairsDao
    {
        void SetEngTranslatedPairs(HashSet<EngTranslatedPair> translatedWords);
        HashSet<EngTranslatedPair> GetEngTranslatedPairs();
    }
}
