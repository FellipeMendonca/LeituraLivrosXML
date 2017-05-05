namespace LeituraLivrosXML.TelaPrincipal
{
    partial class frmPrincipal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tbpBiblia = new System.Windows.Forms.TabPage();
            this.picbBiblia = new System.Windows.Forms.PictureBox();
            this.btnProcuraBiblia = new System.Windows.Forms.Button();
            this.cbxLivrosBiblia = new System.Windows.Forms.ComboBox();
            this.txbVersiculoBiblia = new System.Windows.Forms.TextBox();
            this.lblVersiculo = new System.Windows.Forms.Label();
            this.txbCapituloBiblia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLivro = new System.Windows.Forms.Label();
            this.tbpAlcorao = new System.Windows.Forms.TabPage();
            this.picbAlcorao = new System.Windows.Forms.PictureBox();
            this.btnProcuraAlcorao = new System.Windows.Forms.Button();
            this.txbVersiculoAlcorao = new System.Windows.Forms.TextBox();
            this.lblVersoAlcorao = new System.Windows.Forms.Label();
            this.cbxSurata = new System.Windows.Forms.ComboBox();
            this.lblSurata = new System.Windows.Forms.Label();
            this.tbpNotas = new System.Windows.Forms.TabPage();
            this.btnEditarNota = new System.Windows.Forms.Button();
            this.btnExcluirNota = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.tbcPrincipal.SuspendLayout();
            this.tbpBiblia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbBiblia)).BeginInit();
            this.tbpAlcorao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAlcorao)).BeginInit();
            this.tbpNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Controls.Add(this.tbpBiblia);
            this.tbcPrincipal.Controls.Add(this.tbpAlcorao);
            this.tbcPrincipal.Controls.Add(this.tbpNotas);
            this.tbcPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(312, 329);
            this.tbcPrincipal.TabIndex = 0;
            // 
            // tbpBiblia
            // 
            this.tbpBiblia.Controls.Add(this.picbBiblia);
            this.tbpBiblia.Controls.Add(this.btnProcuraBiblia);
            this.tbpBiblia.Controls.Add(this.cbxLivrosBiblia);
            this.tbpBiblia.Controls.Add(this.txbVersiculoBiblia);
            this.tbpBiblia.Controls.Add(this.lblVersiculo);
            this.tbpBiblia.Controls.Add(this.txbCapituloBiblia);
            this.tbpBiblia.Controls.Add(this.label2);
            this.tbpBiblia.Controls.Add(this.lblLivro);
            this.tbpBiblia.Location = new System.Drawing.Point(4, 22);
            this.tbpBiblia.Name = "tbpBiblia";
            this.tbpBiblia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBiblia.Size = new System.Drawing.Size(304, 303);
            this.tbpBiblia.TabIndex = 0;
            this.tbpBiblia.Text = "Biblia";
            this.tbpBiblia.UseVisualStyleBackColor = true;
            // 
            // picbBiblia
            // 
            this.picbBiblia.Location = new System.Drawing.Point(22, 20);
            this.picbBiblia.Name = "picbBiblia";
            this.picbBiblia.Size = new System.Drawing.Size(262, 111);
            this.picbBiblia.TabIndex = 8;
            this.picbBiblia.TabStop = false;
            // 
            // btnProcuraBiblia
            // 
            this.btnProcuraBiblia.Location = new System.Drawing.Point(115, 260);
            this.btnProcuraBiblia.Name = "btnProcuraBiblia";
            this.btnProcuraBiblia.Size = new System.Drawing.Size(75, 23);
            this.btnProcuraBiblia.TabIndex = 3;
            this.btnProcuraBiblia.Text = "Procurar";
            this.btnProcuraBiblia.UseVisualStyleBackColor = true;
            this.btnProcuraBiblia.Click += new System.EventHandler(this.btnProcuraBiblia_Click);
            // 
            // cbxLivrosBiblia
            // 
            this.cbxLivrosBiblia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxLivrosBiblia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxLivrosBiblia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxLivrosBiblia.FormattingEnabled = true;
            this.cbxLivrosBiblia.Location = new System.Drawing.Point(169, 150);
            this.cbxLivrosBiblia.Name = "cbxLivrosBiblia";
            this.cbxLivrosBiblia.Size = new System.Drawing.Size(115, 21);
            this.cbxLivrosBiblia.Sorted = true;
            this.cbxLivrosBiblia.TabIndex = 0;
            // 
            // txbVersiculoBiblia
            // 
            this.txbVersiculoBiblia.Location = new System.Drawing.Point(184, 222);
            this.txbVersiculoBiblia.Name = "txbVersiculoBiblia";
            this.txbVersiculoBiblia.Size = new System.Drawing.Size(100, 20);
            this.txbVersiculoBiblia.TabIndex = 2;
            this.txbVersiculoBiblia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVersiculo
            // 
            this.lblVersiculo.AutoSize = true;
            this.lblVersiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersiculo.Location = new System.Drawing.Point(19, 223);
            this.lblVersiculo.Name = "lblVersiculo";
            this.lblVersiculo.Size = new System.Drawing.Size(137, 17);
            this.lblVersiculo.TabIndex = 4;
            this.lblVersiculo.Text = "Informe o Versiculo: ";
            // 
            // txbCapituloBiblia
            // 
            this.txbCapituloBiblia.Location = new System.Drawing.Point(180, 186);
            this.txbCapituloBiblia.Name = "txbCapituloBiblia";
            this.txbCapituloBiblia.Size = new System.Drawing.Size(104, 20);
            this.txbCapituloBiblia.TabIndex = 1;
            this.txbCapituloBiblia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(19, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Informe o Capítulo: ";
            // 
            // lblLivro
            // 
            this.lblLivro.AutoSize = true;
            this.lblLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLivro.Location = new System.Drawing.Point(19, 151);
            this.lblLivro.Name = "lblLivro";
            this.lblLivro.Size = new System.Drawing.Size(125, 17);
            this.lblLivro.TabIndex = 0;
            this.lblLivro.Text = "Selecione o Livro: ";
            // 
            // tbpAlcorao
            // 
            this.tbpAlcorao.Controls.Add(this.picbAlcorao);
            this.tbpAlcorao.Controls.Add(this.btnProcuraAlcorao);
            this.tbpAlcorao.Controls.Add(this.txbVersiculoAlcorao);
            this.tbpAlcorao.Controls.Add(this.lblVersoAlcorao);
            this.tbpAlcorao.Controls.Add(this.cbxSurata);
            this.tbpAlcorao.Controls.Add(this.lblSurata);
            this.tbpAlcorao.Location = new System.Drawing.Point(4, 22);
            this.tbpAlcorao.Name = "tbpAlcorao";
            this.tbpAlcorao.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAlcorao.Size = new System.Drawing.Size(304, 303);
            this.tbpAlcorao.TabIndex = 1;
            this.tbpAlcorao.Text = "Alcorão";
            this.tbpAlcorao.UseVisualStyleBackColor = true;
            // 
            // picbAlcorao
            // 
            this.picbAlcorao.Location = new System.Drawing.Point(22, 20);
            this.picbAlcorao.Name = "picbAlcorao";
            this.picbAlcorao.Size = new System.Drawing.Size(260, 113);
            this.picbAlcorao.TabIndex = 5;
            this.picbAlcorao.TabStop = false;
            // 
            // btnProcuraAlcorao
            // 
            this.btnProcuraAlcorao.Location = new System.Drawing.Point(115, 260);
            this.btnProcuraAlcorao.Name = "btnProcuraAlcorao";
            this.btnProcuraAlcorao.Size = new System.Drawing.Size(75, 23);
            this.btnProcuraAlcorao.TabIndex = 2;
            this.btnProcuraAlcorao.Text = "Procurar";
            this.btnProcuraAlcorao.UseVisualStyleBackColor = true;
            this.btnProcuraAlcorao.Click += new System.EventHandler(this.btnProcuraAlcorao_Click);
            // 
            // txbVersiculoAlcorao
            // 
            this.txbVersiculoAlcorao.Location = new System.Drawing.Point(172, 207);
            this.txbVersiculoAlcorao.Name = "txbVersiculoAlcorao";
            this.txbVersiculoAlcorao.Size = new System.Drawing.Size(110, 20);
            this.txbVersiculoAlcorao.TabIndex = 1;
            this.txbVersiculoAlcorao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVersoAlcorao
            // 
            this.lblVersoAlcorao.AutoSize = true;
            this.lblVersoAlcorao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersoAlcorao.Location = new System.Drawing.Point(19, 208);
            this.lblVersoAlcorao.Name = "lblVersoAlcorao";
            this.lblVersoAlcorao.Size = new System.Drawing.Size(116, 17);
            this.lblVersoAlcorao.TabIndex = 2;
            this.lblVersoAlcorao.Text = "Informe o Verso: ";
            // 
            // cbxSurata
            // 
            this.cbxSurata.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSurata.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSurata.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxSurata.FormattingEnabled = true;
            this.cbxSurata.Location = new System.Drawing.Point(172, 156);
            this.cbxSurata.Name = "cbxSurata";
            this.cbxSurata.Size = new System.Drawing.Size(110, 21);
            this.cbxSurata.TabIndex = 0;
            // 
            // lblSurata
            // 
            this.lblSurata.AutoSize = true;
            this.lblSurata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSurata.Location = new System.Drawing.Point(19, 157);
            this.lblSurata.Name = "lblSurata";
            this.lblSurata.Size = new System.Drawing.Size(136, 17);
            this.lblSurata.TabIndex = 0;
            this.lblSurata.Text = "Selecione a Surata: ";
            // 
            // tbpNotas
            // 
            this.tbpNotas.Controls.Add(this.btnEditarNota);
            this.tbpNotas.Controls.Add(this.btnExcluirNota);
            this.tbpNotas.Controls.Add(this.dgvNotas);
            this.tbpNotas.Location = new System.Drawing.Point(4, 22);
            this.tbpNotas.Name = "tbpNotas";
            this.tbpNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tbpNotas.Size = new System.Drawing.Size(304, 303);
            this.tbpNotas.TabIndex = 2;
            this.tbpNotas.Text = "Notas";
            this.tbpNotas.UseVisualStyleBackColor = true;
            // 
            // btnEditarNota
            // 
            this.btnEditarNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditarNota.Location = new System.Drawing.Point(177, 265);
            this.btnEditarNota.Name = "btnEditarNota";
            this.btnEditarNota.Size = new System.Drawing.Size(96, 23);
            this.btnEditarNota.TabIndex = 2;
            this.btnEditarNota.Text = "Editar Nota";
            this.btnEditarNota.UseVisualStyleBackColor = true;
            this.btnEditarNota.Click += new System.EventHandler(this.btnEditarNota_Click);
            // 
            // btnExcluirNota
            // 
            this.btnExcluirNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExcluirNota.Location = new System.Drawing.Point(40, 265);
            this.btnExcluirNota.Name = "btnExcluirNota";
            this.btnExcluirNota.Size = new System.Drawing.Size(98, 23);
            this.btnExcluirNota.TabIndex = 1;
            this.btnExcluirNota.Text = "Excluir Nota";
            this.btnExcluirNota.UseVisualStyleBackColor = true;
            this.btnExcluirNota.Click += new System.EventHandler(this.btnExcluirNota_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.AllowUserToAddRows = false;
            this.dgvNotas.AllowUserToDeleteRows = false;
            this.dgvNotas.AllowUserToOrderColumns = true;
            this.dgvNotas.AllowUserToResizeColumns = false;
            this.dgvNotas.AllowUserToResizeRows = false;
            this.dgvNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNotas.CausesValidation = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotas.Location = new System.Drawing.Point(6, 6);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotas.Size = new System.Drawing.Size(292, 253);
            this.dgvNotas.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 353);
            this.Controls.Add(this.tbcPrincipal);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Shown += new System.EventHandler(this.frmPrincipal_Shown);
            this.tbcPrincipal.ResumeLayout(false);
            this.tbpBiblia.ResumeLayout(false);
            this.tbpBiblia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbBiblia)).EndInit();
            this.tbpAlcorao.ResumeLayout(false);
            this.tbpAlcorao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbAlcorao)).EndInit();
            this.tbpNotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tbpBiblia;
        private System.Windows.Forms.TabPage tbpAlcorao;
        private System.Windows.Forms.ComboBox cbxSurata;
        private System.Windows.Forms.Label lblSurata;
        private System.Windows.Forms.TabPage tbpNotas;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.TextBox txbVersiculoAlcorao;
        private System.Windows.Forms.Label lblVersoAlcorao;
        private System.Windows.Forms.Button btnProcuraAlcorao;
        private System.Windows.Forms.Button btnProcuraBiblia;
        private System.Windows.Forms.ComboBox cbxLivrosBiblia;
        private System.Windows.Forms.TextBox txbVersiculoBiblia;
        private System.Windows.Forms.Label lblVersiculo;
        private System.Windows.Forms.TextBox txbCapituloBiblia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLivro;
        private System.Windows.Forms.Button btnEditarNota;
        private System.Windows.Forms.Button btnExcluirNota;
        private System.Windows.Forms.PictureBox picbAlcorao;
        private System.Windows.Forms.PictureBox picbBiblia;
    }
}

