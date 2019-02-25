using System;
using System.Collections.Generic;
using System.IO;

namespace TestConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream arquivo = null;
            StreamReader leitor = null;

            try
            {
                arquivo = File.Open("arquivo.txt", FileMode.Open);
                leitor = new StreamReader(arquivo);

            }
            catch (Exception ex)
            {
                Console.WriteLine("arquivo inexistente");
            }
            finally
            {
                if(leitor != null)
                {
                    leitor.Close();
                }
                if(arquivo != null)
                {
                    arquivo.Close();
                }
            }

            ////leitura de arquivos 
            //if (File.Exists("entrada.txt"))
            //{
            //    Stream entrada = File.Open("entrada.txt", FileMode.Open);
            //    StreamReader leitor = new StreamReader(entrada);
            //    string linha = leitor.ReadToEnd();                
            //    leitor.Close();
            //    entrada.Close();
            //}
            ////
            ////escrita de arquivos 
            //Stream saida = File.Open("saida.txt", FileMode.Create);
            //StreamWriter escritor = new StreamWriter(saida);
            //escritor.WriteLine("minha mensagem");
            //escritor.Close();
            //saida.Close();
            ////

            
            string nome;
            int cpf;
            string rg;
            nome = Console.ReadLine();
            cpf = Convert.ToInt32(Console.ReadLine());
            rg = Console.ReadLine();

            Cliente cliente1 = new Cliente(nome)
            {
                Cpf = cpf,
                Rg = rg,

            };

            //construtor
            Cliente cliente = new Cliente("Hugo") //obrigatorio colocar o nome, pois solicita a string nome na class Cliente 
            {
                Cpf = 21,       //propriedade, nao obrigatorio
                Rg = "MG12",    //propriedade, nao obrigatorio
            };




            ContaPoupanca cp = new ContaPoupanca();
            ContaCorrente cc = new ContaCorrente();            
            TotalizadorDeContas tc = new TotalizadorDeContas();

            
            Console.WriteLine("Numero da conta: " + cc.Numero);
            Console.WriteLine("Saldo da conta:" + cc.Saldo);
            Console.WriteLine("Titular da conta:" + cc.Titular);

            // System.Console.WriteLine("Saque efetuado com sucesso!!"); 
        }
    }
}
