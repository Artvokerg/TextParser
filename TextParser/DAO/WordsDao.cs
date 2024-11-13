using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.Models;

namespace TextParser.DAO
{
    internal class WordsDao
    {
        private List<Word> m_words;

        public WordsDao()
        {
            
        }

        public void SetWords(List<Word> words)
        {
            m_words = words;
        }

        public List<Word> GetWords()
        {
            return m_words;
        }

        public string GetRusWord(string engWord)
        {
            return m_words.Where(x => x.EngWord == engWord)
                          .FirstOrDefault()
                          .RusWord;
        }

        public Word GetWord(string engWord)
        {
            return m_words.Where(x => x.EngWord == engWord)
                          .FirstOrDefault();
        }

        public void SetKnownWordValue(string engWord, bool isknown)
        {
            m_words.Where(x => x.EngWord == engWord)
                   .FirstOrDefault()
                   .IsKnown = isknown;
        }

        public bool HaveWord(string engWord)
        {
            return m_words.Where(x => x.EngWord == engWord)
                          .Any();
        }

        public void AddWord(Word word)
        {
            m_words.Add(word);
        }

        public int GetAllWordsCount()
        {
            return m_words.Count;
        }

        public int GetKnownWordsCount()
        {
            return m_words.Where(x => x.IsKnown)
                          .Count();
        }

        public List<string> GetKnownWords()
        {
            return m_words.Where(x => x.IsKnown)
                          .Select(x => x.EngWord)
                          .ToList();
        }
    }
}
