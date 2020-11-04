namespace NyLabb4
{
    partial class FormLoadLists
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
            this.buttonNewList = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listBoxLists = new System.Windows.Forms.ListBox();
            this.listBoxLanguages = new System.Windows.Forms.ListBox();
            this.labelWordList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelWordCounter = new System.Windows.Forms.Label();
            this.labelLanguages = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonNewList
            // 
            this.buttonNewList.Location = new System.Drawing.Point(9, 230);
            this.buttonNewList.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNewList.Name = "buttonNewList";
            this.buttonNewList.Size = new System.Drawing.Size(63, 19);
            this.buttonNewList.TabIndex = 0;
            this.buttonNewList.Text = "New list";
            this.buttonNewList.UseVisualStyleBackColor = true;
            this.buttonNewList.Click += new System.EventHandler(this.buttonNewList_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(299, 230);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(63, 19);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(366, 230);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(63, 19);
            this.buttonSelect.TabIndex = 2;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // listBoxLists
            // 
            this.listBoxLists.FormattingEnabled = true;
            this.listBoxLists.Location = new System.Drawing.Point(9, 28);
            this.listBoxLists.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLists.Name = "listBoxLists";
            this.listBoxLists.Size = new System.Drawing.Size(196, 186);
            this.listBoxLists.TabIndex = 3;
            this.listBoxLists.SelectedIndexChanged += new System.EventHandler(this.listBoxLists_SelectedIndexChanged);
            // 
            // listBoxLanguages
            // 
            this.listBoxLanguages.FormattingEnabled = true;
            this.listBoxLanguages.Location = new System.Drawing.Point(233, 28);
            this.listBoxLanguages.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxLanguages.Name = "listBoxLanguages";
            this.listBoxLanguages.Size = new System.Drawing.Size(196, 186);
            this.listBoxLanguages.TabIndex = 4;
            // 
            // labelWordList
            // 
            this.labelWordList.AutoSize = true;
            this.labelWordList.Location = new System.Drawing.Point(10, 11);
            this.labelWordList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWordList.Name = "labelWordList";
            this.labelWordList.Size = new System.Drawing.Size(56, 13);
            this.labelWordList.TabIndex = 5;
            this.labelWordList.Text = "Word lists:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Word count:";
            // 
            // labelWordCounter
            // 
            this.labelWordCounter.AutoSize = true;
            this.labelWordCounter.Location = new System.Drawing.Point(183, 11);
            this.labelWordCounter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWordCounter.Name = "labelWordCounter";
            this.labelWordCounter.Size = new System.Drawing.Size(13, 13);
            this.labelWordCounter.TabIndex = 7;
            this.labelWordCounter.Text = "0";
            // 
            // labelLanguages
            // 
            this.labelLanguages.AutoSize = true;
            this.labelLanguages.Location = new System.Drawing.Point(231, 11);
            this.labelLanguages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLanguages.Name = "labelLanguages";
            this.labelLanguages.Size = new System.Drawing.Size(63, 13);
            this.labelLanguages.TabIndex = 8;
            this.labelLanguages.Text = "Languages:";
            // 
            // FormLoadLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(this.labelLanguages);
            this.Controls.Add(this.labelWordCounter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWordList);
            this.Controls.Add(this.listBoxLanguages);
            this.Controls.Add(this.listBoxLists);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNewList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormLoadLists";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Word List";
            this.Load += new System.EventHandler(this.FormLoadLists_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listBoxLists;
        private System.Windows.Forms.ListBox listBoxLanguages;
        private System.Windows.Forms.Label labelWordList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelWordCounter;
        private System.Windows.Forms.Label labelLanguages;
    }
}