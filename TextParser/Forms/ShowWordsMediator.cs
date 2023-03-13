using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.Controllers;

namespace TextParser.Forms
{
    internal class ShowWordsMediator
    {
        private Label labelCountInText;
        private Label labelTranslatedWord;
        private Label labelEngWord;

        private int currentWordIndex = 0;

        private TranslatedWordsController m_translatedWordsController;

        public ShowWordsMediator(Label labelCountInText, Label labelTranslatedWord, Label labelEngWord, TranslatedWordsController translatedWordsController)
        {
            this.labelCountInText = labelCountInText;
            this.labelTranslatedWord = labelTranslatedWord;
            this.labelEngWord = labelEngWord;
            this.m_translatedWordsController = translatedWordsController;
        }

        public void GetNextWord()
        {
            currentWordIndex++;
            SetCurrentValues();
        }

        public void GetPrevWord()
        {
            currentWordIndex--;
            SetCurrentValues();
        }

        private void SetCurrentValues()
        {
            KeyValuePair<EngWord, string> translatedWord = m_translatedWordsController.GetTranslatedWord(currentWordIndex);

            this.labelEngWord.Text = translatedWord.Key.Word;
            this.labelTranslatedWord.Text = translatedWord.Value;
            this.labelCountInText.Text = translatedWord.Key.CountInText.ToString();
        }
    }
}
