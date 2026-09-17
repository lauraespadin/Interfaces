using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class CampoNumerico : CampoFormulario, IValidavel
    {
        public CampoNumerico(string nomeDoCampo, string valor) : base(nomeDoCampo, valor) { }
        public bool Validar()
        {
            int numero;
            if (int.TryParse(Valor, out numero))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
