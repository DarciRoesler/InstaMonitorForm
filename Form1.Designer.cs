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
            this.SeguindoLstBx = new System.Windows.Forms.ListBox();
            this.SeguindoLbl = new System.Windows.Forms.Label();
            this.SeguidoresLbl = new System.Windows.Forms.Label();
            this.SeguidoresLstBx = new System.Windows.Forms.ListBox();
            this.NaoSigoLbl = new System.Windows.Forms.Label();
            this.NaoSigoLstBx = new System.Windows.Forms.ListBox();
            this.NaoSeguemLbl = new System.Windows.Forms.Label();
            this.NaoSeguemLstBx = new System.Windows.Forms.ListBox();
            this.HistoricoLstBx = new System.Windows.Forms.ListBox();
            this.HistoricoLbl = new System.Windows.Forms.Label();
            this.NomeUsuarioLbl = new System.Windows.Forms.Label();
            this.DataDtp = new System.Windows.Forms.DateTimePicker();
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
            // SeguindoLstBx
            // 
            this.SeguindoLstBx.FormattingEnabled = true;
            this.SeguindoLstBx.ItemHeight = 15;
            this.SeguindoLstBx.Location = new System.Drawing.Point(12, 56);
            this.SeguindoLstBx.Name = "SeguindoLstBx";
            this.SeguindoLstBx.Size = new System.Drawing.Size(134, 289);
            this.SeguindoLstBx.TabIndex = 1;
            this.SeguindoLstBx.SelectedIndexChanged += new System.EventHandler(this.SeguindoLstBx_SelectedIndexChanged);
            // 
            // SeguindoLbl
            // 
            this.SeguindoLbl.AutoSize = true;
            this.SeguindoLbl.Location = new System.Drawing.Point(12, 38);
            this.SeguindoLbl.Name = "SeguindoLbl";
            this.SeguindoLbl.Size = new System.Drawing.Size(57, 15);
            this.SeguindoLbl.TabIndex = 3;
            this.SeguindoLbl.Text = "Seguindo";
            // 
            // SeguidoresLbl
            // 
            this.SeguidoresLbl.AutoSize = true;
            this.SeguidoresLbl.Location = new System.Drawing.Point(152, 38);
            this.SeguidoresLbl.Name = "SeguidoresLbl";
            this.SeguidoresLbl.Size = new System.Drawing.Size(65, 15);
            this.SeguidoresLbl.TabIndex = 5;
            this.SeguidoresLbl.Text = "Seguidores";
            // 
            // SeguidoresLstBx
            // 
            this.SeguidoresLstBx.FormattingEnabled = true;
            this.SeguidoresLstBx.ItemHeight = 15;
            this.SeguidoresLstBx.Location = new System.Drawing.Point(152, 56);
            this.SeguidoresLstBx.Name = "SeguidoresLstBx";
            this.SeguidoresLstBx.Size = new System.Drawing.Size(134, 289);
            this.SeguidoresLstBx.TabIndex = 4;
            this.SeguidoresLstBx.SelectedIndexChanged += new System.EventHandler(this.SeguidoresLstBx_SelectedIndexChanged);
            // 
            // NaoSigoLbl
            // 
            this.NaoSigoLbl.AutoSize = true;
            this.NaoSigoLbl.Location = new System.Drawing.Point(292, 38);
            this.NaoSigoLbl.Name = "NaoSigoLbl";
            this.NaoSigoLbl.Size = new System.Drawing.Size(99, 15);
            this.NaoSigoLbl.TabIndex = 7;
            this.NaoSigoLbl.Text = "Não sigo de volta";
            // 
            // NaoSigoLstBx
            // 
            this.NaoSigoLstBx.FormattingEnabled = true;
            this.NaoSigoLstBx.ItemHeight = 15;
            this.NaoSigoLstBx.Location = new System.Drawing.Point(292, 56);
            this.NaoSigoLstBx.Name = "NaoSigoLstBx";
            this.NaoSigoLstBx.Size = new System.Drawing.Size(134, 289);
            this.NaoSigoLstBx.TabIndex = 6;
            this.NaoSigoLstBx.SelectedIndexChanged += new System.EventHandler(this.NaoSigoLstBx_SelectedIndexChanged);
            // 
            // NaoSeguemLbl
            // 
            this.NaoSeguemLbl.AutoSize = true;
            this.NaoSeguemLbl.Location = new System.Drawing.Point(432, 38);
            this.NaoSeguemLbl.Name = "NaoSeguemLbl";
            this.NaoSeguemLbl.Size = new System.Drawing.Size(119, 15);
            this.NaoSeguemLbl.TabIndex = 9;
            this.NaoSeguemLbl.Text = "Não seguem de volta";
            // 
            // NaoSeguemLstBx
            // 
            this.NaoSeguemLstBx.FormattingEnabled = true;
            this.NaoSeguemLstBx.ItemHeight = 15;
            this.NaoSeguemLstBx.Location = new System.Drawing.Point(432, 56);
            this.NaoSeguemLstBx.Name = "NaoSeguemLstBx";
            this.NaoSeguemLstBx.Size = new System.Drawing.Size(134, 289);
            this.NaoSeguemLstBx.TabIndex = 8;
            this.NaoSeguemLstBx.SelectedIndexChanged += new System.EventHandler(this.NaoSeguemLstBx_SelectedIndexChanged);
            // 
            // HistoricoLstBx
            // 
            this.HistoricoLstBx.FormattingEnabled = true;
            this.HistoricoLstBx.ItemHeight = 15;
            this.HistoricoLstBx.Location = new System.Drawing.Point(572, 56);
            this.HistoricoLstBx.Name = "HistoricoLstBx";
            this.HistoricoLstBx.Size = new System.Drawing.Size(400, 289);
            this.HistoricoLstBx.TabIndex = 10;
            // 
            // HistoricoLbl
            // 
            this.HistoricoLbl.AutoSize = true;
            this.HistoricoLbl.Location = new System.Drawing.Point(772, 38);
            this.HistoricoLbl.Name = "HistoricoLbl";
            this.HistoricoLbl.Size = new System.Drawing.Size(120, 15);
            this.HistoricoLbl.TabIndex = 11;
            this.HistoricoLbl.Text = "Histórico do usuário: ";
            // 
            // NomeUsuarioLbl
            // 
            this.NomeUsuarioLbl.AutoSize = true;
            this.NomeUsuarioLbl.Location = new System.Drawing.Point(886, 38);
            this.NomeUsuarioLbl.Name = "NomeUsuarioLbl";
            this.NomeUsuarioLbl.Size = new System.Drawing.Size(82, 15);
            this.NomeUsuarioLbl.TabIndex = 12;
            this.NomeUsuarioLbl.Text = "_______________";
            // 
            // DataDtp
            // 
            this.DataDtp.Location = new System.Drawing.Point(772, 12);
            this.DataDtp.Name = "DataDtp";
            this.DataDtp.Size = new System.Drawing.Size(200, 23);
            this.DataDtp.TabIndex = 13;
            this.DataDtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // HomeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.DataDtp);
            this.Controls.Add(this.NomeUsuarioLbl);
            this.Controls.Add(this.HistoricoLbl);
            this.Controls.Add(this.HistoricoLstBx);
            this.Controls.Add(this.NaoSeguemLbl);
            this.Controls.Add(this.NaoSeguemLstBx);
            this.Controls.Add(this.NaoSigoLbl);
            this.Controls.Add(this.NaoSigoLstBx);
            this.Controls.Add(this.SeguidoresLbl);
            this.Controls.Add(this.SeguidoresLstBx);
            this.Controls.Add(this.SeguindoLbl);
            this.Controls.Add(this.SeguindoLstBx);
            this.Controls.Add(this.AtualizarBtn);
            this.Name = "HomeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstaMonitor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AtualizarBtn;
        private ListBox SeguindoLstBx;
        private Label SeguindoLbl;
        private Label SeguidoresLbl;
        private ListBox SeguidoresLstBx;
        private Label NaoSigoLbl;
        private ListBox NaoSigoLstBx;
        private Label NaoSeguemLbl;
        private ListBox NaoSeguemLstBx;
        private ListBox HistoricoLstBx;
        private Label HistoricoLbl;
        private Label NomeUsuarioLbl;
        private DateTimePicker DataDtp;
    }
}