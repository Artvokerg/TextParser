using TextParser.DAO;
using TextParser.Models;

namespace TextParser.Controllers
{
    internal class EngTranslatedPairsController
    {
        private IEngTranslatedPairsDao m_engTranslatedPairsDao;
        private FileController m_fileController;
        private IEngWordsDao m_engWordsDao;

        public EngTranslatedPairsController(FileController fileController, IEngTranslatedPairsDao engTranslatedPairsDao, IEngWordsDao engWordsModel)
        {
            m_fileController = fileController;
            m_engTranslatedPairsDao = engTranslatedPairsDao;
            m_engWordsDao = engWordsModel;
        }

        public void GetOnlyTranslatedWordsFromFile(string path)
        {
            HashSet<EngTranslatedPair> engTranslatedPairs = new HashSet<EngTranslatedPair>();

            IEnumerable<string> allLines = m_fileController.GetAllLinesFromFile(path);
            IEnumerable<EngWord> engWords = m_engWordsDao.GetEngWordsOrderByCountInText();

            for (int i = 0; i < engWords.Count(); i++)
            {
                EngTranslatedPair engTranslatedPair = new EngTranslatedPair();
                engTranslatedPair.engWord = engWords.ElementAt(i);
                engTranslatedPair.translatedWord = allLines.ElementAt(i);

                engTranslatedPairs.Add(engTranslatedPair);
            }

            m_engTranslatedPairsDao.SetEngTranslatedPairs(engTranslatedPairs);
        }

        public void WriteEngTranslatedPairsToFile(string path)
        {
            HashSet<EngTranslatedPair> engTranslatedPairs = m_engTranslatedPairsDao.GetEngTranslatedPairs();
            List<string> lines = new List<string>();

            foreach (EngTranslatedPair engTranslatedPair in engTranslatedPairs)
            {
                lines.Add(engTranslatedPair.engWord.Word);
                lines.Add(engTranslatedPair.translatedWord);
                lines.Add(engTranslatedPair.engWord.CountInText.ToString());
                lines.Add(engTranslatedPair.engWord.IsKnown.ToString());
            }

            m_fileController.WriteLinesToFile(path, lines);
        }

        public void ReadEngTranslatedPairsFromFile(string path)
        {
            HashSet<EngTranslatedPair> engTranslatedPairs = new HashSet<EngTranslatedPair>();
            IEnumerable<string> lines = m_fileController.GetAllLinesFromFile(path);
            
            for (int i = 0; i < lines.Count(); i += 4)
            {
                EngWord engWord = new();
                string translatedWord;

                engWord.Word = lines.ElementAt(i);
                translatedWord = lines.ElementAt(i + 1);
                engWord.CountInText = int.Parse(lines.ElementAt(i + 2));
                engWord.IsKnown = bool.Parse(lines.ElementAt(i + 3));

                engTranslatedPairs.Add(new EngTranslatedPair(engWord, translatedWord));
            }

            m_engTranslatedPairsDao.SetEngTranslatedPairs(engTranslatedPairs);
        }

        //todo дописать метод если он нужен
        /*public int GetLastKnownWordIndex(bool onlyUnknown)
        {
            HashSet<EngTranslatedPair> engTranslatedPairs = m_engTranslatedPairsDao.GetEngTranslatedPairs();
            int lastKnownWordIndex = 0;
            string lastKnownWord;

            for (int i = 0;i < GetEngTranslatedPairsCount(); i++)
            {
                EngTranslatedPair wordsPair = GetEngTranslatedPair(i);
                if (wordsPair.engWord.IsKnown)
                {
                    lastKnownWordIndex = i;
                    lastKnownWord = wordsPair.engWord.Word;
                }
            }

            if (!onlyUnknown)
            {
                return lastKnownWordIndex;
            }

            for (int i = 0; i < GetEngTranslatedPairsCount(onlyUnknown); i++)
            {
                EngTranslatedPair wordsPair = GetEngTranslatedPair(i, onlyUnknown);
                if (wordsPair.engWord.Word == lastKnownWord)
                {
                    lastKnownWordIndex = i;
                    lastKnownWord = wordsPair.engWord.Word;
                }
            }
        }*/
        public EngTranslatedPair GetEngTranslatedPair(int index)
        {
            return m_engTranslatedPairsDao.GetEngTranslatedPairs().ElementAt(index);
        }

        public EngTranslatedPair GetOnlyUnknownEngTranslatedPair(int index)
        {
            return m_engTranslatedPairsDao.GetOnlyUnknownEngTranslatedPairs().ElementAt(index);
        }

        public void IsKnownValueWasChanged(int index, bool isknown)
        {
            m_engTranslatedPairsDao.GetEngTranslatedPairs().ElementAt(index).engWord.IsKnown = isknown;
        }

        public void IsKnownValueWasChanged(string wordKey, bool isknown)
        {
            m_engTranslatedPairsDao.SetKnownWordValue(wordKey, isknown);
        }

        public int GetEngTranslatedPairsCount(bool onlyUnknown)
        {
            if (onlyUnknown)
            {
                return m_engTranslatedPairsDao.GetOnlyUnknownEngTranslatedPairs().Count();
            }

            return m_engTranslatedPairsDao.GetEngTranslatedPairs().Count();
        }

        public int GetEngTranslatedPairsCount()
        {
            return m_engTranslatedPairsDao.GetEngTranslatedPairs().Count();
        }

        public int GetOnlyUnknownEngTranslatedPairsCount()
        {
            return m_engTranslatedPairsDao.GetOnlyUnknownEngTranslatedPairs().Count();
        }
    }
}
