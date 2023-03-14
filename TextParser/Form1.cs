using TextParser.Controllers;
using TextParser.Forms;

namespace TextParser
{
    public partial class Form1 : Form
    {
        private EngTextParsController m_engTextParsController;
        private TranslatedWordsController m_translatedWordsController;
        private ShowWordsMediator m_showWordsMediator;

        public Form1()
        {
            InitializeComponent();

            FileController fileController = new FileController();
            EngWordsModel engWordsModel = new EngWordsModel();
            m_engTextParsController = new EngTextParsController(fileController, engWordsModel);
            m_translatedWordsController = new TranslatedWordsController(fileController, null, engWordsModel);
            m_showWordsMediator = new ShowWordsMediator(labelCountInText, labelTranslatedWord, labelEngWord, m_translatedWordsController);
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

            m_translatedWordsController.GetOnlyTranslatedWordsFromFile(openFileDialog.FileName);
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

            m_translatedWordsController.ReadTranslatedWordsFromFile(openFileDialog.FileName);
        }

        private void buttonWriteEngTranslatedToFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            m_translatedWordsController.WriteTranslatedWordsToFile(saveFileDialog.FileName);
        }
    }
}