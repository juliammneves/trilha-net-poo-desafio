using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Nokia n = new Nokia("12345", "x12", "111111", 64);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nIphone:");
Iphone i = new Iphone("12345", "14 pro Max", "2222222", 128);
i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("Instagram");
