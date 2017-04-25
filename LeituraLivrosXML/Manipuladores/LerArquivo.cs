using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraLivrosXML.Manipuladores
{
    public class LerArquivo
    {
        private static string caminhoBiblia = AppDomain.CurrentDomain + "Biblia.txt";
        private static string caminhoAlcorao = AppDomain.CurrentDomain + "Alcorao.txt";

        public static string LerBiblia(string livro, string capitulo, string versiculo)
        {
            string livroUpper = livro.ToUpper(); // No txt o padrao é uppercase no nome dos livros
            string capituloBusca = livroUpper + " [" + capitulo + "]"; // padrao GÊNESIS[1]
            // Auxiliares de pesquisa
            bool acheiLivro = false;
            bool acheiCapitulo = false;
            bool acheiversiculo = false;
            // Retorno
            string versiculoEncontrado = "";



            return versiculoEncontrado;
        }

    }
}
