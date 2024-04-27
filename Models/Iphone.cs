namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo
        public Iphone (String numero, string modelo, string Imei, int memoria) : base (numero, modelo, Imei, memoria){}
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no iPhone");
        }
    }

    }