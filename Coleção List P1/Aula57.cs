using System;
using System.Collections.Generic;

class Aula57{
    static void Main(){
        List<string> carros=new List<string>();
        string[] carros2=new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");

        carros2.AddRange(carros);

        if(carros.Contains("Golf")){
            Console.WriteLine("Está na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }
        
       

        carros.CopyTo(carros2,2);

        foreach(string c in carros2){
            Console.WriteLine("Carro: {0}", c);
        }

    }
}