namespace InstaMonitorForm
{
    partial class HomeFrm
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
            this.AtualizarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AtualizarBtn
            // 
            this.AtualizarBtn.Location = new System.Drawing.Point(12, 12);
            this.AtualizarBtn.Name = "AtualizarBtn";
            this.AtualizarBtn.Size = new System.Drawing.Size(75, 23);
            this.AtualizarBtn.TabIndex = 0;
            this.AtualizarBtn.Text = "Atualizar";
            this.AtualizarBtn.UseVisualStyleBackColor = true;
            this.AtualizarBtn.Click += new System.EventHandler(this.AtualizarBtn_Click);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.AtualizarBtn);
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstaMonitor";
            this.ResumeLayout(false);

        }

        #endregion

        private Button AtualizarBtn;
    }
}