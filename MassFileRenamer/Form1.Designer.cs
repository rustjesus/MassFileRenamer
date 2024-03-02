namespace MassFileRenamer
{
    partial class Form1
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
            this.filePathTxtBox = new System.Windows.Forms.TextBox();
            this.newNameTxtBox = new System.Windows.Forms.TextBox();
            this.folderPathLabel = new System.Windows.Forms.Label();
            this.newFilesNameLabel = new System.Windows.Forms.Label();
            this.changeNamesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // filePathTxtBox
            // 
            this.filePathTxtBox.Location = new System.Drawing.Point(124, 26);
            this.filePathTxtBox.Name = "filePathTxtBox";
            this.filePathTxtBox.Size = new System.Drawing.Size(455, 20);
            this.filePathTxtBox.TabIndex = 0;
            // 
            // newNameTxtBox
            // 
            this.newNameTxtBox.Location = new System.Drawing.Point(124, 51);
            this.newNameTxtBox.Name = "newNameTxtBox";
            this.newNameTxtBox.Size = new System.Drawing.Size(455, 20);
            this.newNameTxtBox.TabIndex = 1;
            // 
            // folderPathLabel
            // 
            this.folderPathLabel.AutoSize = true;
            this.folderPathLabel.Location = new System.Drawing.Point(52, 33);
            this.folderPathLabel.Name = "folderPathLabel";
            this.folderPathLabel.Size = new System.Drawing.Size(64, 13);
            this.folderPathLabel.TabIndex = 2;
            this.folderPathLabel.Text = "Folder Path:";
            // 
            // newFilesNameLabel
            // 
            this.newFilesNameLabel.AutoSize = true;
            this.newFilesNameLabel.Location = new System.Drawing.Point(29, 58);
            this.newFilesNameLabel.Name = "newFilesNameLabel";
            this.newFilesNameLabel.Size = new System.Drawing.Size(87, 13);
            this.newFilesNameLabel.TabIndex = 3;
            this.newFilesNameLabel.Text = "New Files Name:";
            // 
            // changeNamesBtn
            // 
            this.changeNamesBtn.Location = new System.Drawing.Point(32, 77);
            this.changeNamesBtn.Name = "changeNamesBtn";
            this.changeNamesBtn.Size = new System.Drawing.Size(133, 23);
            this.changeNamesBtn.TabIndex = 4;
            this.changeNamesBtn.Text = "Change Names!";
            this.changeNamesBtn.UseVisualStyleBackColor = true;
            this.changeNamesBtn.Click += new System.EventHandler(this.changeNamesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Will rename all files in the folder and add number+1 to end";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 225);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeNamesBtn);
            this.Controls.Add(this.newFilesNameLabel);
            this.Controls.Add(this.folderPathLabel);
            this.Controls.Add(this.newNameTxtBox);
            this.Controls.Add(this.filePathTxtBox);
            this.Name = "Form1";
            this.Text = "Mass File Rename";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filePathTxtBox;
        private System.Windows.Forms.TextBox newNameTxtBox;
        private System.Windows.Forms.Label folderPathLabel;
        private System.Windows.Forms.Label newFilesNameLabel;
        private System.Windows.Forms.Button changeNamesBtn;
        private System.Windows.Forms.Label label1;
    }
}

