using TextParser.Models;

namespace TextParser.DAO
{
    internal class WordsInFileDao
    {
        private List<WordInFile> m_wordsInFile;

        public void SetWords(List<WordInFile> wordsInFile)
        {
            m_wordsInFile = wordsInFile.OrderBy(worsInFile => worsInFile.CountInFile).Reverse().ToList();
        }

        public List<WordInFile> GetWordsInFile()
        {
            return m_wordsInFile;
        }

        public WordInFile GetWordInFile(int index)
        {
            return m_wordsInFile.ElementAt(index);
        }

        public WordInFile GetOnlyUnknownWordInFile(int index)
        {
            return m_wordsInFile.Where(wordInFile => wordInFile.Word.IsKnown == false).ElementAt(index);
        }


        public int GetWordsInFileCount()
        {
            return m_wordsInFile.Count;
        }

        public int GetOnlyUnknownWordsInFileCount()
        {
            return m_wordsInFile.Where(word => word.Word.IsKnown == false)
                                .Count();
        }
    }
}
