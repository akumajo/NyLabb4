namespace NyLabb4
{
    partial class UserControlPracticeMode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTranslateThisToThis = new System.Windows.Forms.Label();
            this.labelShowHowManyWords = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonEndpractice = new System.Windows.Forms.Button();
            this.textBoxInputWord = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelTranslateThisToThis);
            this.panel1.Controls.Add(this.labelShowHowManyWords);
            this.panel1.Controls.Add(this.buttonRestart);
            this.panel1.Controls.Add(this.buttonEndpractice);
            this.panel1.Controls.Add(this.textBoxInputWord);
            this.panel1.Location = new System.Drawing.Point(3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 264);
            this.panel1.TabIndex = 1;
            // 
            // labelTranslateThisToThis
            // 
            this.labelTranslateThisToThis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTranslateThisToThis.Location = new System.Drawing.Point(-21, 29);
            this.labelTranslateThisToThis.Name = "labelTranslateThisToThis";
            this.labelTranslateThisToThis.Size = new System.Drawing.Size(348, 25);
            this.labelTranslateThisToThis.TabIndex = 10;
            this.labelTranslateThisToThis.Text = "label1";
            this.labelTranslateThisToThis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShowHowManyWords
            // 
            this.labelShowHowManyWords.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelShowHowManyWords.Location = new System.Drawing.Point(-24, 190);
            this.labelShowHowManyWords.Name = "labelShowHowManyWords";
            this.labelShowHowManyWords.Size = new System.Drawing.Size(351, 26);
            this.labelShowHowManyWords.TabIndex = 9;
            this.labelShowHowManyWords.Text = "label1";
            this.labelShowHowManyWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRestart.Location = new System.Drawing.Point(189, 126);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(84, 22);
            this.buttonRestart.TabIndex = 8;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonEndpractice
            // 
            this.buttonEndpractice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEndpractice.Location = new System.Drawing.Point(30, 126);
            this.buttonEndpractice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEndpractice.Name = "buttonEndpractice";
            this.buttonEndpractice.Size = new System.Drawing.Size(84, 22);
            this.buttonEndpractice.TabIndex = 7;
            this.buttonEndpractice.Text = "End Practice";
            this.buttonEndpractice.UseVisualStyleBackColor = true;
            this.buttonEndpractice.Click += new System.EventHandler(this.buttonEndpractice_Click);
            // 
            // textBoxInputWord
            // 
            this.textBoxInputWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxInputWord.Location = new System.Drawing.Point(30, 82);
            this.textBoxInputWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxInputWord.Name = "textBoxInputWord";
            this.textBoxInputWord.Size = new System.Drawing.Size(243, 20);
            this.textBoxInputWord.TabIndex = 6;
            this.textBoxInputWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputWord_KeyPress);
            // 
            // UserControlPracticeMode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserControlPracticeMode";
            this.Size = new System.Drawing.Size(308, 275);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTranslateThisToThis;
        private System.Windows.Forms.Label labelShowHowManyWords;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Button buttonEndpractice;
        private System.Windows.Forms.TextBox textBoxInputWord;
    }
}
