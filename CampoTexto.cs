using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class CampoTexto : CampoFormulario, IValidavel
    {
        public CampoTexto(string nomeDoCampo, string valor) : base(nomeDoCampo, valor) { }
        public bool Validar()
        {
            if (Valor != "") 
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
