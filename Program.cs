using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone | DONE

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "+55 (22) 99999-8888", modelo: "Nokia G50", imei: "11111111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "+55 (99) 66666-4444", modelo: "iPhone XR", imei: "222222222222222", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
