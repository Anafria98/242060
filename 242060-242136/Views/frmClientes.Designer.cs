namespace _200038_20371.Views
{
    partial class frmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.txtiD = new System.Windows.Forms.TextBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.chkBloqueia = new System.Windows.Forms.CheckBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picFoto = new System.Windows.Forms.PictureBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpNasc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtiD
            // 
            this.txtiD.Location = new System.Drawing.Point(23, 39);
            this.txtiD.Name = "txtiD";
            this.txtiD.ReadOnly = true;
            this.txtiD.Size = new System.Drawing.Size(100, 20);
            this.txtiD.TabIndex = 3;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Location = new System.Drawing.Point(26, 20);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(43, 13);
            this.lbltext.TabIndex = 2;
            this.lbltext.Text = "Código:";
            // 
            // chkBloqueia
            // 
            this.chkBloqueia.AutoSize = true;
            this.chkBloqueia.Location = new System.Drawing.Point(178, 40);
            this.chkBloqueia.Name = "chkBloqueia";
            this.chkBloqueia.Size = new System.Drawing.Size(115, 17);
            this.chkBloqueia.TabIndex = 4;
            this.chkBloqueia.Text = "Bloqueia a venda?";
            this.chkBloqueia.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 97);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(522, 20);
            this.txtNome.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // picFoto
            // 
            this.picFoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picFoto.Image = ((System.Drawing.Image)(resources.GetObject("picFoto.Image")));
            this.picFoto.Location = new System.Drawing.Point(610, 40);
            this.picFoto.Name = "picFoto";
            this.picFoto.Size = new System.Drawing.Size(135, 133);
            this.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFoto.TabIndex = 7;
            this.picFoto.TabStop = false;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(23, 152);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(443, 21);
            this.cmbCidade.TabIndex = 8;
            this.cmbCidade.SelectedIndexChanged += new System.EventHandler(this.cmbCidade_SelectedIndexChanged);
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(472, 153);
            this.txtUF.Name = "txtUF";
            this.txtUF.ReadOnly = true;
            this.txtUF.Size = new System.Drawing.Size(73, 20);
            this.txtUF.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "UF:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(23, 209);
            this.mskCPF.Mask = "999.999.999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(146, 20);
            this.mskCPF.TabIndex = 12;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(566, 209);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(100, 20);
            this.txtRenda.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Renda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "CPF:";
            // 
            // dtpNasc
            // 
            this.dtpNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNasc.Location = new System.Drawing.Point(243, 209);
            this.dtpNasc.Name = "dtpNasc";
            this.dtpNasc.Size = new System.Drawing.Size(200, 20);
            this.dtpNasc.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data de nascimento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.txtPesquisar);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(12, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 240);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::_200038_20371.Properties.Resources._7_pesquisar;
            this.btnConsultar.Location = new System.Drawing.Point(644, 16);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(83, 54);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(9, 50);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(629, 20);
            this.txtPesquisar.TabIndex = 13;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToOrderColumns = true;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(9, 79);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(718, 155);
            this.dgvClientes.TabIndex = 4;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Digite o nome da Cidade para Pesquisar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 23;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::_200038_20371.Properties.Resources._7_atualizar2;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(203, 248);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(114, 54);
            this.btnAlterar.TabIndex = 22;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::_200038_20371.Properties.Resources._1_cancelar2;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(323, 248);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 54);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::_200038_20371.Properties.Resources._5_excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(443, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 54);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Image = global::_200038_20371.Properties.Resources._6_fechar;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(563, 248);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(114, 54);
            this.btnFechar.TabIndex = 19;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Image = global::_200038_20371.Properties.Resources._3_add;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(74, 248);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(123, 54);
            this.btnIncluir.TabIndex = 18;
            this.btnIncluir.Text = "incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 593);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpNasc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUF);
            this.Controls.Add(this.cmbCidade);
            this.Controls.Add(this.picFoto);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkBloqueia);
            this.Controls.Add(this.txtiD);
            this.Controls.Add(this.lbltext);
            this.Name = "frmClientes";
            this.Text = "Cadastro de clientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtiD;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.CheckBox chkBloqueia;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picFoto;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
    }
}