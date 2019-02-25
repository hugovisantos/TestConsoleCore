using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleCore.Busca
{
    public class GeradorDeDevedores
    {
        public List<string> GeraList()
        {
            List<string> nomes = new List<string>();
            for(int i=0 ; i < 30000; i++)
            {
                nomes.Add("devedor " + i);
            }
            return nomes;
        }
    }
}
