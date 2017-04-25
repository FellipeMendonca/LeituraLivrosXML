using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraLivrosXML
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            cbxLivrosBiblia.DataSource = Livros.LivrosBiblia();
            cbxSurata.DataSource = Livros.LivrosAlcorao();
            CarregarDGV(dgvNotas);
        }

        private void btnProcuraBiblia_Click(object sender, EventArgs e)
        {
            string livro = cbxLivrosBiblia.SelectedItem.ToString();
            string capitulo = txbCapituloBiblia.Text;
            string versiculo = txbVersiculoBiblia.Text;
            if (livro != "" && capitulo != "" && versiculo != "")
            {

                string versiculoEncontrado = Manipuladores.LerArquivo.LerBiblia(livro, capitulo, versiculo);
                if (versiculoEncontrado != "")
                {
                    if (DialogResult.Yes == ObterResposta("Deseja comentar?", "Versiculo Encontrado"))
                    {
                        // abrir tela resultado
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Erro");
            }
        }

        private void btnProcuraAlcorao_Click(object sender, EventArgs e)
        {
            int idSurata = cbxSurata.SelectedIndex + 1;
            string versiculo = txbVersiculoAlcorao.Text;

            string versiculoEncontrado = Manipuladores.LerArquivo.LerAlcorao(idSurata.ToString(), versiculo);
            if (versiculoEncontrado != "")
            {
                if (DialogResult.Yes == ObterResposta("Deseja comentar?", "Versiculo Encontrado"))
                {
                    // abrir tela resultado
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Erro");
            }
        }
        private static DialogResult ObterResposta(string mensagem, string titulo)
        {
            DialogResult resposta = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);
            return resposta;
        }

        private void CarregarDGV(DataGridView dgv)
        {
            dgv.DataSource = Manipuladores.ManipularXML.LerNotas();
        }
    }
}
