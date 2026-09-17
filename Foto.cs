using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class Foto : ISalvavel
    {
        public void Salvar()
        {
            Console.WriteLine("Salvando o documento em formato .jpg");
        }
    }
}
