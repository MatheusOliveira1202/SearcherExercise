namespace SearcherProject
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
            this.buttonLinear = new System.Windows.Forms.Button();
            this.buttonBinary = new System.Windows.Forms.Button();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.Searcher = new System.Windows.Forms.TextBox();
            this.labelNotifications = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLinear
            // 
            this.buttonLinear.Location = new System.Drawing.Point(400, 12);
            this.buttonLinear.Name = "buttonLinear";
            this.buttonLinear.Size = new System.Drawing.Size(277, 67);
            this.buttonLinear.TabIndex = 0;
            this.buttonLinear.Text = "Procurar de forma linear";
            this.buttonLinear.UseVisualStyleBackColor = true;
            this.buttonLinear.Click += new System.EventHandler(this.SearchLinear_Click);
            // 
            // buttonBinary
            // 
            this.buttonBinary.Location = new System.Drawing.Point(400, 243);
            this.buttonBinary.Name = "buttonBinary";
            this.buttonBinary.Size = new System.Drawing.Size(277, 67);
            this.buttonBinary.TabIndex = 1;
            this.buttonBinary.Text = "Procurar de forma binária";
            this.buttonBinary.UseVisualStyleBackColor = true;
            this.buttonBinary.Click += new System.EventHandler(this.SearchBinary_Click);
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(39, 93);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(330, 212);
            this.listBoxNumbers.TabIndex = 2;
            // 
            // Searcher
            // 
            this.Searcher.Location = new System.Drawing.Point(39, 23);
            this.Searcher.Name = "Searcher";
            this.Searcher.Size = new System.Drawing.Size(188, 20);
            this.Searcher.TabIndex = 3;
            // 
            // labelNotifications
            // 
            this.labelNotifications.AutoSize = true;
            this.labelNotifications.Location = new System.Drawing.Point(400, 93);
            this.labelNotifications.Name = "labelNotifications";
            this.labelNotifications.Size = new System.Drawing.Size(35, 13);
            this.labelNotifications.TabIndex = 4;
            this.labelNotifications.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 322);
            this.Controls.Add(this.labelNotifications);
            this.Controls.Add(this.Searcher);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.buttonBinary);
            this.Controls.Add(this.buttonLinear);
            this.Name = "Form1";
            this.Text = "Searcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLinear;
        private System.Windows.Forms.Button buttonBinary;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.TextBox Searcher;
        private System.Windows.Forms.Label labelNotifications;
    }
}

