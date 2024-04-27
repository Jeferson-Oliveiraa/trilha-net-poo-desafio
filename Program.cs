using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");

Smartphone nokia = new Nokia (numero:"123456", modelo: "Modelo 1", Imei: "11111111" ,memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("/n");

Smartphone iphone = new Iphone (numero:"523453", modelo: "Modelo 2", Imei: "2222222" ,memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegran");

