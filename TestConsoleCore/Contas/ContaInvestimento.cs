namespace TestConsoleCore
{
    public class ContaInvestimento : Conta, ITributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.1);
        }
        public override void Deposita (double valor)
        {
            if(valor >= 10000 )
                this.Saldo += (valor * 0.005);            
            else
                this.Saldo += valor;
        }
        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        }
    
        
    }
}