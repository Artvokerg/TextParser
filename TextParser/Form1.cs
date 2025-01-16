using TextParser.Controllers;
using TextParser.DAO;
using TextParser.Forms;

namespace TextParser
{
    public partial class Form1 : Form
    {
        private EngTextParsController m_engTextParsController;
        private ShowWordsMediator m_showWordsMediator;
        private WordsController m_wordsController;
        private WordsInFileController m_wordsInFileController;

        public Form1()
        {
            InitializeComponent();

            m_wordsController = new WordsController();
            m_wordsInFileController = new WordsInFileController(m_wordsController);

            m_engTextParsController = new EngTextParsController(m_wordsController, m_wordsInFileController);
            m_showWordsMediator = new ShowWordsMediator(labelCountInText, labelTranslatedWord, labelEngWord, m_wordsInFileController, checkBoxIsKnownWord, labelCurrentIndex, saveFileOnlyEngWordsButton, knownWordsCountLabel, m_wordsController);

            saveFileOnlyEngWordsButton.Enabled = false;


            string[] fileNames = m_wordsInFileController.GetFileNames();
            filmsComboBox.Items.Clear();
            filmsComboBox.Items.AddRange(fileNames);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTextParsController.ReadFileAndSetEngWordsToModel(openFileDialog.FileName);
            m_showWordsMediator.SetEnableOriginFileButton();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createFileEngWordsButton_Click(object sender, EventArgs e)
        {
        }

        private void saveFileOnlyEngWordsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTextParsController.GenerateFileOnlyEngWords(saveFileDialog.FileName);
        }

        private void SetEngTextFileButton_Click(object sender, EventArgs e)
        {
        }

        private void GetRusWordsButton_Click(object sender, EventArgs e)
        {
        }

        private void buttonPrevWord_Click(object sender, EventArgs e)
        {
            m_showWordsMediator.GetPrevWord();
        }

        private void buttonNextWord_Click(object sender, EventArgs e)
        {
            m_showWordsMediator.GetNextWord();
        }

        private void buttonreadEngTranslatedFromFile_Click(object sender, EventArgs e)
        {

        }

        private void buttonWriteEngTranslatedToFile_Click(object sender, EventArgs e)
        {
        }

        private void checkBoxIsKnownWord_CheckedChanged(object sender, EventArgs e)
        {
            m_showWordsMediator.CheckBoxIsKnownWordChanged();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            m_showWordsMediator.KeyDown(e.KeyData);
        }

        private void checkBoxShowOnlyUnknownWords_Click(object sender, EventArgs e)
        {
            m_showWordsMediator.ShouldShowOnlyUnknownWords(checkBoxShowOnlyUnknownWords.Checked);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                m_showWordsMediator.KeyUp(e.KeyData);

            }
        }

        private void buttonToLastUnknown_Click(object sender, EventArgs e)
        {
            m_showWordsMediator.ShowLastUnknownWord();
        }

        private void filmsComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nameFileIndex = filmsComboBox.SelectedIndex;
            m_wordsInFileController.ReadWordsInFile(nameFileIndex);
            m_showWordsMediator.SetStartPosition();
        }

        private void labelTranslatedWord_MouseMove(object sender, MouseEventArgs e)
        {
            m_showWordsMediator.RemoveSpoiler();
        }

        private void saveAllWordsButton_Click(object sender, EventArgs e)
        {
            m_wordsController.SaveToFile();
        }

        private void WordsInFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            addNewWordsButton.Enabled = !String.IsNullOrEmpty(WordsInFileNameTextBox.Text);
        }

        private void addNewWordsButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTextParsController.SetRusWordsFromFile(openFileDialog.FileName, WordsInFileNameTextBox.Text);
        }

        private void labelEngWord_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(labelEngWord.Text))
            {
                Clipboard.SetText(labelEngWord.Text);
            }
        }
    }
}