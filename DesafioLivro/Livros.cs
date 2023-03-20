using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioLivro
{
    public class Livros
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Isnb { get; private set; }
        public string AnoPublicacao { get; set; }
        public string PaisPublicacao { get; set; }
        public int NumPaginas { get; set; }
        public string EstiloLiterario { get; set; }
        public Livros(string titulo, string isnb) 
        {
            Titulo = titulo;
            Isnb = isnb;
        }
    }
}
