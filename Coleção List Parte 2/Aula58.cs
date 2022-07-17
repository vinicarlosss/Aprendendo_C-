using System;
using System.Collections.Generic;

class Aula58{
    static void Main(){
        List<string> carros=new List<string>();

        carros.Insert(0, "Cruze");
        carros.Insert(1, "Gol");
        carros.Insert(0, "Fiat");
        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }
        
        int pos = carros.LastIndexOf("Gol");
        Console.WriteLine("Último GOL está na posição: {0}", pos);
        carros.Remove("Cruze");

        foreach(string c in carros){
            Console.WriteLine("Carro: {0}",c);
        }
    }
}