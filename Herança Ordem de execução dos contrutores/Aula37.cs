using System;

class Base{
    public Base(){
        Console.WriteLine("Contrutor da clasee Base");
    }
}

class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Contrutor da clasee Derivada 1");
    }
}

class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Contrutor da clasee Derivada 2");
    }
}

class Aula37{
    static void Main(){
       Derivada2 derivada2 = new Derivada2(); 
    }
}