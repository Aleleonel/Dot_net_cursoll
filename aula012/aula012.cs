using System;
using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
class Program
{
    // static void Main()
    {
        int nota = 80;
        string resultado;

        if(nota >= 80){
            resultado="Aprovado";
        }else if ((nota >= 70) & (nota < 80 )){
            resultado="Recuperação";
            
        }else{
            resultado="Reprovado";
        }

        Console.WriteLine("Resultado: {0}", resultado);
        
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}

