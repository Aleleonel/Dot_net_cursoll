using System;

class Aula15 {
    static void Main() {

        int n1, n2, n3, n4, n5;
        int[] n=new int[5]{120, 666, 144, 12, 120,};
        int[] indice=new int[5];

        for (int i = 0; i < 5; i++)
        {
             
            indice[i]=n[i];
            Console.WriteLine("Este valor esta na casa {0}: {1}",i,indice[i]);
        }
      

    }
}