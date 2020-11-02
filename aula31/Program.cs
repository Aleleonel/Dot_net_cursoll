using System;

public class Jogador{
    public int energia;
    public bool vivo;
    public string nome;
    public Jogador(){
        energia=100;
        vivo=true;
        nome="Jogador"; 
    }
    public Jogador(string n){
        energia=100;
        vivo=true;
        nome=n;
    }
    public Jogador(string n, int e){
        energia=e;
        vivo=true;
        nome=n;
    }
    public Jogador(string n, int e, bool v){
        energia=e;
        vivo=v;
        nome=n;
    }
    public void info(){
        Console.WriteLine("Jogador {0}", nome);
        Console.WriteLine("Energia {0}", energia);
        Console.WriteLine("Status  {0}\n", vivo);
    }
}
class Aula30{

    static void Main() {

        
        // Console.WriteLine("Escolha um nome: ");
        // string nome1=Console.ReadLine();
        // Console.WriteLine("Nome: {0}", nome1);
        // Console.WriteLine("Press ENTER to continue...");
        // Console.ReadLine();

        Jogador j1=new Jogador("Xemba-kao");
        Jogador j2=new Jogador("TrollMax", 100);
        Jogador j3=new Jogador("Kalnnor", 30);
        Jogador j4=new Jogador("Zorian",0, false);

        
        j1.info();
        j2.info();
        j3.info();
        j4.info();
         
    }

}