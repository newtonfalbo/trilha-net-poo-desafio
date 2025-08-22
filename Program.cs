﻿using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Testando Nokia ###");
        Smartphone nokia = new Nokia("1199999-0000", "Nokia Tijolão", "123456789", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n### Testando iPhone ###");
        Smartphone iphone = new Iphone("1198888-1111", "iPhone 14 Pro", "987654321", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}
