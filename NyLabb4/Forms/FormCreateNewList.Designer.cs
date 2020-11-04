namespace NyLabb4
{
    partial class FormCreateNewList
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxListName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAddNewList = new System.Windows.Forms.Button();
            this.textBoxLanguages = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "List name:";
            // 
            // textBoxListName
            // 
            this.textBoxListName.Location = new System.Drawing.Point(6, 25);
            this.textBoxListName.Name = "textBoxListName";
            this.textBoxListName.Size = new System.Drawing.Size(156, 20);
            this.textBoxListName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Languages:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(6, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAddNewList
            // 
            this.buttonAddNewList.Location = new System.Drawing.Point(87, 177);
            this.buttonAddNewList.Name = "buttonAddNewList";
            this.buttonAddNewList.Size = new System.Drawing.Size(75, 23);
            this.buttonAddNewList.TabIndex = 5;
            this.buttonAddNewList.Text = "Add";
            this.buttonAddNewList.UseVisualStyleBackColor = true;
            this.buttonAddNewList.Click += new System.EventHandler(this.buttonAddNewList_Click);
            // 
            // textBoxLanguages
            // 
            this.textBoxLanguages.Location = new System.Drawing.Point(6, 75);
            this.textBoxLanguages.Multiline = true;
            this.textBoxLanguages.Name = "textBoxLanguages";
            this.textBoxLanguages.Size = new System.Drawing.Size(156, 96);
            this.textBoxLanguages.TabIndex = 3;
            // 
            // FormCreateNewList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 201);
            this.Controls.Add(this.textBoxLanguages);
            this.Controls.Add(this.buttonAddNewList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxListName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCreateNewList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create New List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxListName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAddNewList;
        private System.Windows.Forms.TextBox textBoxLanguages;
    }
}