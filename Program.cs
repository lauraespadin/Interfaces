namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISalvavel meuDocumento = new Documento();
            ISalvavel minhaFoto = new Foto();

           
            meuDocumento.Salvar();
            minhaFoto.Salvar();
        }
    }
}
