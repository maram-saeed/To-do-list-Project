namespace ToDo_List
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
            this.label1 = new System.Windows.Forms.Label();
            this.tvNotes = new System.Windows.Forms.TreeView();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.lblProgressValue = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addNote = new System.Windows.Forms.Button();
            this.removeNote = new System.Windows.Forms.Button();
            this.removeAllNotes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumOfNotes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCyan;
            this.label1.Location = new System.Drawing.Point(238, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Notes";
            // 
            // tvNotes
            // 
            this.tvNotes.BackColor = System.Drawing.Color.White;
            this.tvNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvNotes.CheckBoxes = true;
            this.tvNotes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNotes.Location = new System.Drawing.Point(55, 90);
            this.tvNotes.Name = "tvNotes";
            this.tvNotes.Size = new System.Drawing.Size(613, 390);
            this.tvNotes.TabIndex = 1;
            this.tvNotes.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvNotes_AfterCheck);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(75, 509);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(509, 46);
            this.progBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progBar.TabIndex = 2;
            // 
            // lblProgressValue
            // 
            this.lblProgressValue.AutoSize = true;
            this.lblProgressValue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressValue.ForeColor = System.Drawing.Color.White;
            this.lblProgressValue.Location = new System.Drawing.Point(603, 517);
            this.lblProgressValue.Name = "lblProgressValue";
            this.lblProgressValue.Size = new System.Drawing.Size(63, 35);
            this.lblProgressValue.TabIndex = 3;
            this.lblProgressValue.Text = "0%";
            // 
            // txtBox
            // 
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox.Location = new System.Drawing.Point(734, 90);
            this.txtBox.Multiline = true;
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(544, 218);
            this.txtBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(801, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Write here to add your note to the list:";
            // 
            // addNote
            // 
            this.addNote.BackColor = System.Drawing.Color.SteelBlue;
            this.addNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNote.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNote.ForeColor = System.Drawing.Color.White;
            this.addNote.Location = new System.Drawing.Point(729, 353);
            this.addNote.Name = "addNote";
            this.addNote.Size = new System.Drawing.Size(157, 50);
            this.addNote.TabIndex = 6;
            this.addNote.Text = "Add Note";
            this.addNote.UseVisualStyleBackColor = false;
            this.addNote.Click += new System.EventHandler(this.addNote_Click);
            // 
            // removeNote
            // 
            this.removeNote.BackColor = System.Drawing.Color.OrangeRed;
            this.removeNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeNote.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeNote.ForeColor = System.Drawing.Color.White;
            this.removeNote.Location = new System.Drawing.Point(907, 353);
            this.removeNote.Name = "removeNote";
            this.removeNote.Size = new System.Drawing.Size(157, 50);
            this.removeNote.TabIndex = 7;
            this.removeNote.Text = "Remove Note";
            this.removeNote.UseVisualStyleBackColor = false;
            this.removeNote.Click += new System.EventHandler(this.removeNote_Click);
            // 
            // removeAllNotes
            // 
            this.removeAllNotes.BackColor = System.Drawing.Color.OrangeRed;
            this.removeAllNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeAllNotes.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAllNotes.ForeColor = System.Drawing.Color.White;
            this.removeAllNotes.Location = new System.Drawing.Point(1085, 353);
            this.removeAllNotes.Name = "removeAllNotes";
            this.removeAllNotes.Size = new System.Drawing.Size(203, 50);
            this.removeAllNotes.TabIndex = 8;
            this.removeAllNotes.Text = "Remove All Notes";
            this.removeAllNotes.UseVisualStyleBackColor = false;
            this.removeAllNotes.Click += new System.EventHandler(this.removeAllNotes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(71, 558);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Number of notes:";
            // 
            // lblNumOfNotes
            // 
            this.lblNumOfNotes.AutoSize = true;
            this.lblNumOfNotes.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.lblNumOfNotes.ForeColor = System.Drawing.Color.LightCyan;
            this.lblNumOfNotes.Location = new System.Drawing.Point(223, 558);
            this.lblNumOfNotes.Name = "lblNumOfNotes";
            this.lblNumOfNotes.Size = new System.Drawing.Size(23, 25);
            this.lblNumOfNotes.TabIndex = 10;
            this.lblNumOfNotes.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1357, 767);
            this.Controls.Add(this.lblNumOfNotes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.removeAllNotes);
            this.Controls.Add(this.removeNote);
            this.Controls.Add(this.addNote);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.lblProgressValue);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.tvNotes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvNotes;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label lblProgressValue;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNote;
        private System.Windows.Forms.Button removeNote;
        private System.Windows.Forms.Button removeAllNotes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumOfNotes;
    }
}

