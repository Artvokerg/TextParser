using System.Text.RegularExpressions;
using TextParser.DAO;

namespace TextParser.Controllers
{
    internal class EngTextParsController
    {
        private FileController m_fileController;
        private IEngWordsDao m_engWordsDao;

        public EngTextParsController(FileController fileController, IEngWordsDao engWordsDao)
        {
            m_fileController = fileController;
            m_engWordsDao = engWordsDao;
        }

        public void GenerateFileEngWordsAndCount(string path)
        {
            var lines = m_engWordsDao.GetEngWordsOrderByCountInText()
                .Select((word) => word.Word + ";" + word.CountInText.ToString());

            m_fileController.WriteLinesToFile(path, lines);
        }

        public void GenerateFileOnlyEngWords(string path)
        {
            var lines = m_engWordsDao.GetEngWordsOrderByCountInText()
                .Select((word) => word.Word);

            m_fileController.WriteLinesToFile(path, lines);
        }

        public void ReadFileAndSetEngWordsToModel(string path)
        {
            var allLines = m_fileController.GetAllLinesFromFile(path);
            Dictionary<string, int> engWords = ParseEngWords(allLines);
            m_engWordsDao.SetEngWords(engWords);
        }

        public void ReadGeneratedFileAndSetEngWordsToModel(string path)
        {
            IEnumerable<string> allLines = m_fileController.GetAllLinesFromFile(path);

            HashSet<EngWord> engWords = new HashSet<EngWord>();
            foreach (string line in allLines)
            {
                EngWord engWord = new EngWord();

                engWord.Word = line.Split(";")[0];
                engWord.CountInText = int.Parse(line.Split(";")[1]);

                engWords.Add(engWord);
            }

            m_engWordsDao.SetEngWords(engWords);
        }

        public HashSet<EngWord> GetAllEngWords()
        {
            return m_engWordsDao.GetEngWords();
        }

        private Dictionary<string, int> ParseEngWords(IEnumerable<string> lines)
        {
            Dictionary<string, int> engWords = new Dictionary<string, int>();

            foreach (string line in lines)
            {
                string pattern = @"([a-zA-Z]`?'?)+";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(line);

                while (match.Success)
                {
                    string word = match.Groups[0].Value.ToLower();

                    AddWordToDictionary(engWords, word);

                    match = match.NextMatch();
                }
            }

            return engWords;
        }

        private void AddWordToDictionary(Dictionary<string, int> dictionary, string word)
        {
            if (dictionary.TryGetValue(word, out int count))
            {
                dictionary[word] = count + 1;
            }
            else
            {
                dictionary[word] = 1;
            }
        }
    }
}
