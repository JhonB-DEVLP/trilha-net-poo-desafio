namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string NUMERO, string MODELO, string IMEI, int MEMORIA) : base(NUMERO, MODELO, IMEI, MEMORIA)
    {

    }
        public override void InstalarAplicativo(string APP)
        {
          Console.WriteLine($"Iniciando a instalação do aplicativo {APP} no seu iphone");
        }
    }
}