using System;
class Aula12{
    static void Main(){
        int nota = 0;
        string resultado = "Reprovado";
        Console.Write("Digite a nota: ");
        nota = int.Parse(Console.ReadLine());
        if(nota >= 60){
            resultado = "Aprovado";
        }
        Console.WriteLine("Resultado: {0}", resultado);
    }
}