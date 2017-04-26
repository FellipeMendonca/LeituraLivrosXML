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
        private static string caminhoXML = @"c:\users\natsu\onedrive\documentos\visual studio 2015\projects\leituralivrosxml\leituralivrosxml\anotaçõeslivros.xml";

        public static List<Nota> LerNotas()
        {
            List<Nota> listaNotas = new List<Nota>();
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);

            XmlNodeList nosNotas = arquivoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode noNota in nosNotas)
            {
                Nota nota = new Nota();
                nota.Id = noNota.Attributes["id"].Value;
                nota.Livro = noNota.Attributes["livro"].Value;
                nota.Versiculo = noNota.Attributes["versiculo"].Value;
                nota.Comentario = noNota.Attributes["comentario"].Value;
                listaNotas.Add(nota);
            }

            return listaNotas;
        }

        public static void AdicionarNota(Nota nota)
        {
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);
            XmlAttribute atributoID = arquivoXML.CreateAttribute("id");
            atributoID.Value = nota.Id.ToString();
            XmlAttribute atributoLivro = arquivoXML.CreateAttribute("livro");
            atributoLivro.Value = nota.Livro;
            XmlAttribute atributoVersiculo = arquivoXML.CreateAttribute("versiculo");
            atributoVersiculo.Value = nota.Versiculo;
            XmlAttribute atributloComentario = arquivoXML.CreateAttribute("comentario");
            atributloComentario.Value = nota.Comentario;

            XmlNode novaNota = arquivoXML.CreateElement("anotacao");
            novaNota.Attributes.Append(atributoID);
            novaNota.Attributes.Append(atributoLivro);
            novaNota.Attributes.Append(atributoVersiculo);
            novaNota.Attributes.Append(atributloComentario);

            XmlNode anotacoes = arquivoXML.SelectSingleNode("/biblioteca/anotacoes");
            anotacoes.AppendChild(novaNota);
            ReenumerarNotas();
            arquivoXML.Save(caminhoXML);
        }

        public static void EditarNota(Nota nota)
        {
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);

            XmlNodeList nosNotas = arquivoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode noNota in nosNotas)
            {
                if (noNota.Attributes["id"].Value == nota.Id.ToString())
                {
                    noNota.Attributes["livro"].Value = nota.Livro;
                    noNota.Attributes["versiculo"].Value = nota.Versiculo;
                    noNota.Attributes["comentario"].Value = nota.Comentario;
                    break;
                }
            }
            ReenumerarNotas();
            arquivoXML.Save(caminhoXML);
        }

        public static void ExcluirNota(Nota nota)
        {
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);

            XmlNodeList nosNotas = arquivoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            foreach (XmlNode noNota in nosNotas)
            {
                if (noNota.Attributes["id"].Value == nota.Id.ToString())
                {
                    noNota.ParentNode.RemoveChild(noNota);
                    break;
                }
            }
            arquivoXML.Save(caminhoXML);
            ReenumerarNotas();
        }

        private static void ReenumerarNotas()
        {
            XmlDocument arquivoXML = new XmlDocument();
            arquivoXML.Load(caminhoXML);

            XmlNodeList nosNotas = arquivoXML.SelectNodes("/biblioteca/anotacoes/anotacao");
            int i = 0;
            foreach (XmlNode noNota in nosNotas)
            {
                noNota.Attributes["id"].Value = i.ToString();
                i++;
            }
            arquivoXML.Save(caminhoXML);
        }
    }
}
