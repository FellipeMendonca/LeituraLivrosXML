using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeituraLivrosXML.Manipuladores
{
    public class ManipularXML
    {
        public static string caminhoXML = @"C:\Users\Natsu\OneDrive\Documentos\Visual Studio 2015\Projects\LeituraLivrosXML\LeituraLivrosXML\AnotaçõesLivros.xml";
        public static void AdicionarNota(Nota nota, int idNota)
        {
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);



            arquivoXML.Save(caminhoXML);
        }

        public static List<Nota> LerNotas()
        {
            List<Nota> listaNotas = new List<Nota>();
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);

            XmlNodeList nosNotas = arquivoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode noNota in nosNotas)
            {
                Nota nota = new Nota();
                nota.Livro = noNota.Attributes["livro"].Value;
                nota.Versiculo = noNota.Attributes["versiculo"].Value;
                nota.Comentario = noNota.Attributes["comentario"].Value;
                listaNotas.Add(nota);
            }

            return listaNotas;
        }
    }
}
