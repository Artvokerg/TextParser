﻿namespace TextParser
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
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileOnlyEngWordsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.createFileEngWordsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonWriteEngTranslatedToFile = new System.Windows.Forms.Button();
            this.buttonreadEngTranslatedFromFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GetRusWordsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SetEngTextFileButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.labelCurrentIndex = new System.Windows.Forms.Label();
            this.checkBoxShowOnlyUnknownWords = new System.Windows.Forms.CheckBox();
            this.checkBoxIsKnownWord = new System.Windows.Forms.CheckBox();
            this.buttonNextWord = new System.Windows.Forms.Button();
            this.buttonPrevWord = new System.Windows.Forms.Button();
            this.labelCountInText = new System.Windows.Forms.Label();
            this.labelTranslatedWord = new System.Windows.Forms.Label();
            this.labelEngWord = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(29, 38);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "button1";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(100, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(596, 359);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tabControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.saveFileOnlyEngWordsButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.createFileEngWordsButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.openFileButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(588, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Парсинг исходника";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Генерация файла только со словами";
            // 
            // saveFileOnlyEngWordsButton
            // 
            this.saveFileOnlyEngWordsButton.Location = new System.Drawing.Point(31, 165);
            this.saveFileOnlyEngWordsButton.Name = "saveFileOnlyEngWordsButton";
            this.saveFileOnlyEngWordsButton.Size = new System.Drawing.Size(75, 23);
            this.saveFileOnlyEngWordsButton.TabIndex = 4;
            this.saveFileOnlyEngWordsButton.Text = "button1";
            this.saveFileOnlyEngWordsButton.UseVisualStyleBackColor = true;
            this.saveFileOnlyEngWordsButton.Click += new System.EventHandler(this.saveFileOnlyEngWordsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сохранение файла со всеми словами";
            // 
            // createFileEngWordsButton
            // 
            this.createFileEngWordsButton.Location = new System.Drawing.Point(31, 113);
            this.createFileEngWordsButton.Name = "createFileEngWordsButton";
            this.createFileEngWordsButton.Size = new System.Drawing.Size(75, 23);
            this.createFileEngWordsButton.TabIndex = 2;
            this.createFileEngWordsButton.Text = "button1";
            this.createFileEngWordsButton.UseVisualStyleBackColor = true;
            this.createFileEngWordsButton.Click += new System.EventHandler(this.createFileEngWordsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Парсинг исходного файла";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonWriteEngTranslatedToFile);
            this.tabPage2.Controls.Add(this.buttonreadEngTranslatedFromFile);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.GetRusWordsButton);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.SetEngTextFileButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(588, 331);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление перевода";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Сохранить файл оригинал-перевод";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "загрузить готовый файл оригинал-перевод";
            // 
            // buttonWriteEngTranslatedToFile
            // 
            this.buttonWriteEngTranslatedToFile.Location = new System.Drawing.Point(33, 262);
            this.buttonWriteEngTranslatedToFile.Name = "buttonWriteEngTranslatedToFile";
            this.buttonWriteEngTranslatedToFile.Size = new System.Drawing.Size(75, 23);
            this.buttonWriteEngTranslatedToFile.TabIndex = 5;
            this.buttonWriteEngTranslatedToFile.Text = "button2";
            this.buttonWriteEngTranslatedToFile.UseVisualStyleBackColor = true;
            this.buttonWriteEngTranslatedToFile.Click += new System.EventHandler(this.buttonWriteEngTranslatedToFile_Click);
            // 
            // buttonreadEngTranslatedFromFile
            // 
            this.buttonreadEngTranslatedFromFile.Location = new System.Drawing.Point(33, 192);
            this.buttonreadEngTranslatedFromFile.Name = "buttonreadEngTranslatedFromFile";
            this.buttonreadEngTranslatedFromFile.Size = new System.Drawing.Size(75, 23);
            this.buttonreadEngTranslatedFromFile.TabIndex = 4;
            this.buttonreadEngTranslatedFromFile.Text = "button1";
            this.buttonreadEngTranslatedFromFile.UseVisualStyleBackColor = true;
            this.buttonreadEngTranslatedFromFile.Click += new System.EventHandler(this.buttonreadEngTranslatedFromFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Загрузить файл с русским перевом";
            // 
            // GetRusWordsButton
            // 
            this.GetRusWordsButton.Location = new System.Drawing.Point(33, 111);
            this.GetRusWordsButton.Name = "GetRusWordsButton";
            this.GetRusWordsButton.Size = new System.Drawing.Size(75, 23);
            this.GetRusWordsButton.TabIndex = 2;
            this.GetRusWordsButton.Text = "button1";
            this.GetRusWordsButton.UseVisualStyleBackColor = true;
            this.GetRusWordsButton.Click += new System.EventHandler(this.GetRusWordsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Указать файл с английскими словами";
            // 
            // SetEngTextFileButton
            // 
            this.SetEngTextFileButton.Location = new System.Drawing.Point(33, 39);
            this.SetEngTextFileButton.Name = "SetEngTextFileButton";
            this.SetEngTextFileButton.Size = new System.Drawing.Size(75, 23);
            this.SetEngTextFileButton.TabIndex = 0;
            this.SetEngTextFileButton.Text = "button1";
            this.SetEngTextFileButton.UseVisualStyleBackColor = true;
            this.SetEngTextFileButton.Click += new System.EventHandler(this.SetEngTextFileButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.labelCurrentIndex);
            this.tabPage3.Controls.Add(this.checkBoxShowOnlyUnknownWords);
            this.tabPage3.Controls.Add(this.checkBoxIsKnownWord);
            this.tabPage3.Controls.Add(this.buttonNextWord);
            this.tabPage3.Controls.Add(this.buttonPrevWord);
            this.tabPage3.Controls.Add(this.labelCountInText);
            this.tabPage3.Controls.Add(this.labelTranslatedWord);
            this.tabPage3.Controls.Add(this.labelEngWord);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(588, 331);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // labelCurrentIndex
            // 
            this.labelCurrentIndex.AutoSize = true;
            this.labelCurrentIndex.Location = new System.Drawing.Point(65, 143);
            this.labelCurrentIndex.Name = "labelCurrentIndex";
            this.labelCurrentIndex.Size = new System.Drawing.Size(24, 15);
            this.labelCurrentIndex.TabIndex = 6;
            this.labelCurrentIndex.Text = "0/0";
            // 
            // checkBoxShowOnlyUnknownWords
            // 
            this.checkBoxShowOnlyUnknownWords.AutoSize = true;
            this.checkBoxShowOnlyUnknownWords.Checked = true;
            this.checkBoxShowOnlyUnknownWords.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowOnlyUnknownWords.Location = new System.Drawing.Point(63, 280);
            this.checkBoxShowOnlyUnknownWords.Name = "checkBoxShowOnlyUnknownWords";
            this.checkBoxShowOnlyUnknownWords.Size = new System.Drawing.Size(238, 19);
            this.checkBoxShowOnlyUnknownWords.TabIndex = 2;
            this.checkBoxShowOnlyUnknownWords.Text = "Показывать только незнакомые слова";
            this.checkBoxShowOnlyUnknownWords.UseVisualStyleBackColor = true;
            this.checkBoxShowOnlyUnknownWords.Click += new System.EventHandler(this.checkBoxShowOnlyUnknownWords_Click);
            // 
            // checkBoxIsKnownWord
            // 
            this.checkBoxIsKnownWord.AutoSize = true;
            this.checkBoxIsKnownWord.Location = new System.Drawing.Point(65, 178);
            this.checkBoxIsKnownWord.Name = "checkBoxIsKnownWord";
            this.checkBoxIsKnownWord.Size = new System.Drawing.Size(92, 19);
            this.checkBoxIsKnownWord.TabIndex = 5;
            this.checkBoxIsKnownWord.Text = "Знаю слово";
            this.checkBoxIsKnownWord.UseVisualStyleBackColor = true;
            this.checkBoxIsKnownWord.Click += new System.EventHandler(this.checkBoxIsKnownWord_CheckedChanged);
            // 
            // buttonNextWord
            // 
            this.buttonNextWord.Location = new System.Drawing.Point(199, 219);
            this.buttonNextWord.Name = "buttonNextWord";
            this.buttonNextWord.Size = new System.Drawing.Size(75, 23);
            this.buttonNextWord.TabIndex = 4;
            this.buttonNextWord.Text = "Вперед";
            this.buttonNextWord.UseVisualStyleBackColor = true;
            this.buttonNextWord.Click += new System.EventHandler(this.buttonNextWord_Click);
            // 
            // buttonPrevWord
            // 
            this.buttonPrevWord.Location = new System.Drawing.Point(78, 219);
            this.buttonPrevWord.Name = "buttonPrevWord";
            this.buttonPrevWord.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevWord.TabIndex = 3;
            this.buttonPrevWord.Text = "Назад";
            this.buttonPrevWord.UseVisualStyleBackColor = true;
            this.buttonPrevWord.Click += new System.EventHandler(this.buttonPrevWord_Click);
            // 
            // labelCountInText
            // 
            this.labelCountInText.AutoSize = true;
            this.labelCountInText.Location = new System.Drawing.Point(65, 113);
            this.labelCountInText.Name = "labelCountInText";
            this.labelCountInText.Size = new System.Drawing.Size(46, 15);
            this.labelCountInText.TabIndex = 2;
            this.labelCountInText.Text = "Кол-во";
            // 
            // labelTranslatedWord
            // 
            this.labelTranslatedWord.AutoSize = true;
            this.labelTranslatedWord.Location = new System.Drawing.Point(65, 77);
            this.labelTranslatedWord.Name = "labelTranslatedWord";
            this.labelTranslatedWord.Size = new System.Drawing.Size(54, 15);
            this.labelTranslatedWord.TabIndex = 1;
            this.labelTranslatedWord.Text = "Перевод";
            // 
            // labelEngWord
            // 
            this.labelEngWord.AutoSize = true;
            this.labelEngWord.Location = new System.Drawing.Point(65, 39);
            this.labelEngWord.Name = "labelEngWord";
            this.labelEngWord.Size = new System.Drawing.Size(62, 15);
            this.labelEngWord.TabIndex = 0;
            this.labelEngWord.Text = "Оригинал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

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
    }
}