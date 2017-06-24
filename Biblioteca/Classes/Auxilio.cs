using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Classes
{
    public static class Auxilio
    {
        public static bool validarCampoTexto(string valorCampo)
        {
            return valorCampo.Trim().Length > 0;
        }
        public static bool validarCampoNumero(string valorCampo)
        {
            Int32.TryParse(valorCampo, out int numero);           
            return numero > 0;
        }
        public static bool validarAno(string valorCampo)
        {
            int.TryParse(valorCampo, out int ano);
            return ano < DateTime.Now.Year;
        }
    }
}
