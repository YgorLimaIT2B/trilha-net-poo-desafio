using DesafioPOO.Models;

Console.WriteLine("Teste no Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia 1", imei: "321", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("/n");

Console.WriteLine("Teste iphone");
Smartphone iphone = new Iphone(numero: "654321", modelo: "iphone 1", imei: "123", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Zap Zap");

