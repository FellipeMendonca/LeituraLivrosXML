using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeituraLivrosXML.TelaResultado;

namespace LeituraLivrosXML.TelaPrincipal
{
    public partial class frmPrincipal
    {

        // METODOS DE SERVIÇO
        private static DialogResult ObterResposta(string mensagem, string titulo)
        {
            DialogResult resposta = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo);
            return resposta;
        }
        private void LimparCampos()
        {
            txbCapituloBiblia.Text = "";
            txbVersiculoAlcorao.Text = "";
            txbVersiculoBiblia.Text = "";
        }
        private Nota IniciarNota(string tipo)
        {
            Nota nota = new Nota();
            nota.Id = dgvNotas.CurrentRow.Cells["Id"].Value.ToString();
            nota.Livro = dgvNotas.CurrentRow.Cells["Livro"].Value.ToString();
            nota.Versiculo = dgvNotas.CurrentRow.Cells["Versiculo"].Value.ToString();
            nota.Comentario = dgvNotas.CurrentRow.Cells["Comentario"].Value.ToString();
            if (tipo == "Excluir")
            {
                nota.Data = dgvNotas.CurrentRow.Cells["Data"].Value.ToString();
            }
            if (tipo == "Editar")
            {

                nota.Data = DateTime.Now.ToShortDateString();
            }
            return nota;
        }

        private Nota IniciarNota(string livro, string versiculoEncontrado)
        {
            Nota nota = new Nota();
            nota.Id = dgvNotas.Rows.Count.ToString();
            nota.Livro = livro;
            nota.Comentario = "";
            nota.Versiculo = versiculoEncontrado;
            nota.Data = DateTime.Now.ToShortDateString();
            return nota;
        }

        private void ChamarTelaEdicao(Nota nota, bool isEdicao = false)
        {
            Resultado telaResultado = new Resultado(nota, isEdicao);
            telaResultado.ShowDialog();
            CarregarDGV(dgvNotas);
        }
        // METODOS DE CARREGAMENTO
        private void CarregarDGV(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = Manipuladores.ManipularXML.LerXml().OrderBy(nota => nota.Livro).ToList();
                dgv.Columns["Id"].Visible = false;
                dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                // Configurações DGV
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    dgv.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    dgv.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                    if (dgv.Columns[i].Name == "Versiculo")
                    {
                        dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                }
            }
            catch (Exception fe)
            {
                tbcPrincipal.TabPages.Remove(tbpNotas);
                MessageBox.Show("Tipo de Erro: " + fe.Message + "\n\nApenas busca de versiculo!", "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        public void CarregarCBX()
        {
            cbxLivrosBiblia.DataSource = Livros.LivrosBiblia();
            cbxSurata.DataSource = Livros.LivrosAlcorao();
        }
        private void CarregarPICBOX(PictureBox picbox, string nomeImagem, PictureBoxSizeMode Dimensionamento)
        {
            string caminhoImagem = AppDomain.CurrentDomain.BaseDirectory + @"/Imagens/" + nomeImagem;
            picbox.ImageLocation = caminhoImagem;
            picbox.SizeMode = Dimensionamento;
        }

        // METODOS DE ESTILIZAÇÃO
        public static void EstilizarTBCP(TabControl tabControl)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                tabControl.TabPages[i].BackColor = Color.Tan;
            }
        }
    }
}
