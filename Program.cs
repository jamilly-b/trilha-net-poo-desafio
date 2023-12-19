using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone **** Feito! ****
Console.WriteLine("Smartphone Nokia: ");
Console.WriteLine("");
Smartphone nokia = new Nokia(numero: "945234", modelo: "tijolao", imei: "12423430", memoria: 16);
nokia.Ligar();
Console.WriteLine("");
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n________________\n");

Console.WriteLine("Smartphone Iphone: ");
Console.WriteLine("");
Smartphone iphone = new Iphone(numero: "43645767", modelo: "Iphone 14 PRO MAX", imei: "13456523", memoria: 254);
iphone.ReceberLigacao();
Console.WriteLine("");
iphone.InstalarAplicativo("Word");