using System;

class Aula15 {
    public static object MessageBox { get; private set; }

    static void Main() {

      
        int[] indice=new int[3]{12,120, 144,};

        int contador=indice.Length-1;

        // for(int i=0; i<contador; i++){
        //     Console.Write(indice[i]);

        // }
        
        foreach (var i in indice)
        {
            Console.WriteLine(i);
            
        }

    }
}