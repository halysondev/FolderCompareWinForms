﻿namespace FolderCompareWinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelA = new Label();
            label2 = new Label();
            folderA = new FolderBrowserDialog();
            folderB = new FolderBrowserDialog();
            folderExport = new FolderBrowserDialog();
            labelB = new Label();
            textBoxA = new TextBox();
            buttonA = new Button();
            buttonB = new Button();
            textBoxB = new TextBox();
            label1 = new Label();
            textBoxExport = new TextBox();
            buttonExport = new Button();
            FoldersBox = new GroupBox();
            SettingsBox = new GroupBox();
            checkFolderA = new CheckBox();
            checkFolderB = new CheckBox();
            checkExisting = new CheckBox();
            buttonConfirm = new Button();
            logsBox = new ListBox();
            FoldersBox.SuspendLayout();
            SettingsBox.SuspendLayout();
            SuspendLayout();
            // 
            // labelA
            // 
            labelA.AutoSize = true;
            labelA.Font = new Font("Segoe UI", 14F);
            labelA.Location = new Point(6, 19);
            labelA.Name = "labelA";
            labelA.Size = new Size(82, 25);
            labelA.TabIndex = 0;
            labelA.Text = "Folder A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 24);
            label2.Name = "label2";
            label2.Size = new Size(247, 15);
            label2.TabIndex = 1;
            label2.Text = "1. Select Folder A, Folder B, And Export Folder";
            // 
            // labelB
            // 
            labelB.AutoSize = true;
            labelB.Font = new Font("Segoe UI", 14F);
            labelB.Location = new Point(6, 89);
            labelB.Name = "labelB";
            labelB.Size = new Size(81, 25);
            labelB.TabIndex = 2;
            labelB.Text = "Folder B";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(92, 61);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(359, 23);
            textBoxA.TabIndex = 3;
            // 
            // buttonA
            // 
            buttonA.Location = new Point(6, 60);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(75, 23);
            buttonA.TabIndex = 4;
            buttonA.Text = "Select";
            buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            buttonB.Location = new Point(6, 117);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(75, 23);
            buttonB.TabIndex = 5;
            buttonB.Text = "Select";
            buttonB.UseVisualStyleBackColor = true;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(92, 117);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(359, 23);
            textBoxB.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(6, 152);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 7;
            label1.Text = "Export Folder";
            // 
            // textBoxExport
            // 
            textBoxExport.Location = new Point(92, 189);
            textBoxExport.Name = "textBoxExport";
            textBoxExport.Size = new Size(359, 23);
            textBoxExport.TabIndex = 8;
            // 
            // buttonExport
            // 
            buttonExport.Location = new Point(6, 189);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(75, 23);
            buttonExport.TabIndex = 9;
            buttonExport.Text = "Select";
            buttonExport.UseVisualStyleBackColor = true;
            // 
            // FoldersBox
            // 
            FoldersBox.Controls.Add(buttonExport);
            FoldersBox.Controls.Add(labelA);
            FoldersBox.Controls.Add(textBoxExport);
            FoldersBox.Controls.Add(labelB);
            FoldersBox.Controls.Add(label1);
            FoldersBox.Controls.Add(textBoxA);
            FoldersBox.Controls.Add(textBoxB);
            FoldersBox.Controls.Add(buttonA);
            FoldersBox.Controls.Add(buttonB);
            FoldersBox.Location = new Point(12, 52);
            FoldersBox.Name = "FoldersBox";
            FoldersBox.Size = new Size(470, 236);
            FoldersBox.TabIndex = 10;
            FoldersBox.TabStop = false;
            FoldersBox.Text = "Folders";
            // 
            // SettingsBox
            // 
            SettingsBox.Controls.Add(checkExisting);
            SettingsBox.Controls.Add(checkFolderB);
            SettingsBox.Controls.Add(checkFolderA);
            SettingsBox.Location = new Point(488, 52);
            SettingsBox.Name = "SettingsBox";
            SettingsBox.Size = new Size(287, 124);
            SettingsBox.TabIndex = 11;
            SettingsBox.TabStop = false;
            SettingsBox.Text = "Settings";
            // 
            // checkFolderA
            // 
            checkFolderA.AutoSize = true;
            checkFolderA.Location = new Point(6, 26);
            checkFolderA.Name = "checkFolderA";
            checkFolderA.Size = new Size(145, 19);
            checkFolderA.TabIndex = 0;
            checkFolderA.Text = "Copy if not in Folder A";
            checkFolderA.UseVisualStyleBackColor = true;
            // 
            // checkFolderB
            // 
            checkFolderB.AutoSize = true;
            checkFolderB.Location = new Point(6, 63);
            checkFolderB.Name = "checkFolderB";
            checkFolderB.Size = new Size(144, 19);
            checkFolderB.TabIndex = 1;
            checkFolderB.Text = "Copy if not in Folder B";
            checkFolderB.UseVisualStyleBackColor = true;
            // 
            // checkExisting
            // 
            checkExisting.AutoSize = true;
            checkExisting.Location = new Point(6, 95);
            checkExisting.Name = "checkExisting";
            checkExisting.Size = new Size(219, 19);
            checkExisting.TabIndex = 2;
            checkExisting.Text = "Replace existing files in export folder";
            checkExisting.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(488, 182);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(287, 106);
            buttonConfirm.TabIndex = 12;
            buttonConfirm.Text = "EXPORT";
            buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // logsBox
            // 
            logsBox.FormattingEnabled = true;
            logsBox.ItemHeight = 15;
            logsBox.Location = new Point(12, 294);
            logsBox.Name = "logsBox";
            logsBox.SelectionMode = SelectionMode.None;
            logsBox.Size = new Size(760, 244);
            logsBox.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 549);
            Controls.Add(logsBox);
            Controls.Add(buttonConfirm);
            Controls.Add(SettingsBox);
            Controls.Add(FoldersBox);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Folder Compare";
            FoldersBox.ResumeLayout(false);
            FoldersBox.PerformLayout();
            SettingsBox.ResumeLayout(false);
            SettingsBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelA;
        private Label label2;
        private FolderBrowserDialog folderA;
        private FolderBrowserDialog folderB;
        private FolderBrowserDialog folderExport;
        private Label labelB;
        private TextBox textBoxA;
        private Button buttonA;
        private Button buttonB;
        private TextBox textBoxB;
        private Label label1;
        private TextBox textBoxExport;
        private Button buttonExport;
        private GroupBox FoldersBox;
        private GroupBox SettingsBox;
        private CheckBox checkFolderB;
        private CheckBox checkFolderA;
        private CheckBox checkExisting;
        private Button buttonConfirm;
        public ListBox logsBox;
    }
}
