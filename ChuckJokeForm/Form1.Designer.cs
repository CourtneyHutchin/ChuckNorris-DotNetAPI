namespace ChuckJokeForm
{
    partial class JokeForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.JokeLbl = new System.Windows.Forms.Label();
            this.CategoryCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Joke";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GetJoke_Click);
            // 
            // JokeLbl
            // 
            this.JokeLbl.AutoSize = true;
            this.JokeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JokeLbl.Location = new System.Drawing.Point(40, 129);
            this.JokeLbl.Name = "JokeLbl";
            this.JokeLbl.Size = new System.Drawing.Size(0, 16);
            this.JokeLbl.TabIndex = 1;
            this.JokeLbl.UseMnemonic = false;
            // 
            // CategoryCBox
            // 
            this.CategoryCBox.FormattingEnabled = true;
            this.CategoryCBox.Location = new System.Drawing.Point(32, 23);
            this.CategoryCBox.Name = "CategoryCBox";
            this.CategoryCBox.Size = new System.Drawing.Size(182, 21);
            this.CategoryCBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 224);
            this.Controls.Add(this.CategoryCBox);
            this.Controls.Add(this.JokeLbl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label JokeLbl;
        private System.Windows.Forms.ComboBox CategoryCBox;
    }
}

