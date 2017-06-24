using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public class Livro
    {        
        private string _titulo { get; set; }
        private string _isbn { get; set; }
        private string _autor { get; set; }
        private string _editora { get; set; }
        private int _anoPub { get; set; } 
        private int _edicao { get; set; }
        private int _paginas { get; set; }
        
        public string Titulo
        {
            get => _titulo; set => _titulo = value;
        }
        public string Isbn
        {
            get => _isbn; set => _isbn = value;
        }
        public string Autor
        {
            get => _autor; set => _autor = value;
        }
        public string Editora
        {
            get => _editora; set => _editora = value;
        }
        public int AnoPub
        {
            get => _anoPub; set => _anoPub = value;
        }
        public int Edicao
        {
            get => _edicao; set => _edicao = value;
        }
        public int Paginas
        {
            get => _paginas; set => _paginas = value;
        }
    }
}
