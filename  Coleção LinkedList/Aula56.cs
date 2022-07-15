using System;
using System.Collections.Generic;

class Aula56{
    static void Main(){
        
        LinkedList<string> transp = new LinkedList<string>();
        
        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta");

        transp.AddLast("Bicicleta");

        LinkedListNode<string> no;
        no=transp.FindLast("Navio");
        transp.AddAfter(no, "Patinete");

        no=transp.FindLast("Motocicleta");
        transp.AddBefore(no, "Patins");
        transp.Remove("Navio");
        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}", t);
        }

        //transp.Clear();

        if(transp.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemento encontrado");
        }

        transp.RemoveFirst();
        transp.RemoveLast();

        foreach(string i in transp){
            Console.WriteLine(i);
        }

        

    }
}