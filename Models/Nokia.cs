using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo";
        public Nokia(string numero, string modelo, string Imei, int memoria) : base(numero, modelo, Imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}