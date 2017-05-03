using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraLivrosXML.TelaPrincipal
{
    public partial class frmPrincipal : Form
    {
        // Metodos do Formulario
        public frmPrincipal() // Construtor
        {
            try
            {
                InitializeComponent();
                CarregarCBX();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void frmPrincipal_Shown(object sender, EventArgs e) // Exibe o Form e depois faz verificação
        {
            CarregarDGV(dgvNotas);
        }

        private void frmPrincipal_Load(object sender, EventArgs e) // Carrega antes de Exibir o form
        {
            try
            {
                CarregarPICBOX(picbAlcorao, "ImagemAlcorao.png", PictureBoxSizeMode.StretchImage);
                CarregarPICBOX(picbBiblia, "ImagemBiblia.png", PictureBoxSizeMode.StretchImage);
                this.BackColor = Color.Tan;
                EstilizarTBCP(tbcPrincipal);
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }
        }
        // METODOS DO TIPO BOTAO
        private void btnProcuraBiblia_Click(object sender, EventArgs e)
        {
            try
            {
                string livro = cbxLivrosBiblia.SelectedItem.ToString();
                int capitulo = Convert.ToInt32(txbCapituloBiblia.Text);
                int versiculo = Convert.ToInt32(txbVersiculoBiblia.Text);
                string versiculoEncontrado = Manipuladores.LerArquivo.LerBiblia(livro, capitulo.ToString(), versiculo.ToString());
                if (versiculoEncontrado != "")
                {
                    if (Manipuladores.ManipularXML.AcharXML() == false)
                    {
                        MessageBox.Show(versiculoEncontrado, "Versiculo");
                    }
                    if (DialogResult.Yes == ObterResposta("Deseja comentar?", "Versiculo Encontrado"))
                    {
                        Nota nota = IniciarNota("Biblia", versiculoEncontrado);
                        ChamarTelaEdicao(nota);
                    }
                    else
                    {
                        MessageBox.Show(versiculoEncontrado, "Versiculo");
                    }
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Versiculo Não Encontrado", "Erro!");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnProcuraAlcorao_Click(object sender, EventArgs e)
        {
            try
            {
                int idSurata = cbxSurata.SelectedIndex + 1;
                int versiculo = Convert.ToInt32(txbVersiculoAlcorao.Text);
                string versiculoEncontrado = Manipuladores.LerArquivo.LerAlcorao(idSurata.ToString(), versiculo.ToString());
                if (versiculoEncontrado != "")
                {
                    if (Manipuladores.ManipularXML.AcharXML() == false)
                    {
                        MessageBox.Show(versiculoEncontrado, "Versiculo");
                    }
                    else if (DialogResult.Yes == ObterResposta("Deseja comentar?", "Versiculo Encontrado"))
                    {
                        Nota nota = IniciarNota("Alcorao", versiculoEncontrado);
                        ChamarTelaEdicao(nota);
                    }
                    else
                    {
                        MessageBox.Show(versiculoEncontrado, "Versiculo");
                    }
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Versiculo Não Encontrado!!!", "Erro");
                }
            }
            catch (Exception excecao)
            {
                MessageBox.Show(excecao.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void btnExcluirNota_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == ObterResposta("Deseja excluir?", "Confirmação"))
            {
                Nota nota = IniciarNota("Excluir");
                Manipuladores.ManipularXML.ExcluirNota(nota);
            }
            CarregarDGV(dgvNotas);
        }

        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            Nota nota = IniciarNota("Editar");
            ChamarTelaEdicao(nota, true);
        }
    }
}
