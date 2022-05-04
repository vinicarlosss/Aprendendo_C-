using System;
class Aula17{
    static void Main(){
        int n1,n2,n3,n4,n5;
        int[] n = new int[5]; // Se indicar um numero de elementos não pode inserir mais indíces do que o indicado
        //int[] num = new int[3]{55,77,99};
        int[] num = {55,77,99};
        string[] veiculos = new string[3];

        veiculos[0] = "carro";
        veiculos[1] = "avião";
        veiculos[2] = "navio";

        n[0] = 111;
        n[1] = 222;
        n[2] = 333;
        n[3] = 444;
        n[4] = 555;
        Console.WriteLine(num[2]); 
    }
}