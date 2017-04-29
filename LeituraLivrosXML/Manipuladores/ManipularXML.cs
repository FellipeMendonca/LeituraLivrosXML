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

        public static List<Nota> LerXml()
        {
            List<Nota> listaNotas = new List<Nota>();
            Nota nota = new Nota();
            XmlTextReader leitor = new XmlTextReader(caminhoXML); // abrir arquivo
            bool leuID = false; // todos são utilizados para 
            bool leuData = false; // validar quais dados foram lidos
            bool leuLivro = false;
            bool leuVersiculo = false;
            bool leuComentario = false;
            while (leitor.Read()) // abrir o arquivo e ler o arquivo
            {
                switch (leitor.NodeType) // encontrar o tipo de Nó que foi lido
                {
                    case XmlNodeType.Element: // Se for do tipo Elemento
                        switch (leitor.Name) // Verificar qual o nome do Elemento
                        {
                            case "id":
                                leuID = true;
                                break;
                            case "data":
                                leuData = true;
                                break;
                            case "livro":
                                leuLivro = true;
                                break;
                            case "versiculo":
                                leuVersiculo = true;
                                break;
                            case "comentario":
                                leuComentario = true;
                                break;
                        }
                        break;
                    case XmlNodeType.Text: // Após validação de qual elemento
                        // encontramos qual o valor em Texto do elemento
                        if (leuID)
                        {
                            nota.Id = leitor.Value;
                            leuID = false;
                        }
                        if (leuData)
                        {
                            nota.Data = leitor.Value;
                            leuData = false;
                        }
                        if (leuLivro)
                        {
                            nota.Livro = leitor.Value;
                            leuLivro = false;
                        }
                        if (leuVersiculo)
                        {
                            nota.Versiculo = leitor.Value;
                            leuVersiculo = false;
                        }
                        if (leuComentario)
                        {
                            nota.Comentario = leitor.Value;
                            leuComentario = false;
                        }
                        break;
                    case XmlNodeType.EndElement: // Como estou criando anotaçoes 
                        if (leitor.Name == "anotacao") // quando chegar no fim
                        {
                            listaNotas.Add(nota); // adicionamos a nota lida
                            nota = new Nota(); // zeramos os atributos de nota
                        }
                        break;
                }
            }
            leitor.Close(); // fechar o leitor
            return listaNotas;
        }
        public static void EscreverXml(Nota notaParametro)
        {
            List<Nota> listaNotas = LerXml();
            listaNotas.Add(notaParametro);
            ModificarXml(listaNotas);
        }



        public static void EditarXml(Nota notaParametro)
        {
            List<Nota> listaNotas = LerXml();
            foreach (Nota nota in listaNotas)
            {
                if (nota.Id == notaParametro.Id)
                {
                    nota.Comentario = notaParametro.Comentario;
                    break;
                }
            }
            ModificarXml(listaNotas);
        }

        public static void ExcluirNota(Nota notaParametro)
        {
            List<Nota> listaNotas = LerXml();
            listaNotas.RemoveAll(nota => nota.Id == notaParametro.Id);
            listaNotas = ReenumerarNotas(listaNotas);
            ModificarXml(listaNotas);
        }

        private static List<Nota> ReenumerarNotas(List<Nota> listaNotas)
        {
            for (int i = 0; i < listaNotas.Count; i++)
            {
                listaNotas[i].Id = i.ToString();
            }
            return listaNotas;
        }

        private static void ModificarXml(List<Nota> listaNotas)
        {
            XmlTextWriter writer = new XmlTextWriter(caminhoXML, null);
            //inicia o documento xml
            writer.WriteStartDocument();
            //Usa a formatação
            writer.Formatting = Formatting.Indented;
            //Escreve o elemento raiz
            writer.WriteStartElement("anotacoes");
            foreach (Nota nota in listaNotas)
            {
                //Inicia um elemento
                writer.WriteStartElement("anotacao");
                //e sub-elementos
                writer.WriteElementString("id", nota.Id);
                writer.WriteElementString("data", nota.Data);
                writer.WriteElementString("livro", nota.Livro);
                writer.WriteElementString("versiculo", nota.Versiculo);
                writer.WriteElementString("comentario", nota.Comentario);
                //encerra os elementos itens
                writer.WriteEndElement();
                // encerra o item
                //escreve alguns espaços entre os nodes
                writer.WriteWhitespace("");
            }
            // encerra o elemento raiz
            writer.WriteFullEndElement();
            //escreve o XML para o arquivo e fecha o escritor
            writer.Close();
        }
    }
}
