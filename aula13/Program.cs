using System;

class Aula14 {

    static void Main() {

        char escolha='o';
        int tempo;

        inicio:

        // Console.WriteLine("Viage de São Paulo/SP a Rio de Janeiro/RJ");
        // Console.WriteLine("EScolha o transporte: [a]Avião | [c]Carro | [o]Ônibus ");

        // escolha=char.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 'a':
                tempo=50;
                break;
            case 'c':
                tempo=8*60;
                break;
            case 'o':
                tempo=16*60;
                break;

            default:
                tempo=-1;
                break;
        }

        if(tempo<0){
            Console.WriteLine("Transporte indisponível");

        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é {0}", tempo);
        }


    }
}