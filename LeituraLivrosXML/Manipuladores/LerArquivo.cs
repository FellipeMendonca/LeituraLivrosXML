using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeituraLivrosXML.Manipuladores
{
    public class LerArquivo
    {
        private static string caminhoBiblia = AppDomain.CurrentDomain.BaseDirectory + @"/Livros/Biblia.txt";
        private static string caminhoAlcorao = AppDomain.CurrentDomain.BaseDirectory + @"/Livros/Alcorao.txt";

        public static bool AcharLivro()
        {
            if (File.Exists(caminhoBiblia) == false || File.Exists(caminhoAlcorao) == false)
            {
                MessageBox.Show("Impossível achar a Biblia ou o Alcorao!", "Erro ao encontrar livros");
                return false;
            }
            return true;
        }
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
            using (StreamReader leitor = File.OpenText(caminhoBiblia))
            {
                while (leitor.Peek() >= 0)
                {
                    string frase = leitor.ReadLine();
                    if (frase != "")
                    {
                        if (frase.ToUpper() == livroUpper)
                        {
                            versiculoEncontrado += frase + " - ";
                            acheiLivro = true;
                        }
                        else if (frase.ToUpper() == capituloBusca && acheiLivro)
                        {
                            versiculoEncontrado += frase + " - ";
                            acheiCapitulo = true;
                        }
                        else if (frase.Contains(versiculo) && acheiLivro && acheiCapitulo)
                        {
                            versiculoEncontrado += frase;
                            acheiversiculo = true;
                        }
                        if (acheiLivro && acheiCapitulo && acheiversiculo)
                        {
                            return versiculoEncontrado;
                        }
                    }
                }
                if (acheiLivro == false || acheiCapitulo == false || acheiversiculo == false)
                {
                    versiculoEncontrado = "";
                }
            }
            return versiculoEncontrado;
        }

        public static string LerAlcorao(string idSurata, string versiculo)
        {
            string palavraBusca = "Alc." + idSurata + "." + versiculo;
            string versiculoEncontrado = "";

            if (File.Exists(caminhoAlcorao))
            {
                using (StreamReader leitor = File.OpenText(caminhoAlcorao))
                {
                    while (leitor.Peek() >= 0)
                    {
                        string frase = leitor.ReadLine();
                        if (frase != "")
                        {
                            if (frase.Contains(palavraBusca))
                            {
                                versiculoEncontrado = frase;
                                return versiculoEncontrado;
                            }
                        }
                    }
                }
            }

            return versiculoEncontrado;
        }
    }
}
