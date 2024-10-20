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
            openFileButton = new Button();
            openFileDialog = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label3 = new Label();
            saveFileOnlyEngWordsButton = new Button();
            label2 = new Label();
            createFileEngWordsButton = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            buttonWriteEngTranslatedToFile = new Button();
            buttonreadEngTranslatedFromFile = new Button();
            label5 = new Label();
            GetRusWordsButton = new Button();
            label4 = new Label();
            SetEngTextFileButton = new Button();
            tabPage3 = new TabPage();
            labelCurrentIndex = new Label();
            checkBoxShowOnlyUnknownWords = new CheckBox();
            checkBoxIsKnownWord = new CheckBox();
            buttonNextWord = new Button();
            buttonPrevWord = new Button();
            labelCountInText = new Label();
            labelTranslatedWord = new Label();
            labelEngWord = new Label();
            saveFileDialog = new SaveFileDialog();
            buttonToLastUnknown = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
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
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(100, 42);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(596, 359);
            tabControl1.TabIndex = 1;
            tabControl1.KeyDown += Form1_KeyDown;
            tabControl1.KeyUp += Form1_KeyUp;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(saveFileOnlyEngWordsButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(createFileEngWordsButton);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 147);
            label3.Name = "label3";
            label3.Size = new Size(211, 15);
            label3.TabIndex = 5;
            label3.Text = "Генерация файла только со словами";
            // 
            // saveFileOnlyEngWordsButton
            // 
            saveFileOnlyEngWordsButton.Location = new Point(31, 165);
            saveFileOnlyEngWordsButton.Name = "saveFileOnlyEngWordsButton";
            saveFileOnlyEngWordsButton.Size = new Size(75, 23);
            saveFileOnlyEngWordsButton.TabIndex = 4;
            saveFileOnlyEngWordsButton.Text = "button1";
            saveFileOnlyEngWordsButton.UseVisualStyleBackColor = true;
            saveFileOnlyEngWordsButton.Click += saveFileOnlyEngWordsButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 95);
            label2.Name = "label2";
            label2.Size = new Size(216, 15);
            label2.TabIndex = 3;
            label2.Text = "Сохранение файла со всеми словами";
            // 
            // createFileEngWordsButton
            // 
            createFileEngWordsButton.Location = new Point(31, 113);
            createFileEngWordsButton.Name = "createFileEngWordsButton";
            createFileEngWordsButton.Size = new Size(75, 23);
            createFileEngWordsButton.TabIndex = 2;
            createFileEngWordsButton.Text = "button1";
            createFileEngWordsButton.UseVisualStyleBackColor = true;
            createFileEngWordsButton.Click += createFileEngWordsButton_Click;
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
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(buttonWriteEngTranslatedToFile);
            tabPage2.Controls.Add(buttonreadEngTranslatedFromFile);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(GetRusWordsButton);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(SetEngTextFileButton);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(588, 331);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Добавление перевода";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 234);
            label7.Name = "label7";
            label7.Size = new Size(204, 15);
            label7.TabIndex = 7;
            label7.Text = "Сохранить файл оригинал-перевод";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 159);
            label6.Name = "label6";
            label6.Size = new Size(246, 15);
            label6.TabIndex = 6;
            label6.Text = "загрузить готовый файл оригинал-перевод";
            // 
            // buttonWriteEngTranslatedToFile
            // 
            buttonWriteEngTranslatedToFile.Location = new Point(33, 262);
            buttonWriteEngTranslatedToFile.Name = "buttonWriteEngTranslatedToFile";
            buttonWriteEngTranslatedToFile.Size = new Size(75, 23);
            buttonWriteEngTranslatedToFile.TabIndex = 5;
            buttonWriteEngTranslatedToFile.Text = "button2";
            buttonWriteEngTranslatedToFile.UseVisualStyleBackColor = true;
            buttonWriteEngTranslatedToFile.Click += buttonWriteEngTranslatedToFile_Click;
            // 
            // buttonreadEngTranslatedFromFile
            // 
            buttonreadEngTranslatedFromFile.Location = new Point(33, 192);
            buttonreadEngTranslatedFromFile.Name = "buttonreadEngTranslatedFromFile";
            buttonreadEngTranslatedFromFile.Size = new Size(75, 23);
            buttonreadEngTranslatedFromFile.TabIndex = 4;
            buttonreadEngTranslatedFromFile.Text = "button1";
            buttonreadEngTranslatedFromFile.UseVisualStyleBackColor = true;
            buttonreadEngTranslatedFromFile.Click += buttonreadEngTranslatedFromFile_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 93);
            label5.Name = "label5";
            label5.Size = new Size(203, 15);
            label5.TabIndex = 3;
            label5.Text = "Загрузить файл с русским перевом";
            // 
            // GetRusWordsButton
            // 
            GetRusWordsButton.Location = new Point(33, 111);
            GetRusWordsButton.Name = "GetRusWordsButton";
            GetRusWordsButton.Size = new Size(75, 23);
            GetRusWordsButton.TabIndex = 2;
            GetRusWordsButton.Text = "button1";
            GetRusWordsButton.UseVisualStyleBackColor = true;
            GetRusWordsButton.Click += GetRusWordsButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 21);
            label4.Name = "label4";
            label4.Size = new Size(217, 15);
            label4.TabIndex = 1;
            label4.Text = "Указать файл с английскими словами";
            // 
            // SetEngTextFileButton
            // 
            SetEngTextFileButton.Location = new Point(33, 39);
            SetEngTextFileButton.Name = "SetEngTextFileButton";
            SetEngTextFileButton.Size = new Size(75, 23);
            SetEngTextFileButton.TabIndex = 0;
            SetEngTextFileButton.Text = "button1";
            SetEngTextFileButton.UseVisualStyleBackColor = true;
            SetEngTextFileButton.Click += SetEngTextFileButton_Click;
            // 
            // tabPage3
            // 
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
            checkBoxIsKnownWord.Click += checkBoxIsKnownWord_CheckedChanged;
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
            labelTranslatedWord.Location = new Point(65, 77);
            labelTranslatedWord.Name = "labelTranslatedWord";
            labelTranslatedWord.Size = new Size(54, 15);
            labelTranslatedWord.TabIndex = 1;
            labelTranslatedWord.Text = "Перевод";
            // 
            // labelEngWord
            // 
            labelEngWord.AutoSize = true;
            labelEngWord.Location = new Point(65, 39);
            labelEngWord.Name = "labelEngWord";
            labelEngWord.Size = new Size(62, 15);
            labelEngWord.TabIndex = 0;
            labelEngWord.Text = "Оригинал";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button openFileButton;
        private OpenFileDialog openFileDialog;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label1;
        private TabPage tabPage2;
        private Label label2;
        private Button createFileEngWordsButton;
        private SaveFileDialog saveFileDialog;
        private Label label3;
        private Button saveFileOnlyEngWordsButton;
        private Label label4;
        private Button SetEngTextFileButton;
        private Button GetRusWordsButton;
        private Label label5;
        private TabPage tabPage3;
        private Button buttonNextWord;
        private Button buttonPrevWord;
        private Label labelCountInText;
        private Label labelTranslatedWord;
        private Label labelEngWord;
        private Label label7;
        private Label label6;
        private Button buttonWriteEngTranslatedToFile;
        private Button buttonreadEngTranslatedFromFile;
        private CheckBox checkBoxIsKnownWord;
        private CheckBox checkBoxShowOnlyUnknownWords;
        private Label labelCurrentIndex;
        private Button buttonToLastUnknown;
    }
}