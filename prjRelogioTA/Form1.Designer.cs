namespace prjRelogioTA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbRelogio = new System.Windows.Forms.PictureBox();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnPonteiro = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.mnFundo = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbRelogio
            // 
            this.pbRelogio.BackColor = System.Drawing.Color.White;
            this.pbRelogio.Location = new System.Drawing.Point(3, 27);
            this.pbRelogio.Name = "pbRelogio";
            this.pbRelogio.Size = new System.Drawing.Size(326, 287);
            this.pbRelogio.TabIndex = 0;
            this.pbRelogio.TabStop = false;
            // 
            // relogio
            // 
            this.relogio.Enabled = true;
            this.relogio.Interval = 1000;
            this.relogio.Tick += new System.EventHandler(this.relogio_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnPonteiro,
            this.mnFundo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(329, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Tag = "";
            this.menuStrip1.Text = "menu";
            // 
            // mnPonteiro
            // 
            this.mnPonteiro.Name = "mnPonteiro";
            this.mnPonteiro.Size = new System.Drawing.Size(64, 20);
            this.mnPonteiro.Text = "Ponteiro";
            this.mnPonteiro.Click += new System.EventHandler(this.mnPonteiro_Click);
            // 
            // mnFundo
            // 
            this.mnFundo.Name = "mnFundo";
            this.mnFundo.Size = new System.Drawing.Size(53, 20);
            this.mnFundo.Text = "Fundo";
            this.mnFundo.Click += new System.EventHandler(this.mnFundo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Imagens*.BMP;*JPG;*.PNG";
            this.openFileDialog1.FilterIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 334);
            this.Controls.Add(this.pbRelogio);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Relogio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbRelogio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRelogio;
        private System.Windows.Forms.Timer relogio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnPonteiro;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem mnFundo;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

