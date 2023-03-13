namespace TextParser.Models
{
    internal class TranslatedWordsModel
    {
        private Dictionary<EngWord, string> translatedWords;

        public void SetTranslatedWords(Dictionary<EngWord, string> translatedWords)
        {
            this.translatedWords = translatedWords;
        }

        public Dictionary<EngWord, string> GetTranslatedWords()
        {
            return this.translatedWords;
        }
    }
}
