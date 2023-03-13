using TextParser.Models;

namespace TextParser.Controllers
{
    internal class TranslatedWordsController
    {
        private TranslatedWordsModel m_translatedWordsModel;
        private FileController m_fileController;
        private EngWordsModel m_engWordsModel;

        public TranslatedWordsController(FileController fileController = null, TranslatedWordsModel translatedWordsModel = null, EngWordsModel engWordsModel = null)
        {
            m_fileController = fileController ?? new FileController();
            m_translatedWordsModel = translatedWordsModel ?? new TranslatedWordsModel();
            m_engWordsModel = engWordsModel ?? new EngWordsModel();
        }

        public void GetOnlyTranslatedWordsFromFile(string path)
        {
            Dictionary<EngWord, string> translatedWords = new Dictionary<EngWord, string>();

            IEnumerable<string> allLines = m_fileController.GetAllLinesFromFile(path);
            IEnumerable<EngWord> engWords = m_engWordsModel.GetEngWordsOrderByCountInText();

            for (int i = 0; i < engWords.Count(); i++)
            {
                translatedWords.Add(engWords.ElementAt(i), allLines.ElementAt(i));
            }

            m_translatedWordsModel.SetTranslatedWords(translatedWords);
        }

        public void WriteTranslatedWordsToFile(string path)
        {
            Dictionary<EngWord, string> translatedWords = m_translatedWordsModel.GetTranslatedWords();
            List<string> lines = new List<string>();

            foreach (KeyValuePair<EngWord, string> translatedWord in translatedWords)
            {
                lines.Add(translatedWord.Key.Word);
                lines.Add(translatedWord.Value);
                lines.Add(translatedWord.Key.CountInText.ToString());
                lines.Add(translatedWord.Key.IsKnown.ToString());
            }

            m_fileController.WriteLinesToFile(path, lines);
        }

        public void ReadTranslatedWordsFromFile(string path)
        {
            Dictionary<EngWord, string> translatedWords = new();
            IEnumerable<string> lines = m_fileController.GetAllLinesFromFile(path);

            foreach(string line in lines)
            {
                EngWord engWord = new EngWord();
                engWord.Word = line;
            }
        }

        public KeyValuePair<EngWord, string> GetTranslatedWord(int index)
        {
            return m_translatedWordsModel.GetTranslatedWords().ElementAt(index);
        }
    }
}
