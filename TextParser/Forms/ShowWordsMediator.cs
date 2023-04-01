using TextParser.Controllers;
using TextParser.Models;

namespace TextParser.Forms
{
    internal class ShowWordsMediator
    {
        private Label labelCountInText;
        private Label labelTranslatedWord;
        private Label labelEngWord;
        private Label labelCurrentIndex;
        private CheckBox checkBoxIsKnownWord;

        private int currentWordIndex = 0;

        private bool showOnlyUnknownWords = true;

        private EngTranslatedPairsController m_engTranslatedPairsController;

        public ShowWordsMediator(Label labelCountInText,
            Label labelTranslatedWord,
            Label labelEngWord,
            EngTranslatedPairsController engTranslatedPairsController,
            CheckBox checkBoxIsKnownWord,
            Label labelCurrentIndex)
        {
            this.labelCountInText = labelCountInText;
            this.labelTranslatedWord = labelTranslatedWord;
            this.labelEngWord = labelEngWord;
            this.m_engTranslatedPairsController = engTranslatedPairsController;
            this.checkBoxIsKnownWord = checkBoxIsKnownWord;
            this.labelCurrentIndex = labelCurrentIndex;
        }

        public void GetNextWord()
        {
            if (currentWordIndex + 1 < this.EngTranslatedPairCount())
            {
                currentWordIndex++;
                SetCurrentValues();
            }            
        }

        public void GetPrevWord()
        {
            if (currentWordIndex > 0 )
            {
                currentWordIndex--;
                SetCurrentValues();
            }            
        }

        public void CheckBoxIsKnownWordChanged()
        {
            m_engTranslatedPairsController.IsKnownValueWasChanged(this.labelEngWord.Text, checkBoxIsKnownWord.Checked);
            SetCurrentValues();
            // GetPrevWord();
        }

        private void SetCurrentValues()
        {
            EngTranslatedPair engTranslatedPair = GetCurrentEngTranslatedPair();

            this.labelEngWord.Text = engTranslatedPair.engWord.Word;
            this.labelTranslatedWord.Text = engTranslatedPair.translatedWord;
            this.labelCountInText.Text = engTranslatedPair.engWord.CountInText.ToString();
            labelCurrentIndex.Text = currentWordIndex.ToString() + "/" + EngTranslatedPairCount().ToString();
            checkBoxIsKnownWord.Checked = engTranslatedPair.engWord.IsKnown;
        }

        private int EngTranslatedPairCount()
        {
            if (this.showOnlyUnknownWords)
            {
                return m_engTranslatedPairsController.GetOnlyUnknownEngTranslatedPairsCount();
            }

            return m_engTranslatedPairsController.GetEngTranslatedPairsCount();
        }


        private EngTranslatedPair GetCurrentEngTranslatedPair()
        {
            if (showOnlyUnknownWords)
            {
                return m_engTranslatedPairsController.GetOnlyUnknownEngTranslatedPair(currentWordIndex);
            }

            return m_engTranslatedPairsController.GetEngTranslatedPair(currentWordIndex);
        }

        public void ShouldShowOnlyUnknownWords(bool showOnlyUnknownWords)
        {
            this.showOnlyUnknownWords = showOnlyUnknownWords;
            this.currentWordIndex = 0;
            SetCurrentValues();
        }

        public void KeyDown(Keys key)
        {
            switch (key)
            {
                case Keys.D1:
                    GetPrevWord();
                    break;
                case Keys.D3:
                    GetNextWord();
                    break;
            }
        }

        public void KeyUp(Keys key)
        {
            switch (key)
            {
                case Keys.F:
                    GetNextWord();
                    break;
                case Keys.Space:
                    checkBoxIsKnownWord.Checked = !checkBoxIsKnownWord.Checked;
                    CheckBoxIsKnownWordChanged();
                    break;
            }
        }
    }
}
