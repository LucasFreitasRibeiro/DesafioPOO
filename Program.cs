using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Nokia(numero: "3242", modelo: "Modelo 2", imei: "123452352", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
