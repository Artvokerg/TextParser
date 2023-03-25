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
}
