namespace NyLabb4
{
    partial class UserControlPrintSelectedList
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPractice = new System.Windows.Forms.Button();
            this.buttonRemoveWord = new System.Windows.Forms.Button();
            this.buttonAddWords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonPractice);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRemoveWord);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddWords);
            this.splitContainer1.Size = new System.Drawing.Size(702, 501);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(702, 461);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonPractice
            // 
            this.buttonPractice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPractice.Location = new System.Drawing.Point(611, 4);
            this.buttonPractice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPractice.Name = "buttonPractice";
            this.buttonPractice.Size = new System.Drawing.Size(84, 22);
            this.buttonPractice.TabIndex = 6;
            this.buttonPractice.Text = "Practice";
            this.buttonPractice.UseVisualStyleBackColor = true;
            this.buttonPractice.Click += new System.EventHandler(this.buttonPractice_Click);
            // 
            // buttonRemoveWord
            // 
            this.buttonRemoveWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveWord.Location = new System.Drawing.Point(512, 4);
            this.buttonRemoveWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRemoveWord.Name = "buttonRemoveWord";
            this.buttonRemoveWord.Size = new System.Drawing.Size(84, 22);
            this.buttonRemoveWord.TabIndex = 5;
            this.buttonRemoveWord.Text = "Remove";
            this.buttonRemoveWord.UseVisualStyleBackColor = true;
            this.buttonRemoveWord.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddWords
            // 
            this.buttonAddWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddWords.Location = new System.Drawing.Point(413, 4);
            this.buttonAddWords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddWords.Name = "buttonAddWords";
            this.buttonAddWords.Size = new System.Drawing.Size(84, 22);
            this.buttonAddWords.TabIndex = 4;
            this.buttonAddWords.Text = "Add";
            this.buttonAddWords.UseVisualStyleBackColor = true;
            this.buttonAddWords.Click += new System.EventHandler(this.buttonAddWord_Click);
            // 
            // UserControlPrintSelectedList
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControlPrintSelectedList";
            this.Size = new System.Drawing.Size(702, 501);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPractice;
        private System.Windows.Forms.Button buttonRemoveWord;
        private System.Windows.Forms.Button buttonAddWords;
    }
}
