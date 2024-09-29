using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "66498791216", modelo: "Modelo 1", imei: "11349689468651", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone(numero: "9989516564", modelo: "Modelo 2", imei: "498735419654", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
