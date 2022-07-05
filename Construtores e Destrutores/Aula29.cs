using System;

public class Jogador{
    public int energia;
    public bool vivo;

    public string nome;
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome = n;
    }
    ~Jogador(){
        Console.WriteLine("Jogador foi destruído");
    }

}
class Aula29{
    static void Main(){

        string nome1;
        Console.WriteLine("Digite o nome do jogador 1: ");
        nome1 = Console.ReadLine();
        Jogador j1=new Jogador(nome1);
        Jogador j2=new Jogador("Eduardo");
        Jogador j3=new Jogador("Matheus");

        j2.energia = 50;
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);

        Console.WriteLine("O nome do jogador 1: {0}", j1.nome);
        Console.WriteLine("O nome do jogador 2: {0}", j2.nome);
        Console.WriteLine("O nome do jogador 3: {0}", j3.nome);
    }
}