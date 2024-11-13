using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.DAO;
using TextParser.Models;

namespace TextParser.Controllers
{
    internal class WordsInFileController
    {
        private WordsInFileDao m_wordsInFileDao;
        private WordsController m_wordsController;
        private List<string> m_films = new List<string>();

        private const string WORDS_FILE_PATH = @"words_data\films\";

        public WordsInFileController(WordsController wordsController)
        {
            m_wordsInFileDao = new WordsInFileDao();
            m_wordsController = wordsController;
            m_films = FileController.GetFiles(WORDS_FILE_PATH);
        }

        public void ReadWordsInFile(int fileNameIndex)
        {
            string filePath = m_films.ElementAt(fileNameIndex);
            IEnumerable<string> lines = FileController.GetAllLinesFromFile(WORDS_FILE_PATH + filePath);
            List<WordInFile> wordsInFile = new List<WordInFile>();

            foreach (string line in lines)
            {
                WordInFile wordInFile = new WordInFile();

                string engWord = line.Split("|")[1];

                Word word = m_wordsController.GetWord(engWord);

                wordInFile.CountInFile = int.Parse(line.Split('|')[0]);
                wordInFile.Word = word;

                wordsInFile.Add(wordInFile);
            }

            m_wordsInFileDao.SetWords(wordsInFile);
        }

        public void SaveWordsInFile(string fileName)
        {
            List<WordInFile> wordsInFile = m_wordsInFileDao.GetWordsInFile();

            List<string> lines = new List<string>();

            foreach (WordInFile wordInFile in wordsInFile)
            {
                lines.Add($"{wordInFile.CountInFile}|{wordInFile.Word.EngWord}");
            }

            FileController.WriteLinesToFile(WORDS_FILE_PATH + fileName, lines);
        }

        public void SetNewWordsInFile(List<WordInFile> wordsInFile, string path)
        {
            m_wordsInFileDao.SetWords(wordsInFile);
            SaveWordsInFile(path);
        }

        public string[] GetFileNames()
        {
            return m_films.ToArray();
        }

        public WordInFile GetWordInFile(int index)
        {
            return m_wordsInFileDao.GetWordInFile(index);
        }

        public WordInFile GetOnlyUnknownWordInFile(int index)
        {
            return m_wordsInFileDao.GetOnlyUnknownWordInFile(index);
        }

        public void SetKnownWordValue(string wordKey, bool isknown)
        {
            m_wordsController.SetKnownWordValue(wordKey, isknown);
        }

        public int GetWordsInFileCount()
        {
            return m_wordsInFileDao.GetWordsInFileCount();
        }

        public int GetOnlyUnknownWordsInFileCount()
        {
            return m_wordsInFileDao.GetOnlyUnknownWordsInFileCount();
        }

        public List<WordInFile> GetWordsInFile()
        {
            return m_wordsInFileDao.GetWordsInFile();
        }
    }
}
