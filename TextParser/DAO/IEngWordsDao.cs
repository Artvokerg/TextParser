namespace TextParser.DAO
{
    internal interface IEngWordsDao
    {
        void SetEngWords(HashSet<EngWord> engWords);
        void SetEngWords(Dictionary<string, int> engWordsDictionary);
        HashSet<EngWord> GetEngWords();
        IEnumerable<EngWord> GetEngWordsOrderByCountInText();
    }
}
