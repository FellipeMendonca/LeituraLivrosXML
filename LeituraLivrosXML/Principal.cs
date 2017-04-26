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
            dgvNotas.DefaultCellStyle.WrapMode = DataGridViewTriState.True;            
        }
        // Metodos de Serviço
        private static DialogResult ObterResposta(string mensagem, string titulo)
        {
            DialogResult resposta = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);
            return resposta;
        }

        private void CarregarDGV(DataGridView dgv)
        {
            dgv.DataSource = Manipuladores.ManipularXML.LerNotas();
            dgv.Columns["id"].Visible = false;
            // Configurações DGV
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (i == 3)
                {
                    dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
                
            }
        }
        private void LimparCampos()
        {
            txbCapituloBiblia.Text = "";
            txbVersiculoAlcorao.Text = "";
            txbVersiculoBiblia.Text = "";
            cbxLivrosBiblia.Text = "";
            cbxSurata.Text = "";
        }
        // Metodos do Tipo Botão
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
                        Nota nota = new Nota();
                        nota.Id = dgvNotas.Rows.Count.ToString();
                        nota.Livro = "Biblia";
                        nota.Comentario = "";
                        nota.Versiculo = versiculoEncontrado;
                        nota.Data = DateTime.Now.ToShortDateString();
                        Resultado telaResultado = new Resultado(nota, false);
                        telaResultado.ShowDialog();
                        CarregarDGV(dgvNotas);
                    }
                    else
                    {
                        MessageBox.Show(versiculoEncontrado, "Versiculo");
                    }
                    LimparCampos();
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
                    Nota nota = new Nota();
                    nota.Id = dgvNotas.Rows.Count.ToString();
                    nota.Livro = "Alcorao";
                    nota.Comentario = "";
                    nota.Versiculo = versiculoEncontrado;
                    nota.Data = DateTime.Now.ToShortDateString();
                    Resultado telaResultado = new Resultado(nota, false);
                    telaResultado.ShowDialog();
                    CarregarDGV(dgvNotas);
                }
                else
                {
                    MessageBox.Show(versiculoEncontrado, "Versiculo");
                }
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!!", "Erro");
            }
        }



        private void btnExcluirNota_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == ObterResposta("Deseja excluir?", "Confirmação"))
            {
                Nota nota = new Nota();
                nota.Id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
                nota.Livro = dgvNotas.CurrentRow.Cells[1].Value.ToString();
                nota.Versiculo = dgvNotas.CurrentRow.Cells[2].Value.ToString();
                nota.Comentario = dgvNotas.CurrentRow.Cells[3].Value.ToString();
                nota.Data = dgvNotas.CurrentRow.Cells[4].Value.ToString();
                Manipuladores.ManipularXML.ExcluirNota(nota);
            }
            CarregarDGV(dgvNotas);
        }

        private void btnEditarNota_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Id = dgvNotas.CurrentRow.Cells[0].Value.ToString();
            nota.Data = DateTime.Now.ToShortDateString();
            nota.Livro = dgvNotas.CurrentRow.Cells[2].Value.ToString();
            nota.Versiculo = dgvNotas.CurrentRow.Cells[3].Value.ToString();
            nota.Comentario = dgvNotas.CurrentRow.Cells[4].Value.ToString();
            Resultado telaResultado = new Resultado(nota, true);
            telaResultado.ShowDialog();
            CarregarDGV(dgvNotas);
        }
    }
}
