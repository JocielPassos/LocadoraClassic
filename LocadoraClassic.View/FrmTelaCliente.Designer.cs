namespace LocadoraClassic.View
{
    partial class FrmTelaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaCliente));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgCliente = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(307, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(280, 20);
            this.txtNome.TabIndex = 5;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNomeCliente_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(430, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(307, 167);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(280, 20);
            this.txtEndereco.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Endereço";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Celular";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(307, 257);
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(280, 20);
            this.txtRg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RG";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "CPF";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(370, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 34);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cadastrar Cliente";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(307, 218);
            this.txtCelular.Mask = "(00) 00000-0000 ";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(280, 20);
            this.txtCelular.TabIndex = 23;
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(307, 302);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(280, 20);
            this.txtCpf.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(307, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 22);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cadastrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvgCliente
            // 
            this.dvgCliente.BackgroundColor = System.Drawing.Color.White;
            this.dvgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCliente.GridColor = System.Drawing.Color.White;
            this.dvgCliente.Location = new System.Drawing.Point(12, 416);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.Size = new System.Drawing.Size(883, 254);
            this.dvgCliente.TabIndex = 26;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExcluir.ForeColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(307, 375);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(280, 21);
            this.BtnExcluir.TabIndex = 27;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // FrmTelaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 682);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.dvgCliente);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTelaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dvgCliente;
        private System.Windows.Forms.Button BtnExcluir;
    }
}