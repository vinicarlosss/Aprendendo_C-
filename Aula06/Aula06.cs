using System;

class Aula06{
    static void Main(){
        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto = "Pastel";

        valorVenda = valorCompra+(valorCompra*lucro);

        Console.WriteLine("Produto......:{0,15}",produto);
        Console.WriteLine("Val.Compra...:{0,15:c}",valorCompra); //:c indica o formato monetário
        Console.WriteLine("Lucro........:{0,15:p}",lucro); //:p indica porcentagem
        Console.WriteLine("Val.Venda....:{0,15}",valorVenda);
    }
}