Class
[modificadorClasse] class Nome_Classe{
    <!-- variaéveis / propriedades -->
    [EspecificadorAcesso] tipo Nome_Propriedade;
    <!-- Metodos -->
    [EspecificadorAcesso] retorno Nome_Metodo([arg1, arg2...]){
        <!-- Corpo do metodo -->
    }
}

[ModificadorClasse:] <!--ModificadorClasse: Define a visibilidade da classe -->
[public:]<!-- public: Pública, sem restrição de visulaização -->
[abstract:]<!-- abstract: Classse-Base para outras classes, não podem ser instanciados objetos desta classe -->
[sealed:]<!-- sealed: Class não pode ser herdada -->
[static:]<!-- static: Classe não permite a instanciação de objetos e seus membros devem ser static -->


[EspecificadorAcesso]<!-- Onde os membros da classe podem ser acessado  -->
[public:] <!-- sem restrição de acesso -->
[private:] <!-- Só podem ser acessado pela propria classes derivadas -->
[protected:] <!-- Podem ser acessados na propria classe e nas classes derivadas -->
[abstract:]<!-- Os metodos não tem implementação somente os cabeçalhos -->
[sealed:]<!-- Os metodos não pode ser definido -->
[virtual:]<!-- O metodo pode ser redefinido em uma classe derivada -->
[static:]<!-- O metodo pode ser chamado mesmo sem a instaciação de um objeto -->
