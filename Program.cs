using DesafioPOO.Models;

// Instanciando Nokia
Smartphone nokia = new Nokia(numero: "987654321", modelo: "Nokia 3310", imei: "111222333", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("----------------------");

// Instanciando iPhone
Smartphone iphone = new Iphone(numero: "123456789", modelo: "iPhone 13", imei: "999888777", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
