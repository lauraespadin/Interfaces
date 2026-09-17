namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IValidavel> campos = new List<IValidavel>();

            CampoTexto campo1 = new CampoTexto("Nome", "Laura");

            CampoTexto campo2 = new CampoTexto("Sobrenome", "Espadin");

            CampoNumerico campo3 = new CampoNumerico("Idade", "16");

            campos.Add(campo1);
            campos.Add(campo2);
            campos.Add(campo3);

            foreach (IValidavel campo in campos)
            {
                if (campo.Validar())
                {
                    Console.WriteLine("Campo válido");
                }
                else
                {
                    Console.WriteLine("Campo inválido");
                }
            }
        }
    }
}
