namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
    public Nokia (string NUMERO, string MODELO, string IMEI, int MEMORIA) : base(NUMERO, MODELO, IMEI, MEMORIA)
    {

    }
    public override void InstalarAplicativo(string APP)
    {
        Console.WriteLine($"Iniciando a instalação do aplicativo {APP} no seu Nokia");
    }
  }
}