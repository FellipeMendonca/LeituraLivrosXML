namespace LeituraLivrosXML
{
    partial class Resultado
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
            this.lblVersiculoEncontrado = new System.Windows.Forms.Label();
            this.txbVersiculo = new System.Windows.Forms.TextBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txbComentario = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersiculoEncontrado
            // 
            this.lblVersiculoEncontrado.AutoSize = true;
            this.lblVersiculoEncontrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersiculoEncontrado.Location = new System.Drawing.Point(70, 9);
            this.lblVersiculoEncontrado.Name = "lblVersiculoEncontrado";
            this.lblVersiculoEncontrado.Size = new System.Drawing.Size(151, 17);
            this.lblVersiculoEncontrado.TabIndex = 0;
            this.lblVersiculoEncontrado.Text = "Versiculo Encontrado: ";
            // 
            // txbVersiculo
            // 
            this.txbVersiculo.Enabled = false;
            this.txbVersiculo.Location = new System.Drawing.Point(12, 29);
            this.txbVersiculo.Multiline = true;
            this.txbVersiculo.Name = "txbVersiculo";
            this.txbVersiculo.Size = new System.Drawing.Size(260, 73);
            this.txbVersiculo.TabIndex = 1;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblComentario.Location = new System.Drawing.Point(100, 117);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(80, 17);
            this.lblComentario.TabIndex = 2;
            this.lblComentario.Text = "Comentário";
            // 
            // txbComentario
            // 
            this.txbComentario.Location = new System.Drawing.Point(14, 137);
            this.txbComentario.Multiline = true;
            this.txbComentario.Name = "txbComentario";
            this.txbComentario.Size = new System.Drawing.Size(260, 61);
            this.txbComentario.TabIndex = 3;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(54, 217);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVoltar.Location = new System.Drawing.Point(174, 217);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbComentario);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.txbVersiculo);
            this.Controls.Add(this.lblVersiculoEncontrado);
            this.Name = "Resultado";
            this.Text = "Resultado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersiculoEncontrado;
        private System.Windows.Forms.TextBox txbVersiculo;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txbComentario;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
    }
}