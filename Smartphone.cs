namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero {get; set;}
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo {get; set;}
        private string Imei {get; set;}
        private int Memoria{get;set;}
        public Smartphone(string NUMERO, string MODELO, string IMEI, int MEMORIA)
        {
            this.Numero = NUMERO;
            // TODO: Passar os parâmetros do construtor para as propriedades
            this.Modelo = MODELO;
            this.Imei = IMEI;
            this.Memoria = MEMORIA;
        }
        public void Ligar()
        {
            Console.WriteLine("Ligando agora..");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo uma ligação..");
        }


        public abstract void InstalarAplicativo(string App);
    }
}