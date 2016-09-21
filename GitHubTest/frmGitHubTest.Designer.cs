namespace GitHubTest
{
    partial class frmGitHubTest
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDoSomething = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(98, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(89, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDoSomething
            // 
            this.btnDoSomething.Location = new System.Drawing.Point(98, 86);
            this.btnDoSomething.Name = "btnDoSomething";
            this.btnDoSomething.Size = new System.Drawing.Size(89, 23);
            this.btnDoSomething.TabIndex = 1;
            this.btnDoSomething.Text = "&Do Something";
            this.btnDoSomething.UseVisualStyleBackColor = true;
            this.btnDoSomething.Click += new System.EventHandler(this.btnDoSomething_Click);
            // 
            // frmGitHubTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDoSomething);
            this.Controls.Add(this.btnClose);
            this.Name = "frmGitHubTest";
            this.Text = "Git Hub Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDoSomething;
    }
}

