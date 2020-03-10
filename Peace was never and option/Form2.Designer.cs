namespace Peace_was_never_and_option
{
    partial class Form2
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
            this.SELAMATDATANG = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(1673, 1016);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 67);
            this.button1.TabIndex = 0;
            this.button1.Text = "RETURN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SELAMATDATANG
            // 
            this.SELAMATDATANG.AutoSize = true;
            this.SELAMATDATANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.SELAMATDATANG.Location = new System.Drawing.Point(487, 162);
            this.SELAMATDATANG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SELAMATDATANG.Name = "SELAMATDATANG";
            this.SELAMATDATANG.Size = new System.Drawing.Size(852, 42);
            this.SELAMATDATANG.TabIndex = 1;
            this.SELAMATDATANG.Text = "Masukkan hari ke berapa yang ingin kamu periksa";
            this.SELAMATDATANG.Click += new System.EventHandler(this.SELAMATDATANG_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F);
            this.richTextBox1.Location = new System.Drawing.Point(769, 241);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(259, 239);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnApply.Location = new System.Drawing.Point(1408, 1016);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(259, 67);
            this.btnApply.TabIndex = 3;
            this.btnApply.Text = "APPLY";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SELAMATDATANG);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SELAMATDATANG;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnApply;
    }
}