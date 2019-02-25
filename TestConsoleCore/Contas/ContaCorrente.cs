namespace TestConsoleCore
{
    public class ContaCorrente : Conta
    {
        private static int totalDeContas = 0;
        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
        int proxima = ContaCorrente.ProximaConta();


        public override void Saca(double valor)
        {
            this.Saldo -= (valor + 0.1);
        }
        public override void Deposita (double valor)
        {           
            this.Saldo += valor;
        }
    
        
    }
}