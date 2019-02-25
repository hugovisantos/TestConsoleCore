using System;
using System.Collections.Generic;

namespace TestConsoleCore
{
    public class Cliente //o public permite que a classe seja visível fora do assembly que a declarou
    {
        // uma propriedade é composta por:
        // modificador de acesso public, protected ou private
        // o tipo dela int, string, bool...
        // o nome da propriedade (é recomendado que você crie uma propriedade public ou protected usando CamelCase)
        // e dois métodos chamados get e set
        
        public string Nome      { get; set; } //<- isso é uma propriedade
        public int Cpf          { get; set; }
        public string Rg        { get; set; }
        public string Endereco  { get; set; }
        public int Idade        { get; set; }
        public int Email        { get; set; }
        

        //OCORRE UMA SOBRECARGA DE CONSTRUTORES 
        /*public Cliente (string nome, int cpf, string rg, string endereco, int idade)
        {
            this.Nome = nome;
            this.Cfp = cpf;
            this.Rg = rg;
            this.Endereco = endereco;
            this.Idade = idade;
        }
        */
        //PARA ISSO REALIZAMOS..

        public Cliente (string nome)
        {
            this.Nome = nome;         
        }     
        
        //vamos lá

        //a estrutura de um método em C# é essa
        // modificador de acesso public, protected ou private
        // o tipo de retorno bool, int, string ....
        // o nome do método e dentro dos () os parâmetros
        // nesse caso você pode acessar as propriedade diretamente usando this.
        public bool EhMaiorDeIdade()
        {
            if (Idade >= 18)
                return true;
            return false;
        }
    
        
    }
}