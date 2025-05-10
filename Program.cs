using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// 1. A classe Smartphone deve ser abstrata, não permitindo instanciar e servindo apenas como modelo.
// Smartphone smartphone = new Smartphone(); Impossível.

// 2. A classe Nokia e Iphone devem ser classes filhas de Smartphone.
System.Console.WriteLine("Iphone é filho de Smartphone: " + typeof(Iphone).IsSubclassOf(typeof(Smartphone)));
System.Console.WriteLine("Nokia é filho de Smartphone: " + typeof(Nokia).IsSubclassOf(typeof(Smartphone)));

System.Console.WriteLine();
// 3. O método InstalarAplicativo deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.
Iphone iphone = new Iphone("+55 22 9 91000001", "12 Pro Max", "33 44 5555 6666 777", 256);
Nokia nokia = new Nokia("+55 11 9 91000001", "Nokia 2.4", "44 55 6666 7777 888", 64);
iphone.InstalarAplicativo("AppStore");
nokia.InstalarAplicativo("NokiaSettings");