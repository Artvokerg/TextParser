namespace TextParser
{
    internal class EngWord
    {
        public string Word;

        public int CountInText;
        public bool IsKnown = false;

        public override int GetHashCode()
        {
            return Word.GetHashCode();
        }
    }

    internal class EngWordsModel
    {
        //private Dictionary<string, int> engWords;
        private HashSet<EngWord> engWords;

        public void SetEngWords(HashSet<EngWord> engWords)
        {
            this.engWords = engWords;
        }

        public void SetEngWords(Dictionary<string, int> engWordsDictionary)
        {
            HashSet<EngWord> engWordsHashSet = new HashSet<EngWord>();

            foreach (var engWordDictionary in engWordsDictionary)
            {
                EngWord engWord = new EngWord();

                engWord.Word = engWordDictionary.Key;
                engWord.CountInText = engWordDictionary.Value;

                engWordsHashSet.Add(engWord);
            }

            this.engWords = engWordsHashSet;
        }

        public HashSet<EngWord> GetEngWords()
        {
            return this.engWords;
        }
        
        public IEnumerable<EngWord> GetEngWordsOrderByCountInText()
        {
            return this.engWords.OrderBy(pair => pair.CountInText).Reverse();
        }
    }
}
