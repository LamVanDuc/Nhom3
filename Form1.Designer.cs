namespace Dictionary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Code", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(177, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "English Dictionary";
            // 
            // inputbox
            // 
            this.inputbox.Location = new System.Drawing.Point(109, 164);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(389, 27);
            this.inputbox.TabIndex = 1;
            // 
            // resultbox
            // 
            this.resultbox.Location = new System.Drawing.Point(109, 245);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(605, 134);
            this.resultbox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Fira Code", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(572, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox inputbox;
        private TextBox resultbox;
        private Button button1;
    }
}