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
            this.btnMap = new System.Windows.Forms.Button();
            this.btnPopulasi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMap
            // 
            this.btnMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnMap.Location = new System.Drawing.Point(426, 252);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(438, 157);
            this.btnMap.TabIndex = 0;
            this.btnMap.Text = "INPUT MAP";
            this.btnMap.UseVisualStyleBackColor = true;
            // 
            // btnPopulasi
            // 
            this.btnPopulasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnPopulasi.Location = new System.Drawing.Point(1000, 252);
            this.btnPopulasi.Name = "btnPopulasi";
            this.btnPopulasi.Size = new System.Drawing.Size(438, 157);
            this.btnPopulasi.TabIndex = 1;
            this.btnPopulasi.Text = "INPUT POPULASI";
            this.btnPopulasi.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnPopulasi);
            this.Controls.Add(this.btnMap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnPopulasi;
    }
}