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
        private Nota notaParametro;

        public Resultado()
        {
            InitializeComponent();
        }

        public Resultado(Nota nota, bool isEdicao)
        {
            InitializeComponent();            
            txbVersiculo.Text = nota.Versiculo;
            txbComentario.Text = nota.Comentario;
            notaParametro = new Nota();
            notaParametro.Livro = nota.Livro;
            notaParametro.Id = nota.Id;
            notaParametro.Data = nota.Data;
            NotaEditada = isEdicao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Id = notaParametro.Id;
            nota.Livro = notaParametro.Livro;
            nota.Versiculo = txbVersiculo.Text;
            nota.Comentario = txbComentario.Text;
            nota.Data = notaParametro.Data;
            if (NotaEditada)
            {
                Manipuladores.ManipularXML.EditarXml(nota);
            }
            else
            {
                Manipuladores.ManipularXML.EscreverXml(nota);
            }
            Close();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
