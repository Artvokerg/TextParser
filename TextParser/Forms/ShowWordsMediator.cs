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
        private Label knownWordsCountLabel;


        private int m_currentWordIndex = 0;

        private bool m_showOnlyUnknownWords = true;

        private WordsInFileController m_wordsInFileController;
        private WordsController m_wordsController;


        Button saveFileOnlyEngWordsButton;

        public ShowWordsMediator(Label labelCountInText,
            Label labelTranslatedWord,
            Label labelEngWord,
            WordsInFileController wordsInFileController,
            CheckBox checkBoxIsKnownWord,
            Label labelCurrentIndex,
            Button saveFileOnlyEngWordsButton,
            Label knownWordsCountLabel,
            WordsController wordsController)
        {
            this.labelCountInText = labelCountInText;
            this.labelTranslatedWord = labelTranslatedWord;
            this.labelEngWord = labelEngWord;
            this.checkBoxIsKnownWord = checkBoxIsKnownWord;
            this.labelCurrentIndex = labelCurrentIndex;
            this.saveFileOnlyEngWordsButton = saveFileOnlyEngWordsButton;
            m_wordsInFileController = wordsInFileController;
            this.knownWordsCountLabel = knownWordsCountLabel;
            m_wordsController = wordsController;
        }

        public void GetNextWord()
        {
            if (m_currentWordIndex + 1 < this.WordsInFileCount())
            {
                m_currentWordIndex++;
                SetCurrentValues();
            }            
        }

        public void GetPrevWord()
        {
            if (m_currentWordIndex > 0 )
            {
                m_currentWordIndex--;
                SetCurrentValues();
            }            
        }

        public void CheckBoxIsKnownWordChanged()
        {
            
            m_wordsInFileController.SetKnownWordValue(this.labelEngWord.Text, checkBoxIsKnownWord.Checked);
            SetNextWordAfterCheckBoxIsKnownChanged();
            // GetPrevWord();
        }

        private void SetNextWordAfterCheckBoxIsKnownChanged()
        {
            if (m_currentWordIndex == WordsInFileCount())
            {
                m_currentWordIndex--;
            }

            SetCurrentValues();
        }

        public void SetStartPosition()
        {
            m_currentWordIndex = 0;
            SetCurrentValues();
        }

        private void SetCurrentValues()
        {
            WordInFile wordInFile = GetWordInFile();

            string SPOILER_WORD = "********";
            int currentWordIndex = m_currentWordIndex + 1;

            this.labelEngWord.Text = wordInFile.Word.EngWord;
            this.labelTranslatedWord.Text = SPOILER_WORD;
            this.labelCountInText.Text = wordInFile.CountInFile.ToString();
            labelCurrentIndex.Text = $"{currentWordIndex} / {WordsInFileCount()}";
            checkBoxIsKnownWord.Checked = wordInFile.Word.IsKnown;

            knownWordsCountLabel.Text = $"Слов изучено: {m_wordsController.GetKnownWordsCount()}/{m_wordsController.GetAllWordsCount()}";
        }

        public void RemoveSpoiler()
        {
            WordInFile wordInFile = GetWordInFile();

            this.labelTranslatedWord.Text = wordInFile.Word.RusWord;
        }


        private int WordsInFileCount()
        {
            if (this.m_showOnlyUnknownWords)
            {
                return m_wordsInFileController.GetOnlyUnknownWordsInFileCount();
            }

            return m_wordsInFileController.GetWordsInFileCount();
        }


        private WordInFile GetWordInFile()
        {
            if (m_showOnlyUnknownWords)
            {
                return m_wordsInFileController.GetOnlyUnknownWordInFile(m_currentWordIndex);
            }

            return m_wordsInFileController.GetWordInFile(m_currentWordIndex);
        }

        public void ShouldShowOnlyUnknownWords(bool showOnlyUnknownWords)
        {
            this.m_showOnlyUnknownWords = showOnlyUnknownWords;
            this.m_currentWordIndex = 0;
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
                case Keys.NumPad1:
                    GetPrevWord();
                    break;
                case Keys.NumPad3:
                    GetNextWord();
                    break;
                case Keys.ControlKey:
                    checkBoxIsKnownWord.Checked = !checkBoxIsKnownWord.Checked;
                    CheckBoxIsKnownWordChanged();
                    break;
            }
        }

        public void ShowLastUnknownWord()
        {

        }

        public void SetEnableOriginFileButton()
        {
            saveFileOnlyEngWordsButton.Enabled = true;
        }
    }
}
