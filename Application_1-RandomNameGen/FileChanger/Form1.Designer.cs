namespace FileChanger
{
    partial class TextAdder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileLoaderButton = new System.Windows.Forms.Button();
            this.firstInsertBox = new System.Windows.Forms.TextBox();
            this.endInsertBox = new System.Windows.Forms.TextBox();
            this.firstInsertlabel = new System.Windows.Forms.Label();
            this.endInsertlabel = new System.Windows.Forms.Label();
            this.executerButton = new System.Windows.Forms.Button();
            this.documentLabel = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.TextEditor = new System.Windows.Forms.GroupBox();
            this.capsCB = new System.Windows.Forms.CheckBox();
            this.numberCB = new System.Windows.Forms.CheckBox();
            this.informationLabel = new System.Windows.Forms.Label();
            this.lowerCB = new System.Windows.Forms.CheckBox();
            this.TextEditor.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileLoaderButton
            // 
            this.fileLoaderButton.Location = new System.Drawing.Point(15, 55);
            this.fileLoaderButton.Name = "fileLoaderButton";
            this.fileLoaderButton.Size = new System.Drawing.Size(75, 23);
            this.fileLoaderButton.TabIndex = 0;
            this.fileLoaderButton.Text = "Load File";
            this.fileLoaderButton.UseVisualStyleBackColor = true;
            this.fileLoaderButton.Click += new System.EventHandler(this.fileLoaderButton_Click);
            // 
            // firstInsertBox
            // 
            this.firstInsertBox.Location = new System.Drawing.Point(6, 19);
            this.firstInsertBox.Name = "firstInsertBox";
            this.firstInsertBox.Size = new System.Drawing.Size(53, 20);
            this.firstInsertBox.TabIndex = 1;
            // 
            // endInsertBox
            // 
            this.endInsertBox.Location = new System.Drawing.Point(6, 45);
            this.endInsertBox.Name = "endInsertBox";
            this.endInsertBox.Size = new System.Drawing.Size(53, 20);
            this.endInsertBox.TabIndex = 3;
            // 
            // firstInsertlabel
            // 
            this.firstInsertlabel.AutoSize = true;
            this.firstInsertlabel.Location = new System.Drawing.Point(66, 22);
            this.firstInsertlabel.Name = "firstInsertlabel";
            this.firstInsertlabel.Size = new System.Drawing.Size(26, 13);
            this.firstInsertlabel.TabIndex = 4;
            this.firstInsertlabel.Text = "First";
            // 
            // endInsertlabel
            // 
            this.endInsertlabel.AutoSize = true;
            this.endInsertlabel.Location = new System.Drawing.Point(65, 48);
            this.endInsertlabel.Name = "endInsertlabel";
            this.endInsertlabel.Size = new System.Drawing.Size(27, 13);
            this.endInsertlabel.TabIndex = 5;
            this.endInsertlabel.Text = "Last";
            // 
            // executerButton
            // 
            this.executerButton.Location = new System.Drawing.Point(95, 55);
            this.executerButton.Name = "executerButton";
            this.executerButton.Size = new System.Drawing.Size(75, 23);
            this.executerButton.TabIndex = 6;
            this.executerButton.Text = "Execute";
            this.executerButton.UseVisualStyleBackColor = true;
            this.executerButton.Click += new System.EventHandler(this.executerButton_Click);
            // 
            // documentLabel
            // 
            this.documentLabel.AutoSize = true;
            this.documentLabel.Location = new System.Drawing.Point(34, 78);
            this.documentLabel.Name = "documentLabel";
            this.documentLabel.Size = new System.Drawing.Size(112, 13);
            this.documentLabel.TabIndex = 7;
            this.documentLabel.Text = "No Document Loaded";
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "*.txt|*.TXT";
            this.openFile.Filter = "Text Files|*.txt";
            // 
            // TextEditor
            // 
            this.TextEditor.Controls.Add(this.firstInsertBox);
            this.TextEditor.Controls.Add(this.endInsertBox);
            this.TextEditor.Controls.Add(this.firstInsertlabel);
            this.TextEditor.Controls.Add(this.endInsertlabel);
            this.TextEditor.Location = new System.Drawing.Point(176, 12);
            this.TextEditor.Name = "TextEditor";
            this.TextEditor.Size = new System.Drawing.Size(97, 75);
            this.TextEditor.TabIndex = 8;
            this.TextEditor.TabStop = false;
            this.TextEditor.Text = "List Modifier";
            // 
            // capsCB
            // 
            this.capsCB.AutoSize = true;
            this.capsCB.Location = new System.Drawing.Point(12, 12);
            this.capsCB.Name = "capsCB";
            this.capsCB.Size = new System.Drawing.Size(71, 17);
            this.capsCB.TabIndex = 9;
            this.capsCB.Text = "Capitalize";
            this.capsCB.UseVisualStyleBackColor = true;
            this.capsCB.CheckedChanged += new System.EventHandler(this.capsCB_CheckedChanged);
            // 
            // numberCB
            // 
            this.numberCB.AutoSize = true;
            this.numberCB.Location = new System.Drawing.Point(12, 35);
            this.numberCB.Name = "numberCB";
            this.numberCB.Size = new System.Drawing.Size(76, 17);
            this.numberCB.TabIndex = 10;
            this.numberCB.Text = "Numberize";
            this.numberCB.UseVisualStyleBackColor = true;
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(9, 108);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(103, 26);
            this.informationLabel.TabIndex = 11;
            this.informationLabel.Text = "File Information :\r\nNothing Loaded yet.\r\n";
            // 
            // lowerCB
            // 
            this.lowerCB.AutoSize = true;
            this.lowerCB.Location = new System.Drawing.Point(95, 12);
            this.lowerCB.Name = "lowerCB";
            this.lowerCB.Size = new System.Drawing.Size(68, 17);
            this.lowerCB.TabIndex = 12;
            this.lowerCB.Text = "Lowerize";
            this.lowerCB.UseVisualStyleBackColor = true;
            this.lowerCB.CheckedChanged += new System.EventHandler(this.lowerCB_CheckedChanged);
            // 
            // TextAdder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.lowerCB);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.numberCB);
            this.Controls.Add(this.capsCB);
            this.Controls.Add(this.TextEditor);
            this.Controls.Add(this.documentLabel);
            this.Controls.Add(this.executerButton);
            this.Controls.Add(this.fileLoaderButton);
            this.Name = "TextAdder";
            this.Text = "Sample App";
            this.TextEditor.ResumeLayout(false);
            this.TextEditor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fileLoaderButton;
        private System.Windows.Forms.TextBox firstInsertBox;
        private System.Windows.Forms.TextBox endInsertBox;
        private System.Windows.Forms.Label firstInsertlabel;
        private System.Windows.Forms.Label endInsertlabel;
        private System.Windows.Forms.Button executerButton;
        private System.Windows.Forms.Label documentLabel;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.GroupBox TextEditor;
        private System.Windows.Forms.CheckBox capsCB;
        private System.Windows.Forms.CheckBox numberCB;
        private System.Windows.Forms.Label informationLabel;
        private System.Windows.Forms.CheckBox lowerCB;
    }
}

