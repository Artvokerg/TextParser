namespace TextParser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            openFileDialog = new OpenFileDialog();
            saveAllWordsButton = new Button();
            saveFileDialog = new SaveFileDialog();
            tabPage3 = new TabPage();
            knownWordsCountLabel = new Label();
            filmsComboBox = new ComboBox();
            buttonToLastUnknown = new Button();
            labelCurrentIndex = new Label();
            checkBoxShowOnlyUnknownWords = new CheckBox();
            checkBoxIsKnownWord = new CheckBox();
            buttonNextWord = new Button();
            buttonPrevWord = new Button();
            labelCountInText = new Label();
            labelTranslatedWord = new Label();
            labelEngWord = new Label();
            tabPage1 = new TabPage();
            label9 = new Label();
            addNewWordsButton = new Button();
            label8 = new Label();
            WordsInFileNameTextBox = new TextBox();
            label3 = new Label();
            saveFileOnlyEngWordsButton = new Button();
            label1 = new Label();
            openFileButton = new Button();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // saveAllWordsButton
            // 
            saveAllWordsButton.Location = new Point(439, 280);
            saveAllWordsButton.Name = "saveAllWordsButton";
            saveAllWordsButton.Size = new Size(75, 23);
            saveAllWordsButton.TabIndex = 8;
            saveAllWordsButton.Text = "Сохранить";
            saveAllWordsButton.UseVisualStyleBackColor = true;
            saveAllWordsButton.Click += saveAllWordsButton_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(saveAllWordsButton);
            tabPage3.Controls.Add(knownWordsCountLabel);
            tabPage3.Controls.Add(filmsComboBox);
            tabPage3.Controls.Add(buttonToLastUnknown);
            tabPage3.Controls.Add(labelCurrentIndex);
            tabPage3.Controls.Add(checkBoxShowOnlyUnknownWords);
            tabPage3.Controls.Add(checkBoxIsKnownWord);
            tabPage3.Controls.Add(buttonNextWord);
            tabPage3.Controls.Add(buttonPrevWord);
            tabPage3.Controls.Add(labelCountInText);
            tabPage3.Controls.Add(labelTranslatedWord);
            tabPage3.Controls.Add(labelEngWord);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(588, 331);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // knownWordsCountLabel
            // 
            knownWordsCountLabel.AutoSize = true;
            knownWordsCountLabel.Location = new Point(63, 302);
            knownWordsCountLabel.Name = "knownWordsCountLabel";
            knownWordsCountLabel.Size = new Size(106, 15);
            knownWordsCountLabel.TabIndex = 9;
            knownWordsCountLabel.Text = "Слов изучено: 0/0";
            // 
            // filmsComboBox
            // 
            filmsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            filmsComboBox.ImeMode = ImeMode.NoControl;
            filmsComboBox.Items.AddRange(new object[] { "gfd", "gdf" });
            filmsComboBox.Location = new Point(65, 6);
            filmsComboBox.Name = "filmsComboBox";
            filmsComboBox.Size = new Size(121, 23);
            filmsComboBox.TabIndex = 8;
            filmsComboBox.SelectionChangeCommitted += filmsComboBox_SelectionChangeCommitted;
            // 
            // buttonToLastUnknown
            // 
            buttonToLastUnknown.Location = new Point(314, 219);
            buttonToLastUnknown.Name = "buttonToLastUnknown";
            buttonToLastUnknown.Size = new Size(200, 23);
            buttonToLastUnknown.TabIndex = 7;
            buttonToLastUnknown.Text = "К последнему незнакомому";
            buttonToLastUnknown.UseVisualStyleBackColor = true;
            buttonToLastUnknown.Click += buttonToLastUnknown_Click;
            // 
            // labelCurrentIndex
            // 
            labelCurrentIndex.AutoSize = true;
            labelCurrentIndex.Location = new Point(65, 143);
            labelCurrentIndex.Name = "labelCurrentIndex";
            labelCurrentIndex.Size = new Size(24, 15);
            labelCurrentIndex.TabIndex = 6;
            labelCurrentIndex.Text = "0/0";
            // 
            // checkBoxShowOnlyUnknownWords
            // 
            checkBoxShowOnlyUnknownWords.AutoSize = true;
            checkBoxShowOnlyUnknownWords.Checked = true;
            checkBoxShowOnlyUnknownWords.CheckState = CheckState.Checked;
            checkBoxShowOnlyUnknownWords.Location = new Point(63, 280);
            checkBoxShowOnlyUnknownWords.Name = "checkBoxShowOnlyUnknownWords";
            checkBoxShowOnlyUnknownWords.Size = new Size(238, 19);
            checkBoxShowOnlyUnknownWords.TabIndex = 2;
            checkBoxShowOnlyUnknownWords.Text = "Показывать только незнакомые слова";
            checkBoxShowOnlyUnknownWords.UseVisualStyleBackColor = true;
            checkBoxShowOnlyUnknownWords.Click += checkBoxShowOnlyUnknownWords_Click;
            // 
            // checkBoxIsKnownWord
            // 
            checkBoxIsKnownWord.AutoSize = true;
            checkBoxIsKnownWord.Location = new Point(65, 178);
            checkBoxIsKnownWord.Name = "checkBoxIsKnownWord";
            checkBoxIsKnownWord.Size = new Size(92, 19);
            checkBoxIsKnownWord.TabIndex = 5;
            checkBoxIsKnownWord.Text = "Знаю слово";
            checkBoxIsKnownWord.UseVisualStyleBackColor = true;
            checkBoxIsKnownWord.CheckedChanged += checkBoxIsKnownWord_CheckedChanged;
            // 
            // buttonNextWord
            // 
            buttonNextWord.Location = new Point(199, 219);
            buttonNextWord.Name = "buttonNextWord";
            buttonNextWord.Size = new Size(75, 23);
            buttonNextWord.TabIndex = 4;
            buttonNextWord.Text = "Вперед";
            buttonNextWord.UseVisualStyleBackColor = true;
            buttonNextWord.Click += buttonNextWord_Click;
            // 
            // buttonPrevWord
            // 
            buttonPrevWord.Location = new Point(78, 219);
            buttonPrevWord.Name = "buttonPrevWord";
            buttonPrevWord.Size = new Size(75, 23);
            buttonPrevWord.TabIndex = 3;
            buttonPrevWord.Text = "Назад";
            buttonPrevWord.UseVisualStyleBackColor = true;
            buttonPrevWord.Click += buttonPrevWord_Click;
            // 
            // labelCountInText
            // 
            labelCountInText.AutoSize = true;
            labelCountInText.Location = new Point(65, 113);
            labelCountInText.Name = "labelCountInText";
            labelCountInText.Size = new Size(46, 15);
            labelCountInText.TabIndex = 2;
            labelCountInText.Text = "Кол-во";
            // 
            // labelTranslatedWord
            // 
            labelTranslatedWord.AutoSize = true;
            labelTranslatedWord.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelTranslatedWord.Location = new Point(65, 77);
            labelTranslatedWord.Name = "labelTranslatedWord";
            labelTranslatedWord.Size = new Size(85, 25);
            labelTranslatedWord.TabIndex = 1;
            labelTranslatedWord.Text = "Перевод";
            labelTranslatedWord.MouseMove += labelTranslatedWord_MouseMove;
            // 
            // labelEngWord
            // 
            labelEngWord.AutoSize = true;
            labelEngWord.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            labelEngWord.Location = new Point(65, 39);
            labelEngWord.Name = "labelEngWord";
            labelEngWord.Size = new Size(92, 25);
            labelEngWord.TabIndex = 0;
            labelEngWord.Text = "Оригинал";
            labelEngWord.Click += labelEngWord_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(addNewWordsButton);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(WordsInFileNameTextBox);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(saveFileOnlyEngWordsButton);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(openFileButton);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(588, 331);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Парсинг исходника";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 255);
            label9.Name = "label9";
            label9.Size = new Size(128, 15);
            label9.TabIndex = 9;
            label9.Text = "Добавление перевода";
            // 
            // addNewWordsButton
            // 
            addNewWordsButton.Enabled = false;
            addNewWordsButton.Location = new Point(29, 273);
            addNewWordsButton.Name = "addNewWordsButton";
            addNewWordsButton.Size = new Size(75, 23);
            addNewWordsButton.TabIndex = 8;
            addNewWordsButton.Text = "button1";
            addNewWordsButton.UseVisualStyleBackColor = true;
            addNewWordsButton.Click += addNewWordsButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 203);
            label8.Name = "label8";
            label8.Size = new Size(165, 15);
            label8.TabIndex = 7;
            label8.Text = "Название файла сохоанения";
            // 
            // WordsInFileNameTextBox
            // 
            WordsInFileNameTextBox.Location = new Point(29, 221);
            WordsInFileNameTextBox.Name = "WordsInFileNameTextBox";
            WordsInFileNameTextBox.Size = new Size(100, 23);
            WordsInFileNameTextBox.TabIndex = 6;
            WordsInFileNameTextBox.TextChanged += WordsInFileNameTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 99);
            label3.Name = "label3";
            label3.Size = new Size(211, 15);
            label3.TabIndex = 5;
            label3.Text = "Генерация файла только со словами";
            // 
            // saveFileOnlyEngWordsButton
            // 
            saveFileOnlyEngWordsButton.Location = new Point(29, 117);
            saveFileOnlyEngWordsButton.Name = "saveFileOnlyEngWordsButton";
            saveFileOnlyEngWordsButton.Size = new Size(75, 23);
            saveFileOnlyEngWordsButton.TabIndex = 4;
            saveFileOnlyEngWordsButton.Text = "button1";
            saveFileOnlyEngWordsButton.UseVisualStyleBackColor = true;
            saveFileOnlyEngWordsButton.Click += saveFileOnlyEngWordsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 1;
            label1.Text = "Парсинг исходного файла";
            label1.Click += label1_Click;
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(29, 38);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(75, 23);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "button1";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(100, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(596, 359);
            tabControl1.TabIndex = 1;
            tabControl1.KeyDown += Form1_KeyDown;
            tabControl1.KeyUp += Form1_KeyUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button saveAllWordsButton;
        private TabPage tabPage3;
        private Label knownWordsCountLabel;
        private ComboBox filmsComboBox;
        private Button buttonToLastUnknown;
        private Label labelCurrentIndex;
        private CheckBox checkBoxShowOnlyUnknownWords;
        private CheckBox checkBoxIsKnownWord;
        private Button buttonNextWord;
        private Button buttonPrevWord;
        private Label labelCountInText;
        private Label labelTranslatedWord;
        private Label labelEngWord;
        private TabPage tabPage1;
        private Label label9;
        private Button addNewWordsButton;
        private Label label8;
        private TextBox WordsInFileNameTextBox;
        private Label label3;
        private Button saveFileOnlyEngWordsButton;
        private Label label1;
        private Button openFileButton;
        private TabControl tabControl1;
    }
}