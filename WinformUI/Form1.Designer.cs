namespace WinformUI
{
    partial class FileMover
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
            this.audioChkBox = new System.Windows.Forms.CheckBox();
            this.videoChkBox = new System.Windows.Forms.CheckBox();
            this.compressedChkBox = new System.Windows.Forms.CheckBox();
            this.executableChkBox = new System.Windows.Forms.CheckBox();
            this.imageChkBox = new System.Windows.Forms.CheckBox();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.videoTextBox = new System.Windows.Forms.TextBox();
            this.compressedTextBox = new System.Windows.Forms.TextBox();
            this.executableTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.audioTextBox = new System.Windows.Forms.TextBox();
            this.loadDataButton = new System.Windows.Forms.Button();
            this.saveDataButton = new System.Windows.Forms.Button();
            this.moveFilesButton = new System.Windows.Forms.Button();
            this.outputLable = new System.Windows.Forms.Label();
            this.createPathChkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // audioChkBox
            // 
            this.audioChkBox.AutoSize = true;
            this.audioChkBox.Location = new System.Drawing.Point(13, 132);
            this.audioChkBox.Name = "audioChkBox";
            this.audioChkBox.Size = new System.Drawing.Size(77, 17);
            this.audioChkBox.TabIndex = 0;
            this.audioChkBox.Text = "Audio Files";
            this.audioChkBox.UseVisualStyleBackColor = true;
            // 
            // videoChkBox
            // 
            this.videoChkBox.AutoSize = true;
            this.videoChkBox.Location = new System.Drawing.Point(13, 37);
            this.videoChkBox.Name = "videoChkBox";
            this.videoChkBox.Size = new System.Drawing.Size(77, 17);
            this.videoChkBox.TabIndex = 1;
            this.videoChkBox.Text = "Video Files";
            this.videoChkBox.UseVisualStyleBackColor = true;
            // 
            // compressedChkBox
            // 
            this.compressedChkBox.AutoSize = true;
            this.compressedChkBox.Location = new System.Drawing.Point(13, 61);
            this.compressedChkBox.Name = "compressedChkBox";
            this.compressedChkBox.Size = new System.Drawing.Size(108, 17);
            this.compressedChkBox.TabIndex = 2;
            this.compressedChkBox.Text = "Compressed Files";
            this.compressedChkBox.UseVisualStyleBackColor = true;
            // 
            // executableChkBox
            // 
            this.executableChkBox.AutoSize = true;
            this.executableChkBox.Location = new System.Drawing.Point(13, 85);
            this.executableChkBox.Name = "executableChkBox";
            this.executableChkBox.Size = new System.Drawing.Size(103, 17);
            this.executableChkBox.TabIndex = 3;
            this.executableChkBox.Text = "Executable Files";
            this.executableChkBox.UseVisualStyleBackColor = true;
            // 
            // imageChkBox
            // 
            this.imageChkBox.AutoSize = true;
            this.imageChkBox.Location = new System.Drawing.Point(13, 109);
            this.imageChkBox.Name = "imageChkBox";
            this.imageChkBox.Size = new System.Drawing.Size(79, 17);
            this.imageChkBox.TabIndex = 4;
            this.imageChkBox.Text = "Image Files";
            this.imageChkBox.UseVisualStyleBackColor = true;
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(192, 13);
            this.fileTypeLabel.TabIndex = 5;
            this.fileTypeLabel.Text = "Please Tick the Files you want to move";
            // 
            // videoTextBox
            // 
            this.videoTextBox.Location = new System.Drawing.Point(150, 37);
            this.videoTextBox.Name = "videoTextBox";
            this.videoTextBox.Size = new System.Drawing.Size(100, 20);
            this.videoTextBox.TabIndex = 6;
            // 
            // compressedTextBox
            // 
            this.compressedTextBox.Location = new System.Drawing.Point(150, 61);
            this.compressedTextBox.Name = "compressedTextBox";
            this.compressedTextBox.Size = new System.Drawing.Size(100, 20);
            this.compressedTextBox.TabIndex = 7;
            // 
            // executableTextBox
            // 
            this.executableTextBox.Location = new System.Drawing.Point(150, 83);
            this.executableTextBox.Name = "executableTextBox";
            this.executableTextBox.Size = new System.Drawing.Size(100, 20);
            this.executableTextBox.TabIndex = 8;
            // 
            // imageTextBox
            // 
            this.imageTextBox.Location = new System.Drawing.Point(150, 107);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(100, 20);
            this.imageTextBox.TabIndex = 9;
            // 
            // audioTextBox
            // 
            this.audioTextBox.Location = new System.Drawing.Point(150, 130);
            this.audioTextBox.Name = "audioTextBox";
            this.audioTextBox.Size = new System.Drawing.Size(100, 20);
            this.audioTextBox.TabIndex = 10;
            // 
            // loadDataButton
            // 
            this.loadDataButton.Location = new System.Drawing.Point(15, 415);
            this.loadDataButton.Name = "loadDataButton";
            this.loadDataButton.Size = new System.Drawing.Size(75, 23);
            this.loadDataButton.TabIndex = 11;
            this.loadDataButton.Text = "Load Data";
            this.loadDataButton.UseVisualStyleBackColor = true;
            // 
            // saveDataButton
            // 
            this.saveDataButton.Location = new System.Drawing.Point(96, 415);
            this.saveDataButton.Name = "saveDataButton";
            this.saveDataButton.Size = new System.Drawing.Size(75, 23);
            this.saveDataButton.TabIndex = 12;
            this.saveDataButton.Text = "Save Data";
            this.saveDataButton.UseVisualStyleBackColor = true;
            // 
            // moveFilesButton
            // 
            this.moveFilesButton.Location = new System.Drawing.Point(175, 415);
            this.moveFilesButton.Name = "moveFilesButton";
            this.moveFilesButton.Size = new System.Drawing.Size(75, 23);
            this.moveFilesButton.TabIndex = 13;
            this.moveFilesButton.Text = "Move Files";
            this.moveFilesButton.UseVisualStyleBackColor = true;
            this.moveFilesButton.Click += new System.EventHandler(this.moveFilesButton_Click);
            // 
            // outputLable
            // 
            this.outputLable.AutoSize = true;
            this.outputLable.Location = new System.Drawing.Point(10, 198);
            this.outputLable.Name = "outputLable";
            this.outputLable.Padding = new System.Windows.Forms.Padding(2);
            this.outputLable.Size = new System.Drawing.Size(4, 17);
            this.outputLable.TabIndex = 14;
            // 
            // createPathChkBox
            // 
            this.createPathChkBox.AutoSize = true;
            this.createPathChkBox.Location = new System.Drawing.Point(13, 156);
            this.createPathChkBox.Name = "createPathChkBox";
            this.createPathChkBox.Size = new System.Drawing.Size(91, 17);
            this.createPathChkBox.TabIndex = 15;
            this.createPathChkBox.Text = "Create Path ?";
            this.createPathChkBox.UseVisualStyleBackColor = true;
            this.createPathChkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FileMover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createPathChkBox);
            this.Controls.Add(this.outputLable);
            this.Controls.Add(this.moveFilesButton);
            this.Controls.Add(this.saveDataButton);
            this.Controls.Add(this.loadDataButton);
            this.Controls.Add(this.audioTextBox);
            this.Controls.Add(this.imageTextBox);
            this.Controls.Add(this.executableTextBox);
            this.Controls.Add(this.compressedTextBox);
            this.Controls.Add(this.videoTextBox);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.imageChkBox);
            this.Controls.Add(this.executableChkBox);
            this.Controls.Add(this.compressedChkBox);
            this.Controls.Add(this.videoChkBox);
            this.Controls.Add(this.audioChkBox);
            this.Name = "FileMover";
            this.Text = "FileMover";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox audioChkBox;
        private System.Windows.Forms.CheckBox videoChkBox;
        private System.Windows.Forms.CheckBox compressedChkBox;
        private System.Windows.Forms.CheckBox executableChkBox;
        private System.Windows.Forms.CheckBox imageChkBox;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.TextBox videoTextBox;
        private System.Windows.Forms.TextBox compressedTextBox;
        private System.Windows.Forms.TextBox executableTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox audioTextBox;
        private System.Windows.Forms.Button loadDataButton;
        private System.Windows.Forms.Button saveDataButton;
        private System.Windows.Forms.Button moveFilesButton;
        private System.Windows.Forms.Label outputLable;
        private System.Windows.Forms.CheckBox createPathChkBox;
    }
}

