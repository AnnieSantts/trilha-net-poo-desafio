
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" OK
    public class Iphone : Smartphone
    {
        public Iphone(string numero) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" OK
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando app para sistema IOS");
        }

        internal void InstalarAplicativo()
        {
            throw new NotImplementedException();
        }
    }
}