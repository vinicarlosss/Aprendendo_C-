using System;

class Aula23{
    static void Main(){
        int [] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};
        
        Random random = new Random();
        for(int i = 0;i<vetor1.Length;i++){
            vetor1[i] = random.Next(50);
        }

        Console.WriteLine("Elementos do vetor 1");
        foreach (int n in vetor1)
        {
            Console.WriteLine(n);
        }
        
        //public static int BinarySearch(array,valor);
        Console.WriteLine("\nBinarySearch");
        int procurado=33;
        int pos = Array.BinarySearch(vetor1,procurado);
        Console.WriteLine("Valor {0} está na posição {1}",procurado,pos);
        Console.WriteLine("------------------------------------\n");

        //public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach (int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("-----------------------------------------");

        //public void CopyTo(Ar_destino, a_partir_desta_pos);
        Console.WriteLine("\nCopyTo");
        vetor1.CopyTo(vetor3, 0);
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("------------------------------------------");

        //public long GetLongLength(dimensão);
        Console.WriteLine("\nGetLongLength");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
        Console.WriteLine("-------------------------------");
        
        //public int getlowerBound(dimensão);
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor =vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1 = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor1 {0}", MenorIndiceVetor);
        Console.WriteLine("---------------------");

        //public int getUpperBound(dimensão);
        Console.WriteLine("\nGetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice da matriz é {0}", MaiorIndiceMatriz);
        Console.WriteLine("-------------");

        //public object GetValue(long indice);
        Console.WriteLine("\nGetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz1.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor 1: {0}", valor0);
        Console.WriteLine("--------------------------------");

        //public static int IndexOf(array,valor);
        Console.WriteLine("\nIndexOf");
        int indice1 = Array.IndexOf(vetor1, 3);
        Console.WriteLine("Indice do primeiro valor 3: {0}", indice1);

        //public static int LastIndexOf(array, valor);
        Console.WriteLine("\nLastIndexOf");
        int indice2 = Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do ultimo valor 3: {0}",indice2);
        Console.WriteLine("------------------------/n");
    }
}