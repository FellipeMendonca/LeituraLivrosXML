using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeituraLivrosXML
{
    public class Nota
    {
        public string Id { get; set; }
        public string Data { get; set; }
        public string Livro { get; set; }
        public string Versiculo { get; set; }
        public string Comentario { get; set; }
    }
}
