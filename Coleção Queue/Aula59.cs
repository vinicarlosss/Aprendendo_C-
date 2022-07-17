using System;
using System.Collections.Generic;

class Aula59{
    static void Main(){

        //string[] vs={"Carro", "Moto", "Navio", "Aviao"};
        Queue<string> veiculos=new Queue<string>();

        veiculos.Enqueue("Carro");
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v = "Aviao";
        if(veiculos.Contains(v)){
            Console.WriteLine("Veiculo {0} encontrado", v);
        }else{
            Console.WriteLine("Veículo {0} não está na fila", v);
        }
        //veiculos.Clear();
        Console.WriteLine("Primeiro Veículo: {0}", veiculos.Dequeue());
        Console.WriteLine("Primeiro Veículo: {0}", veiculos.Peek());
        Console.WriteLine("Tamanho da Fila: {0}", veiculos.Count);

        while(veiculos.Count>0){
            Console.WriteLine(veiculos.Dequeue());
            Console.WriteLine(veiculos.Count);
        }

    }
}