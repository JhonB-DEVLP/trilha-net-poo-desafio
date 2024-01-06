using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
   public static void Main(string[] args)
    {
Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia("012345", "Tipo 01", "0000111122", 32);
Nokia.Ligar();
Nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone Iphone = new Iphone("111111", "12 Pro Max", "11111333555", 256);
Iphone.Ligar();
Iphone.InstalarAplicativo("Youtube");
    }
}