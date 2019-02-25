namespace TestConsoleCore
{
    public class TotalizadorDeTributos
    {
       public double Total{get; protected set;}

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        } 
    }
}