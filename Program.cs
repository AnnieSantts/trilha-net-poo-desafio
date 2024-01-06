using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia n1 = new Nokia("(11)123458", "x12gb","12bhj36576", 250 );
n1.InstalarAplicativo("Candy Crush");
n1.ReceberLigacao();
n1.Ligar();
n1.Numero = "123456789";
Console.WriteLine("Número alterado para: "+ n1.Numero);


Iphone a1 = new Iphone("(12)123458", "13 Pro Max","128956537", 500 );
a1.InstalarAplicativo("Linkedin");
a1.ReceberLigacao();
a1.Ligar();