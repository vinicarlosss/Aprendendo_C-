using System;

namespace Calc1{
    class Area{
        public static float Quad(float bas, float alt){
            if(bas == 0 || alt ==0){
                throw new Exception("Base ou altura não podem ser igual a 0");
            }
            return bas*alt;
        }
    }
}

class Aula54{
    static void Main(){
        int n1,n2, res;
        float area=0;
        res=n1=n2=0;

        n1=10;
        n2=5;
        try{
            res=n1/n2;
            Console.WriteLine("{0}/{1}={2}", n1,n2,res);
            throw new Exception("CFB Cursos");
        }catch(Exception e){
            Console.WriteLine("Erro: {0}", e.Message);
            Console.WriteLine("Erro: {0}", e);
            Console.WriteLine("Erro: {0}", e.GetType());
        }finally{
            Console.WriteLine("Fim do processo");
        }
        

        try{
            area = Calc1.Area.Quad(0, 5F);
            Console.WriteLine("Area do quadrado: {0}", area);
        }catch(Exception e){
            Console.WriteLine("ERRO: {0}", e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }
        
    }
}