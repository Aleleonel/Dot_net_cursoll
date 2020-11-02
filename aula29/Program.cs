using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }
    ~Jogador(){
        Console.WriteLine("Jogador foi destruido");
    }

}
class Aula28{

    static void Main() {

        // string nome1;
        // Console.WriteLine("Escolha um nome: ");
        // nome1=Console.ReadLine();

        Jogador j1=new Jogador("Xemba-kao");
        Jogador j2=new Jogador("TrollMax");
        Jogador j3=new Jogador("Kalnnor");
        // Jogador j4=new Jogador(nome1);

        j1.energia=50;
        Console.WriteLine("Nome do Jogador 1: {0}", j1.nome);
        Console.WriteLine("Nome do Jogador 2: {0}", j2.nome);
        Console.WriteLine("Nome do Jogador 3: {0}", j3.nome);
        // Console.WriteLine("Nome do Jogador 4: {0}", j4.nome);
         
    }

}