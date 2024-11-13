using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.DAO;
using TextParser.Models;

namespace TextParser.Controllers
{
    internal class WordsController
    {
        private WordsDao m_wordsDao;
        Dictionary<string, string> m_allEngWords;


        private const string WORDS_FILE_PATH = @"words_data\words_storage.txt";
        private const string ALL_ENG_WORDS_FILE_PATH = @"words_data\all_eng_words.txt";



        public WordsController()
        {
            m_wordsDao = new WordsDao();
            ReadWordsFromFile();
            m_allEngWords = GetAllWords();

        }

        private Dictionary<string, string> GetAllWords()
        {
            Dictionary<string, string> allWords = new Dictionary<string, string>();
            List<string> lines = FileController.GetAllLinesFromFile(ALL_ENG_WORDS_FILE_PATH).ToList();

            for (int i = 0; i < lines.Count(); i += 2)
            {
                allWords.Add(lines.ElementAt(i), lines.ElementAt(i + 1));
            }

            return allWords;
        }

        public void ReadWordsFromFile()
        {
            List<Word> words = new List<Word>();
            if (FileController.FileExist(WORDS_FILE_PATH))
            {
                IEnumerable<string> lines = FileController.GetAllLinesFromFile(WORDS_FILE_PATH);

                foreach(string line in lines)
                {
                    Word word = new Word();

                    word.EngWord = line.Split("|")[0];
                    word.RusWord = line.Split("|")[1];
                    word.IsKnown = bool.Parse(line.Split("|")[2]);

                    words.Add(word);
                }
            }

            m_wordsDao.SetWords(words);
        }

        public void SetWords(List<Word> words)
        {
            m_wordsDao.SetWords(words);
        }
        
        public void SaveToFile()
        {
            List<string> lines = new List<string>();
            List<Word> words = m_wordsDao.GetWords();

            foreach (Word word in words)
            {
                lines.Add($"{word.EngWord}|{word.RusWord}|{word.IsKnown}");
                //lines.Add(word.RusWord);
                //lines.Add(word.IsKnown.ToString());
            }

            FileController.WriteLinesToFile(WORDS_FILE_PATH, lines);
        }

        public string GetRusWord(string engWord)
        {
            return m_wordsDao.GetRusWord(engWord);
        }

        public Word GetWord(string engWord)
        {
            return m_wordsDao.GetWord(engWord);
        }

        public void SetKnownWordValue(string engWord, bool isknown)
        {
            m_wordsDao.SetKnownWordValue(engWord, isknown);
        }

        public List<string> GetUnstoragedWords(List<string> words)
        {
            List<string> unstoragedWords = new List<string>();

            foreach (string word in words)
            {
                if (!m_wordsDao.HaveWord(word))
                {
                    unstoragedWords.Add(word);
                }
            }

            return unstoragedWords;
        }

        public void AddWord(Word word)
        {
            m_wordsDao.AddWord(word);
        }

        public int GetAllWordsCount()
        {
            return m_allEngWords.Count();
        }

        public int GetKnownWordsCount()
        {
            return m_wordsDao.GetKnownWords()
                             .Where(x => m_allEngWords.ContainsKey(x))
                             .Count();
        }
    }
}
