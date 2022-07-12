using System;

sealed class Veiculo{//Classe sealed
    
}

class Carro:Veiculo{   //Classe carro herdando de class veiculo

}
class Aula40{
    static void Main(){
        Carro c1 = new Carro(); // vai dar erro, pois classes sealed não podem ser usadas como classe base.
    }
}