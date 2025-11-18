namespace _200038_20371.Views
{
    partial class FrmCaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtVenda = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtDinheiro = new System.Windows.Forms.TextBox();
            this.txtCheque = new System.Windows.Forms.TextBox();
            this.txtCartao = new System.Windows.Forms.TextBox();
            this.txtPIX = new System.Windows.Forms.TextBox();
            this.txtBoleto = new System.Windows.Forms.TextBox();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCaixa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Venda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Troco:";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(72, 31);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 1;
            this.txtIdCliente.Text = "0";
            // 
            // txtVenda
            // 
            this.txtVenda.Location = new System.Drawing.Point(72, 77);
            this.txtVenda.Name = "txtVenda";
            this.txtVenda.Size = new System.Drawing.Size(100, 20);
            this.txtVenda.TabIndex = 1;
            this.txtVenda.Text = "0";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(238, 77);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(119, 20);
            this.txtValor.TabIndex = 1;
            this.txtValor.Text = "R$ 0,00";
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(187, 31);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(398, 20);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // txtDinheiro
            // 
            this.txtDinheiro.Location = new System.Drawing.Point(107, 121);
            this.txtDinheiro.Multiline = true;
            this.txtDinheiro.Name = "txtDinheiro";
            this.txtDinheiro.Size = new System.Drawing.Size(231, 46);
            this.txtDinheiro.TabIndex = 1;
            this.txtDinheiro.TextChanged += new System.EventHandler(this.txtDinheiro_TextChanged);
            // 
            // txtCheque
            // 
            this.txtCheque.Location = new System.Drawing.Point(107, 173);
            this.txtCheque.Multiline = true;
            this.txtCheque.Name = "txtCheque";
            this.txtCheque.Size = new System.Drawing.Size(231, 46);
            this.txtCheque.TabIndex = 1;
            this.txtCheque.TextChanged += new System.EventHandler(this.txtCheque_TextChanged);
            // 
            // txtCartao
            // 
            this.txtCartao.Location = new System.Drawing.Point(107, 225);
            this.txtCartao.Multiline = true;
            this.txtCartao.Name = "txtCartao";
            this.txtCartao.Size = new System.Drawing.Size(231, 46);
            this.txtCartao.TabIndex = 1;
            this.txtCartao.TextChanged += new System.EventHandler(this.txtCartao_TextChanged);
            // 
            // txtPIX
            // 
            this.txtPIX.Location = new System.Drawing.Point(107, 277);
            this.txtPIX.Multiline = true;
            this.txtPIX.Name = "txtPIX";
            this.txtPIX.Size = new System.Drawing.Size(231, 46);
            this.txtPIX.TabIndex = 1;
            this.txtPIX.TextChanged += new System.EventHandler(this.txtPIX_TextChanged);
            // 
            // txtBoleto
            // 
            this.txtBoleto.Location = new System.Drawing.Point(107, 329);
            this.txtBoleto.Multiline = true;
            this.txtBoleto.Name = "txtBoleto";
            this.txtBoleto.Size = new System.Drawing.Size(231, 46);
            this.txtBoleto.TabIndex = 1;
            this.txtBoleto.TextChanged += new System.EventHandler(this.txtBoleto_TextChanged);
            // 
            // txtTroco
            // 
            this.txtTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTroco.Location = new System.Drawing.Point(107, 396);
            this.txtTroco.Multiline = true;
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(231, 31);
            this.txtTroco.TabIndex = 1;
            this.txtTroco.Text = "R$ 0,00";
            this.txtTroco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_200038_20371.Properties.Resources.PagtoBoleto;
            this.pictureBox5.Location = new System.Drawing.Point(50, 329);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(51, 46);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_200038_20371.Properties.Resources.PagtoPIX;
            this.pictureBox4.Location = new System.Drawing.Point(50, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(51, 46);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_200038_20371.Properties.Resources.PagtoCartao;
            this.pictureBox3.Location = new System.Drawing.Point(50, 225);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(51, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::_200038_20371.Properties.Resources.PagtoCheque;
            this.pictureBox2.Location = new System.Drawing.Point(50, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_200038_20371.Properties.Resources.PagtoDinheiro;
            this.pictureBox1.Location = new System.Drawing.Point(50, 121);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnCaixa
            // 
            this.btnCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Image = global::_200038_20371.Properties.Resources.pngwing;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaixa.Location = new System.Drawing.Point(372, 432);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(213, 83);
            this.btnCaixa.TabIndex = 2;
            this.btnCaixa.Text = "Realizar\r\nPagamento";
            this.btnCaixa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // FrmCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 530);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCaixa);
            this.Controls.Add(this.txtTroco);
            this.Controls.Add(this.txtBoleto);
            this.Controls.Add(this.txtPIX);
            this.Controls.Add(this.txtCartao);
            this.Controls.Add(this.txtCheque);
            this.Controls.Add(this.txtDinheiro);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.txtVenda);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCaixa";
            this.Text = "FrmCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtVenda;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtDinheiro;
        private System.Windows.Forms.TextBox txtCheque;
        private System.Windows.Forms.TextBox txtCartao;
        private System.Windows.Forms.TextBox txtPIX;
        private System.Windows.Forms.TextBox txtBoleto;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}