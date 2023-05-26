namespace LocadoraClassic.View
{
    partial class FrmTelaCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaCategoria));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorDiaria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgCategoria = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.Alterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(311, 192);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorDiaria
            // 
            this.txtValorDiaria.Location = new System.Drawing.Point(311, 250);
            this.txtValorDiaria.Name = "txtValorDiaria";
            this.txtValorDiaria.Size = new System.Drawing.Size(280, 20);
            this.txtValorDiaria.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(414, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor da diária";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(356, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cadastrar Categoria";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(311, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 22);
            this.button2.TabIndex = 24;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvgCategoria
            // 
            this.dvgCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dvgCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategoria.GridColor = System.Drawing.Color.White;
            this.dvgCategoria.Location = new System.Drawing.Point(12, 416);
            this.dvgCategoria.Name = "dvgCategoria";
            this.dvgCategoria.Size = new System.Drawing.Size(883, 254);
            this.dvgCategoria.TabIndex = 27;
            this.dvgCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCategoria_CellContentClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(452, 338);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(139, 21);
            this.BtnExcluir.TabIndex = 28;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Alterar
            // 
            this.Alterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Alterar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alterar.ForeColor = System.Drawing.Color.White;
            this.Alterar.Location = new System.Drawing.Point(311, 338);
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(135, 21);
            this.Alterar.TabIndex = 29;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseVisualStyleBackColor = false;
            this.Alterar.Click += new System.EventHandler(this.Alterar_Click);
            // 
            // FrmTelaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 682);
            this.Controls.Add(this.Alterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.dvgCategoria);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorDiaria);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorDiaria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvgCategoria;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button Alterar;
    }
}