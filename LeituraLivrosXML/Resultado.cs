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
    public partial class Resultado : Form
    {
        private static bool NotaEditada = false;
        private static string indiceVersiculo;
        private static string nomeLivro;

        public Resultado()
        {
            InitializeComponent();
        }

        public Resultado(Nota nota, bool isEdicao)
        {
            InitializeComponent();
            nomeLivro = nota.Livro;
            txbVersiculo.Text = nota.Versiculo;
            txbComentario.Text = nota.Comentario;
            NotaEditada = isEdicao;
            indiceVersiculo = nota.Id.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Id = indiceVersiculo;
            nota.Livro = nomeLivro;
            nota.Versiculo = txbVersiculo.Text;
            nota.Comentario = txbComentario.Text;
            if (NotaEditada)
            {
                Manipuladores.ManipularXML.EditarNota(nota);
            }
            else
            {
                Manipuladores.ManipularXML.AdicionarNota(nota);
            }
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
