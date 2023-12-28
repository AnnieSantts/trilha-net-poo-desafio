using System.Diagnostics;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" OK
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class Nokia : Smartphone
    {
        public Nokia(string numero) : base(numero)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando app para sistema android");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        // TODO: Sobrescrever o método "InstalarAplicativo" OK
    }
}