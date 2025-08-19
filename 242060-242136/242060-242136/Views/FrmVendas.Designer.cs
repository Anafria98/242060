namespace _242136_e_242060.Views
{
    partial class FrmVendas
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
            this.grbClientes = new System.Windows.Forms.GroupBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.mskDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.chkVenda = new System.Windows.Forms.CheckBox();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picCliente = new System.Windows.Forms.PictureBox();
            this.grbProdutos = new System.Windows.Forms.GroupBox();
            this.cboProdutos = new System.Windows.Forms.ComboBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picProduto = new System.Windows.Forms.PictureBox();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.grbClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).BeginInit();
            this.grbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbClientes
            // 
            this.grbClientes.Controls.Add(this.mskCPF);
            this.grbClientes.Controls.Add(this.mskDataNasc);
            this.grbClientes.Controls.Add(this.cboClientes);
            this.grbClientes.Controls.Add(this.btnConfirmar);
            this.grbClientes.Controls.Add(this.chkVenda);
            this.grbClientes.Controls.Add(this.txtRenda);
            this.grbClientes.Controls.Add(this.txtUF);
            this.grbClientes.Controls.Add(this.txtCidade);
            this.grbClientes.Controls.Add(this.label5);
            this.grbClientes.Controls.Add(this.label4);
            this.grbClientes.Controls.Add(this.label3);
            this.grbClientes.Controls.Add(this.label2);
            this.grbClientes.Controls.Add(this.label1);
            this.grbClientes.Location = new System.Drawing.Point(20, 15);
            this.grbClientes.Margin = new System.Windows.Forms.Padding(4);
            this.grbClientes.Name = "grbClientes";
            this.grbClientes.Padding = new System.Windows.Forms.Padding(4);
            this.grbClientes.Size = new System.Drawing.Size(712, 218);
            this.grbClientes.TabIndex = 8;
            this.grbClientes.TabStop = false;
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(311, 110);
            this.mskCPF.Margin = new System.Windows.Forms.Padding(4);
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(187, 22);
            this.mskCPF.TabIndex = 22;
            // 
            // mskDataNasc
            // 
            this.mskDataNasc.Location = new System.Drawing.Point(108, 110);
            this.mskDataNasc.Margin = new System.Windows.Forms.Padding(4);
            this.mskDataNasc.Name = "mskDataNasc";
            this.mskDataNasc.Size = new System.Drawing.Size(132, 22);
            this.mskDataNasc.TabIndex = 21;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(79, 27);
            this.cboClientes.Margin = new System.Windows.Forms.Padding(4);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(624, 24);
            this.cboClientes.TabIndex = 20;
            this.cboClientes.SelectedIndexChanged += new System.EventHandler(this.cboClientes_SelectedIndexChanged);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(571, 153);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(133, 49);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // chkVenda
            // 
            this.chkVenda.AutoSize = true;
            this.chkVenda.Location = new System.Drawing.Point(69, 169);
            this.chkVenda.Margin = new System.Windows.Forms.Padding(4);
            this.chkVenda.Name = "chkVenda";
            this.chkVenda.Size = new System.Drawing.Size(135, 20);
            this.chkVenda.TabIndex = 18;
            this.chkVenda.Text = "Bloqueia a venda";
            this.chkVenda.UseVisualStyleBackColor = true;
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(571, 110);
            this.txtRenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(132, 22);
            this.txtRenda.TabIndex = 13;
            // 
            // txtUF
            // 
            this.txtUF.Location = new System.Drawing.Point(616, 69);
            this.txtUF.Margin = new System.Windows.Forms.Padding(4);
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(87, 22);
            this.txtUF.TabIndex = 16;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(77, 69);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(529, 22);
            this.txtCidade.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Renda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 112);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cidade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cliente:";
            // 
            // picCliente
            // 
            this.picCliente.Location = new System.Drawing.Point(740, 15);
            this.picCliente.Margin = new System.Windows.Forms.Padding(4);
            this.picCliente.Name = "picCliente";
            this.picCliente.Size = new System.Drawing.Size(244, 218);
            this.picCliente.TabIndex = 9;
            this.picCliente.TabStop = false;
            // 
            // grbProdutos
            // 
            this.grbProdutos.Controls.Add(this.cboProdutos);
            this.grbProdutos.Controls.Add(this.btnRemover);
            this.grbProdutos.Controls.Add(this.btnInserir);
            this.grbProdutos.Controls.Add(this.label11);
            this.grbProdutos.Controls.Add(this.label10);
            this.grbProdutos.Controls.Add(this.txtEstoque);
            this.grbProdutos.Controls.Add(this.txtPreco);
            this.grbProdutos.Controls.Add(this.txtQuantidade);
            this.grbProdutos.Controls.Add(this.txtCategoria);
            this.grbProdutos.Controls.Add(this.txtMarca);
            this.grbProdutos.Controls.Add(this.label9);
            this.grbProdutos.Controls.Add(this.label8);
            this.grbProdutos.Controls.Add(this.label7);
            this.grbProdutos.Controls.Add(this.label6);
            this.grbProdutos.Location = new System.Drawing.Point(20, 240);
            this.grbProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProdutos.Name = "grbProdutos";
            this.grbProdutos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProdutos.Size = new System.Drawing.Size(712, 218);
            this.grbProdutos.TabIndex = 10;
            this.grbProdutos.TabStop = false;
            // 
            // cboProdutos
            // 
            this.cboProdutos.FormattingEnabled = true;
            this.cboProdutos.Location = new System.Drawing.Point(77, 28);
            this.cboProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.cboProdutos.Name = "cboProdutos";
            this.cboProdutos.Size = new System.Drawing.Size(625, 24);
            this.cboProdutos.TabIndex = 20;
            this.cboProdutos.SelectedIndexChanged += new System.EventHandler(this.cboProdutos_SelectedIndexChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(616, 144);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(88, 63);
            this.btnRemover.TabIndex = 7;
            this.btnRemover.Text = "Remover Produto";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(532, 144);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(76, 63);
            this.btnInserir.TabIndex = 7;
            this.btnInserir.Text = "Inserir Produto";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(375, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 6;
            this.label11.Text = "Estoque:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "Preço:";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(448, 144);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(75, 22);
            this.txtEstoque.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(269, 144);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(96, 22);
            this.txtPreco.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(108, 144);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(93, 22);
            this.txtQuantidade.TabIndex = 4;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(96, 102);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(607, 22);
            this.txtCategoria.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(69, 68);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(633, 22);
            this.txtMarca.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 148);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 106);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Produto:";
            // 
            // picProduto
            // 
            this.picProduto.Location = new System.Drawing.Point(740, 240);
            this.picProduto.Margin = new System.Windows.Forms.Padding(4);
            this.picProduto.Name = "picProduto";
            this.picProduto.Size = new System.Drawing.Size(244, 218);
            this.picProduto.TabIndex = 9;
            this.picProduto.TabStop = false;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToOrderColumns = true;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvProdutos.Location = new System.Drawing.Point(20, 465);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersWidth = 51;
            this.dgvProdutos.Size = new System.Drawing.Size(964, 185);
            this.dgvProdutos.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Produto";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Qtde";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Valor";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 682);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTotal.Location = new System.Drawing.Point(111, 672);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(58, 29);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0,00";
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(884, 666);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 48);
            this.btnFechar.TabIndex = 14;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(776, 666);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 48);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(668, 666);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(100, 48);
            this.btnGravar.TabIndex = 14;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 732);
            this.ControlBox = false;
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.grbProdutos);
            this.Controls.Add(this.picProduto);
            this.Controls.Add(this.picCliente);
            this.Controls.Add(this.grbClientes);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmVendas";
            this.Text = "Cancelar";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            this.grbClientes.ResumeLayout(false);
            this.grbClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCliente)).EndInit();
            this.grbProdutos.ResumeLayout(false);
            this.grbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbClientes;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.CheckBox chkVenda;
        private System.Windows.Forms.TextBox txtRenda;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCliente;
        private System.Windows.Forms.GroupBox grbProdutos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.ComboBox cboProdutos;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.PictureBox picProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.MaskedTextBox mskDataNasc;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}