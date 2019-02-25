using System.Collections.Generic;
using System.Linq;

namespace TestConsoleCore
{
    public abstract class Conta //o public permite que a classe seja visível fora do assembly que a declarou
    {




        private static int numeroDeContas;

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }
        public static int ProximoNumero()
        {
            return numeroDeContas + 1;
        }

        public int Numero { get; protected set; } //bloqueia escrita e permite a leitura
        public double Saldo { get; protected set; } //bloqueia escrita e permite a leitura
        public Cliente Titular { get; protected set; }
        public double SaldoTotal { get; protected set; }


        public virtual void Saca(double valor) //virtual - permite uma classe filho sobreescrever
        {
        }
        public virtual void Deposita(double valor) //abstract - obriga a existencia do metodo na classe pai porem necessita de mudancas nas classes filhas 
        {
        }


        private void Filtra()
        {

            List<Conta> contas = new List<Conta>();
            
            var filtradas = contas.Where( c => c.Saldo > 2000 ); //filtra

            double total = contas.Sum(c => c.Saldo); //soma o saldo das contas
            
            double mediaDosSaldos = contas.Average(c => c.Saldo); // media do saldo das contas
            
            int numero = contas.Count(c => c.Numero < 1000); // número de contas que possuem Numero menor do que 1000

            int menorNumero = contas.Min(c => c.Numero);

            double maiorSaldo = contas.Max(c => c.Saldo);
        }





        //criacao de arrays(forms)
        // int[] umaocindo = new int[] { 1, 2, 3, 4, 5 };
        //private conta[] contas;
        //private void form1_load(object sender, eventargs e)
        //{
        //    contas = new conta[3];
        //    this.contas[0] = new conta();
        //     this.contas[0].titular = new cliente("cliente1");
        //     this.contas[0].numero = 1;

        //     this.contas[1] = new contapoupanca();
        //     this.contas[1].titular = new cliente("cliente2");
        //     this.contas[1].numero = 2;

        //     this.contas[2] = new contacorrente();
        //     this.contas[2].titular = new cliente("cliente3");
        //     this.contas[2].Numero = 3;
        // }


    }
}