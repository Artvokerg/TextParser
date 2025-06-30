using System.IO;
using System.Text.RegularExpressions;
using TextParser.DAO;
using TextParser.Models;

namespace TextParser.Controllers
{
    internal class EngTextParsController
    {
        private WordsController m_wordsController;
        private WordsInFileController m_wordsInFileController;

        private Dictionary<string, int> m_wordsInFile;
        private List<string> m_unstoragedWordsToBeGetFromAllWords;
        private List<string> m_unstoragedWordsToBeTranslated;
        Dictionary<string, string> m_allEngWords;

        private const string ALL_ENG_WORDS_FILE_PATH = @"words_data\all_eng_words.txt";



        public EngTextParsController(WordsController wordsController, WordsInFileController wordsInFileController)
        {
            m_wordsController = wordsController;
            m_wordsInFileController = wordsInFileController;
            m_allEngWords = GetAllWords();
        }
        public void GenerateFileOnlyEngWords(string path)
        {
            FileController.WriteLinesToFile(path, m_unstoragedWordsToBeTranslated);
        }

        public void ReadFileAndSetEngWordsToModel(string path)
        {
            var lines = FileController.GetAllLinesFromFile(path);
            m_wordsInFile = ParseEngWords(lines);
            InitUnstoragedWords();
        }

        private void InitUnstoragedWords()
        {
            List<string> engWordsInFile = m_wordsInFile.Keys.ToList();

            m_unstoragedWordsToBeTranslated = m_wordsController.GetUnstoragedWords(engWordsInFile)
                                                               .Where(x => !AllWordsContains(x))
                                                               .ToList();

            m_unstoragedWordsToBeGetFromAllWords = m_wordsController.GetUnstoragedWords(engWordsInFile)
                                                               .Where(x => AllWordsContains(x))
                                                               .ToList();
        }

        private bool AllWordsContains(string word)
        {
            return AllWordsTryGetValue(word, out _);
        }
        private bool AllWordsTryGetValue(string engWord, out string rusWord)
        {
            if (m_allEngWords.TryGetValue(engWord, out rusWord) ||
                m_allEngWords.TryGetValue(engWord.Substring(0, engWord.Length - 1), out rusWord))
            {
                rusWord = rusWord.Replace('|', '/')
                                 .Replace('\t', ' ');
                return true;
            }

            return false;
        }

        private string AllWordsGetValue(string engWord)
        {
            if (AllWordsTryGetValue(engWord, out string rusWord))
            {
                return rusWord;
            }

            throw new Exception("Can`t get value from Dictionary");
        }

        public bool HaveUnstoragedWords()
        {
            return m_unstoragedWordsToBeGetFromAllWords.Count + m_unstoragedWordsToBeTranslated.Count > 0;
        }

        public void SetRusWordsFromFile(string path, string pathToNewWordsInFile)
        {            
            List<WordInFile> wordsInFile = new List<WordInFile>();
            Dictionary<string, string> allEngWords = GetAllWords();

            List<string> wordsWithPostfix = new List<string>();
            List<string> unfindedWords = new List<string>();


            foreach (string unstorageWord in m_unstoragedWordsToBeGetFromAllWords)
            {
                Word word = new Word();

                word.EngWord = unstorageWord;

                string rusWord = AllWordsGetValue(unstorageWord);

                word.RusWord = rusWord;

                word.IsKnown = false;

                WordInFile wordInFile = new WordInFile();
                wordInFile.Word = word;
                wordInFile.CountInFile = m_wordsInFile[word.EngWord];

                m_wordsController.AddWord(word);
                wordsInFile.Add(wordInFile);
            }

            var lines = FileController.GetAllLinesFromFile(path);

            for (int i = 0; i < lines.Count(); i++)
            {
                Word word = new Word();

                word.EngWord = m_unstoragedWordsToBeTranslated.ElementAt(i);
                word.RusWord = lines.ElementAt(i);
                word.IsKnown = false;

                WordInFile wordInFile = new WordInFile();
                wordInFile.Word = word;
                wordInFile.CountInFile = m_wordsInFile[word.EngWord];

                m_wordsController.AddWord(word);
                wordsInFile.Add(wordInFile);
            }

            foreach(KeyValuePair<string, int> allWordInFile in m_wordsInFile)
            {
                if (!wordsInFile.Any(word => word.Word.EngWord == allWordInFile.Key))
                {
                    WordInFile wordInFile = new WordInFile();
                    wordInFile.Word = m_wordsController.GetWord(allWordInFile.Key);
                    wordInFile.CountInFile = allWordInFile.Value;

                    wordsInFile.Add(wordInFile);
                }
            }



            m_wordsController.SaveToFile();
            m_wordsInFileController.SetNewWordsInFile(wordsInFile, pathToNewWordsInFile);

        }

        public void SaveUnstoragedWordsInFile(string pathToNewWordsInFile)
        {
            List<WordInFile> wordsInFile = new List<WordInFile>();

            foreach (KeyValuePair<string, int> allWordInFile in m_wordsInFile)
            {
                if (!wordsInFile.Any(word => word.Word.EngWord == allWordInFile.Key))
                {
                    WordInFile wordInFile = new WordInFile();
                    wordInFile.Word = m_wordsController.GetWord(allWordInFile.Key);
                    wordInFile.CountInFile = allWordInFile.Value;

                    wordsInFile.Add(wordInFile);
                }
            }

            m_wordsInFileController.SetNewWordsInFile(wordsInFile, pathToNewWordsInFile);
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
