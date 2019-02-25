using System;

namespace TestConsoleCore
{
    public class TotalizadorDeContas : Conta
    {
        
        public void Soma(ContaCorrente conta)
        {
            SaldoTotal += this.Saldo;            
        }        

        public void Adiciona(ContaCorrente conta)
        {
            this.Saldo += SaldoTotal;
        }

        public override void Saca(double valor)
        {
            throw new NotImplementedException();
        }

        public override void Deposita(double valor)
        {
            throw new NotImplementedException();
        }
    
        
    }
}