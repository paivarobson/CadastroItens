
namespace CadastroItensCompra
{
    partial class CadastroCompra
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCompra = new System.Windows.Forms.GroupBox();
            this.rtbObservacaoCompra = new System.Windows.Forms.RichTextBox();
            this.cbFormaPagamentoCompra = new System.Windows.Forms.ComboBox();
            this.lblFormaPagamentoCompra = new System.Windows.Forms.Label();
            this.cbLojaCompra = new System.Windows.Forms.ComboBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.lblDataCompra = new System.Windows.Forms.Label();
            this.lblLojaCompra = new System.Windows.Forms.Label();
            this.lblValorTotalCompra = new System.Windows.Forms.Label();
            this.lblObservacaoCompra = new System.Windows.Forms.Label();
            this.txtValorTotalCompra = new System.Windows.Forms.TextBox();
            this.lblQuantidadeTotalItensCompra = new System.Windows.Forms.Label();
            this.txtQuantidadeTotalItensCompra = new System.Windows.Forms.TextBox();
            this.lbCodigoCompra = new System.Windows.Forms.Label();
            this.txtCodigoCompra = new System.Windows.Forms.TextBox();
            this.gbItemCompra = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblCodigoItemLojaCompra = new System.Windows.Forms.Label();
            this.lblValorItemCompra = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblQuantidadeItemCompra = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.lblDescricaoItemCompra = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.lblCodigoItemCompra = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnNovaCompra = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbCompra.SuspendLayout();
            this.gbItemCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCompra
            // 
            this.gbCompra.Controls.Add(this.rtbObservacaoCompra);
            this.gbCompra.Controls.Add(this.cbFormaPagamentoCompra);
            this.gbCompra.Controls.Add(this.lblFormaPagamentoCompra);
            this.gbCompra.Controls.Add(this.cbLojaCompra);
            this.gbCompra.Controls.Add(this.dtpDataCompra);
            this.gbCompra.Controls.Add(this.lblDataCompra);
            this.gbCompra.Controls.Add(this.lblLojaCompra);
            this.gbCompra.Controls.Add(this.lblValorTotalCompra);
            this.gbCompra.Controls.Add(this.lblObservacaoCompra);
            this.gbCompra.Controls.Add(this.txtValorTotalCompra);
            this.gbCompra.Controls.Add(this.lblQuantidadeTotalItensCompra);
            this.gbCompra.Controls.Add(this.txtQuantidadeTotalItensCompra);
            this.gbCompra.Controls.Add(this.lbCodigoCompra);
            this.gbCompra.Controls.Add(this.txtCodigoCompra);
            this.gbCompra.Enabled = false;
            this.gbCompra.Location = new System.Drawing.Point(12, 50);
            this.gbCompra.Name = "gbCompra";
            this.gbCompra.Size = new System.Drawing.Size(701, 181);
            this.gbCompra.TabIndex = 4;
            this.gbCompra.TabStop = false;
            this.gbCompra.Text = "Compra";
            // 
            // rtbObservacaoCompra
            // 
            this.rtbObservacaoCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbObservacaoCompra.Location = new System.Drawing.Point(180, 90);
            this.rtbObservacaoCompra.Name = "rtbObservacaoCompra";
            this.rtbObservacaoCompra.Size = new System.Drawing.Size(496, 66);
            this.rtbObservacaoCompra.TabIndex = 6;
            this.rtbObservacaoCompra.Text = "";
            // 
            // cbFormaPagamentoCompra
            // 
            this.cbFormaPagamentoCompra.FormattingEnabled = true;
            this.cbFormaPagamentoCompra.Location = new System.Drawing.Point(7, 135);
            this.cbFormaPagamentoCompra.Name = "cbFormaPagamentoCompra";
            this.cbFormaPagamentoCompra.Size = new System.Drawing.Size(150, 21);
            this.cbFormaPagamentoCompra.TabIndex = 5;
            // 
            // lblFormaPagamentoCompra
            // 
            this.lblFormaPagamentoCompra.AutoSize = true;
            this.lblFormaPagamentoCompra.Location = new System.Drawing.Point(4, 119);
            this.lblFormaPagamentoCompra.Name = "lblFormaPagamentoCompra";
            this.lblFormaPagamentoCompra.Size = new System.Drawing.Size(110, 13);
            this.lblFormaPagamentoCompra.TabIndex = 17;
            this.lblFormaPagamentoCompra.Text = "Forma de pagamento:";
            // 
            // cbLojaCompra
            // 
            this.cbLojaCompra.FormattingEnabled = true;
            this.cbLojaCompra.Location = new System.Drawing.Point(48, 40);
            this.cbLojaCompra.Name = "cbLojaCompra";
            this.cbLojaCompra.Size = new System.Drawing.Size(476, 21);
            this.cbLojaCompra.TabIndex = 1;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(544, 41);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(132, 20);
            this.dtpDataCompra.TabIndex = 2;
            // 
            // lblDataCompra
            // 
            this.lblDataCompra.AutoSize = true;
            this.lblDataCompra.Location = new System.Drawing.Point(541, 25);
            this.lblDataCompra.Name = "lblDataCompra";
            this.lblDataCompra.Size = new System.Drawing.Size(33, 13);
            this.lblDataCompra.TabIndex = 13;
            this.lblDataCompra.Text = "Data:";
            // 
            // lblLojaCompra
            // 
            this.lblLojaCompra.AutoSize = true;
            this.lblLojaCompra.Location = new System.Drawing.Point(45, 24);
            this.lblLojaCompra.Name = "lblLojaCompra";
            this.lblLojaCompra.Size = new System.Drawing.Size(30, 13);
            this.lblLojaCompra.TabIndex = 11;
            this.lblLojaCompra.Text = "Loja:";
            // 
            // lblValorTotalCompra
            // 
            this.lblValorTotalCompra.AutoSize = true;
            this.lblValorTotalCompra.Location = new System.Drawing.Point(100, 74);
            this.lblValorTotalCompra.Name = "lblValorTotalCompra";
            this.lblValorTotalCompra.Size = new System.Drawing.Size(57, 13);
            this.lblValorTotalCompra.TabIndex = 9;
            this.lblValorTotalCompra.Text = "Valor total:";
            // 
            // lblObservacaoCompra
            // 
            this.lblObservacaoCompra.AutoSize = true;
            this.lblObservacaoCompra.Location = new System.Drawing.Point(177, 74);
            this.lblObservacaoCompra.Name = "lblObservacaoCompra";
            this.lblObservacaoCompra.Size = new System.Drawing.Size(68, 13);
            this.lblObservacaoCompra.TabIndex = 5;
            this.lblObservacaoCompra.Text = "Observação:";
            // 
            // txtValorTotalCompra
            // 
            this.txtValorTotalCompra.Location = new System.Drawing.Point(103, 90);
            this.txtValorTotalCompra.Name = "txtValorTotalCompra";
            this.txtValorTotalCompra.Size = new System.Drawing.Size(54, 20);
            this.txtValorTotalCompra.TabIndex = 4;
            // 
            // lblQuantidadeTotalItensCompra
            // 
            this.lblQuantidadeTotalItensCompra.AutoSize = true;
            this.lblQuantidadeTotalItensCompra.Location = new System.Drawing.Point(5, 74);
            this.lblQuantidadeTotalItensCompra.Name = "lblQuantidadeTotalItensCompra";
            this.lblQuantidadeTotalItensCompra.Size = new System.Drawing.Size(93, 13);
            this.lblQuantidadeTotalItensCompra.TabIndex = 7;
            this.lblQuantidadeTotalItensCompra.Text = "Qtd. total de itens:";
            // 
            // txtQuantidadeTotalItensCompra
            // 
            this.txtQuantidadeTotalItensCompra.Location = new System.Drawing.Point(8, 91);
            this.txtQuantidadeTotalItensCompra.Name = "txtQuantidadeTotalItensCompra";
            this.txtQuantidadeTotalItensCompra.Size = new System.Drawing.Size(83, 20);
            this.txtQuantidadeTotalItensCompra.TabIndex = 3;
            // 
            // lbCodigoCompra
            // 
            this.lbCodigoCompra.AutoSize = true;
            this.lbCodigoCompra.Location = new System.Drawing.Point(5, 25);
            this.lbCodigoCompra.Name = "lbCodigoCompra";
            this.lbCodigoCompra.Size = new System.Drawing.Size(29, 13);
            this.lbCodigoCompra.TabIndex = 1;
            this.lbCodigoCompra.Text = "Cód:";
            // 
            // txtCodigoCompra
            // 
            this.txtCodigoCompra.Enabled = false;
            this.txtCodigoCompra.Location = new System.Drawing.Point(8, 41);
            this.txtCodigoCompra.Name = "txtCodigoCompra";
            this.txtCodigoCompra.Size = new System.Drawing.Size(29, 20);
            this.txtCodigoCompra.TabIndex = 0;
            // 
            // gbItemCompra
            // 
            this.gbItemCompra.Controls.Add(this.comboBox1);
            this.gbItemCompra.Controls.Add(this.lblCodigoItemLojaCompra);
            this.gbItemCompra.Controls.Add(this.lblValorItemCompra);
            this.gbItemCompra.Controls.Add(this.textBox7);
            this.gbItemCompra.Controls.Add(this.lblQuantidadeItemCompra);
            this.gbItemCompra.Controls.Add(this.textBox8);
            this.gbItemCompra.Controls.Add(this.lblDescricaoItemCompra);
            this.gbItemCompra.Controls.Add(this.textBox9);
            this.gbItemCompra.Controls.Add(this.lblCodigoItemCompra);
            this.gbItemCompra.Controls.Add(this.textBox10);
            this.gbItemCompra.Enabled = false;
            this.gbItemCompra.Location = new System.Drawing.Point(12, 254);
            this.gbItemCompra.Name = "gbItemCompra";
            this.gbItemCompra.Size = new System.Drawing.Size(701, 91);
            this.gbItemCompra.TabIndex = 5;
            this.gbItemCompra.TabStop = false;
            this.gbItemCompra.Text = "Item de compra";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(48, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblCodigoItemLojaCompra
            // 
            this.lblCodigoItemLojaCompra.AutoSize = true;
            this.lblCodigoItemLojaCompra.Location = new System.Drawing.Point(45, 28);
            this.lblCodigoItemLojaCompra.Name = "lblCodigoItemLojaCompra";
            this.lblCodigoItemLojaCompra.Size = new System.Drawing.Size(88, 13);
            this.lblCodigoItemLojaCompra.TabIndex = 11;
            this.lblCodigoItemLojaCompra.Text = "Cód. do item loja:";
            // 
            // lblValorItemCompra
            // 
            this.lblValorItemCompra.AutoSize = true;
            this.lblValorItemCompra.Location = new System.Drawing.Point(609, 28);
            this.lblValorItemCompra.Name = "lblValorItemCompra";
            this.lblValorItemCompra.Size = new System.Drawing.Size(34, 13);
            this.lblValorItemCompra.TabIndex = 9;
            this.lblValorItemCompra.Text = "Valor:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(612, 43);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 20);
            this.textBox7.TabIndex = 4;
            // 
            // lblQuantidadeItemCompra
            // 
            this.lblQuantidadeItemCompra.AutoSize = true;
            this.lblQuantidadeItemCompra.Location = new System.Drawing.Point(534, 28);
            this.lblQuantidadeItemCompra.Name = "lblQuantidadeItemCompra";
            this.lblQuantidadeItemCompra.Size = new System.Drawing.Size(30, 13);
            this.lblQuantidadeItemCompra.TabIndex = 7;
            this.lblQuantidadeItemCompra.Text = "Qtd.:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(537, 44);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 20);
            this.textBox8.TabIndex = 3;
            // 
            // lblDescricaoItemCompra
            // 
            this.lblDescricaoItemCompra.AutoSize = true;
            this.lblDescricaoItemCompra.Location = new System.Drawing.Point(155, 28);
            this.lblDescricaoItemCompra.Name = "lblDescricaoItemCompra";
            this.lblDescricaoItemCompra.Size = new System.Drawing.Size(58, 13);
            this.lblDescricaoItemCompra.TabIndex = 5;
            this.lblDescricaoItemCompra.Text = "Descrição:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(158, 44);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(366, 20);
            this.textBox9.TabIndex = 2;
            // 
            // lblCodigoItemCompra
            // 
            this.lblCodigoItemCompra.AutoSize = true;
            this.lblCodigoItemCompra.Location = new System.Drawing.Point(5, 28);
            this.lblCodigoItemCompra.Name = "lblCodigoItemCompra";
            this.lblCodigoItemCompra.Size = new System.Drawing.Size(29, 13);
            this.lblCodigoItemCompra.TabIndex = 1;
            this.lblCodigoItemCompra.Text = "Cód:";
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(8, 44);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(29, 20);
            this.textBox10.TabIndex = 0;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(355, 21);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 1;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(538, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(447, 21);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(127, 21);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnNovaCompra
            // 
            this.btnNovaCompra.Location = new System.Drawing.Point(12, 21);
            this.btnNovaCompra.Name = "btnNovaCompra";
            this.btnNovaCompra.Size = new System.Drawing.Size(101, 23);
            this.btnNovaCompra.TabIndex = 0;
            this.btnNovaCompra.Text = "Nova compra";
            this.btnNovaCompra.UseVisualStyleBackColor = true;
            this.btnNovaCompra.Click += new System.EventHandler(this.btnNovaCompra_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(624, 21);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CadastroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 370);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnNovaCompra);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.gbItemCompra);
            this.Controls.Add(this.gbCompra);
            this.Name = "CadastroCompra";
            this.Text = "Cadastro de Compra";
            this.gbCompra.ResumeLayout(false);
            this.gbCompra.PerformLayout();
            this.gbItemCompra.ResumeLayout(false);
            this.gbItemCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCompra;
        private System.Windows.Forms.Label lbCodigoCompra;
        private System.Windows.Forms.TextBox txtCodigoCompra;
        private System.Windows.Forms.Label lblObservacaoCompra;
        private System.Windows.Forms.Label lblValorTotalCompra;
        private System.Windows.Forms.TextBox txtValorTotalCompra;
        private System.Windows.Forms.Label lblQuantidadeTotalItensCompra;
        private System.Windows.Forms.TextBox txtQuantidadeTotalItensCompra;
        private System.Windows.Forms.Label lblLojaCompra;
        private System.Windows.Forms.Label lblDataCompra;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.GroupBox gbItemCompra;
        private System.Windows.Forms.Label lblValorItemCompra;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblQuantidadeItemCompra;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label lblDescricaoItemCompra;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label lblCodigoItemCompra;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox cbLojaCompra;
        private System.Windows.Forms.Label lblFormaPagamentoCompra;
        private System.Windows.Forms.ComboBox cbFormaPagamentoCompra;
        private System.Windows.Forms.RichTextBox rtbObservacaoCompra;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblCodigoItemLojaCompra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNovaCompra;
        private System.Windows.Forms.Button btnCancelar;
    }
}

