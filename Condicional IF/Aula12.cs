using System;
class Aula12{
    static void Main(){
        int nota = 80;
        string resultado = "Reprovado";
        if(nota >= 60){
            resultado = "Aprovado";
        }
        Console.WriteLine("Resultado:{0}", resultado);
    }
}