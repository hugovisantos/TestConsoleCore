using System;

namespace TestConsoleCore
{
    public class ContaPoupanca : Conta
    {      
        public override void Saca(double valor)
        {
            if(valor + 0.1 <= this.Saldo)
            {
                throw new Exception("Valor do saque maior que o saldo");
            }
            else 
                this.Saldo -= valor + 0.10;
        }
        public override void Deposita (double valor)
        {
            if(valor >= 1000 )
                this.Saldo += (valor + 1);            
            else
                this.Saldo += valor;
        }
        // public double CalculaTributo()
        // {
        //     return this.Saldo * 0.02;
        // }
    
        
    }
}