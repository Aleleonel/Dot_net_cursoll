using System;

class Aula24 {
    public static object MessageBox { get; private set; }

    static void Main() { 

        int n1, n2, r;
        
        // n1 = Convert.ToInt32(Console.ReadLine());
        // n2 = Convert.ToInt32(Console.ReadLine());
        n1 = n2 = 90;

        r=soma(n1, n2);
        Console.WriteLine("A soma de {0} + {1} é = {2} ", n1, n2, r);
    }

    static int soma(int n1, int n2) {
        int res = n1 + n2;
        return res;
   
    }
}