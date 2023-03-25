using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextParser.Controllers;
using TextParser.Models;

namespace TextParser.Forms
{
    internal class ShowWordsMediator
    {
        private Label labelCountInText;
        private Label labelTranslatedWord;
        private Label labelEngWord;

        private int currentWordIndex = 0;

        private EngTranslatedPairsController m_translatedWordsController;

        public ShowWordsMediator(Label labelCountInText, Label labelTranslatedWord, Label labelEngWord, EngTranslatedPairsController translatedWordsController)
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
            EngTranslatedPair engTranslatedPair = m_translatedWordsController.GetEngTranslatedPairs(currentWordIndex);

            this.labelEngWord.Text = engTranslatedPair.engWord.Word;
            this.labelTranslatedWord.Text = engTranslatedPair.translatedWord;
            this.labelCountInText.Text = engTranslatedPair.engWord.CountInText.ToString();
        }
    }
}
