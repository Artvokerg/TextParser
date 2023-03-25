namespace TextParser.Models
{
    internal class EngTranslatedPair
    {
        public EngWord engWord;
        public string translatedWord;

        public EngTranslatedPair(EngWord engWord, string translatedWord)
        {
            this.engWord = engWord;
            this.translatedWord = translatedWord;
        }
        public EngTranslatedPair()
        {
        }

        public override int GetHashCode()
        {
            return engWord.GetHashCode();
        }
    }
}
