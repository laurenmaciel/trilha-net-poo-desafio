using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "9689-6524", modelo: "Modelo 1", imei: "123456789", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");
nokia.InstalarAplicativo("Instagram");
// adicionar mais um instalar app

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero:"9354 - 4852", modelo: "Modelo 2", imei:"987654321", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.InstalarAplicativo("Tik Tok");
iphone.ReceberLigacao("3245 - 2541");