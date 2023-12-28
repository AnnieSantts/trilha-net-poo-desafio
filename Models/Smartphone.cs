namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama OK
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private string Memoria { get; set; }
        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades ok
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        protected Smartphone(string numero)
        {
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}