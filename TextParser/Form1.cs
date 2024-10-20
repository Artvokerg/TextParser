using TextParser.Controllers;
using TextParser.DAO;
using TextParser.Forms;

namespace TextParser
{
    public partial class Form1 : Form
    {
        private EngTextParsController m_engTextParsController;
        private EngTranslatedPairsController m_engTranslatedPairsController;
        private ShowWordsMediator m_showWordsMediator;

        public Form1()
        {
            InitializeComponent();

            FileController fileController = new FileController();
            IEngWordsDao engWordsDao = new EngWordsDao();
            IEngTranslatedPairsDao engTranslatedPairsDao = new EngTranslatedPairsDao();

            m_engTextParsController = new EngTextParsController(fileController, engWordsDao);
            m_engTranslatedPairsController = new EngTranslatedPairsController(fileController, engTranslatedPairsDao, engWordsDao);
            m_showWordsMediator = new ShowWordsMediator(labelCountInText, labelTranslatedWord, labelEngWord, m_engTranslatedPairsController, checkBoxIsKnownWord, labelCurrentIndex);
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTextParsController.ReadFileAndSetEngWordsToModel(openFileDialog.FileName);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void createFileEngWordsButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTextParsController.GenerateFileEngWordsAndCount(saveFileDialog.FileName);
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
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTextParsController.ReadGeneratedFileAndSetEngWordsToModel(openFileDialog.FileName);
        }

        private void GetRusWordsButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTranslatedPairsController.GetOnlyTranslatedWordsFromFile(openFileDialog.FileName);
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
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTranslatedPairsController.ReadEngTranslatedPairsFromFile(openFileDialog.FileName);
        }

        private void buttonWriteEngTranslatedToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_engTranslatedPairsController.WriteEngTranslatedPairsToFile(saveFileDialog.FileName);
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
            m_showWordsMediator.KeyUp(e.KeyData);
        }

        private void buttonToLastUnknown_Click(object sender, EventArgs e)
        {
            m_showWordsMediator.ShowLastUnknownWord();
        }
    }
}