namespace LocadoraClassic.View
{
    partial class FrmTelaGenero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaGenero));
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CadastrarGenero = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgGenero = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(198, 167);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(520, 20);
            this.txtGenero.TabIndex = 2;
            this.txtGenero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(371, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 34);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cadastrar Gênero";
            // 
            // CadastrarGenero
            // 
            this.CadastrarGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CadastrarGenero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CadastrarGenero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.CadastrarGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarGenero.ForeColor = System.Drawing.Color.White;
            this.CadastrarGenero.Location = new System.Drawing.Point(198, 505);
            this.CadastrarGenero.Name = "CadastrarGenero";
            this.CadastrarGenero.Size = new System.Drawing.Size(249, 21);
            this.CadastrarGenero.TabIndex = 23;
            this.CadastrarGenero.Text = "Cadastrar";
            this.CadastrarGenero.UseVisualStyleBackColor = false;
            this.CadastrarGenero.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Nome do Gênero";
            // 
            // dvgGenero
            // 
            this.dvgGenero.BackgroundColor = System.Drawing.Color.White;
            this.dvgGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgGenero.GridColor = System.Drawing.Color.White;
            this.dvgGenero.Location = new System.Drawing.Point(198, 193);
            this.dvgGenero.Name = "dvgGenero";
            this.dvgGenero.Size = new System.Drawing.Size(520, 306);
            this.dvgGenero.TabIndex = 25;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(453, 505);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(265, 21);
            this.BtnExcluir.TabIndex = 26;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.Btn_Excluir);
            // 
            // Alterar
            // 
            this.Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alterar.ForeColor = System.Drawing.Color.White;
            this.Alterar.Location = new System.Drawing.Point(453, 532);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(265, 21);
            this.Alterar.TabIndex = 30;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = false;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // FrmTelaGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 682);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.dvgGenero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CadastrarGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(907, 682);
            this.MinimumSize = new System.Drawing.Size(907, 682);
            this.Name = "FrmTelaGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Gênero";
            this.Load += new System.EventHandler(this.FrmTelaGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgGenero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CadastrarGenero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgGenero;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button Alterar;
    }
}