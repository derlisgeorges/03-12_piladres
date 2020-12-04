using System;
using Pilares.classe;

namespace Pilares
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();
            
            pessoa1.nome = "Derlis";

            pessoa1.Soma(5,5);

            pessoa1.soma(5,0.3f);

        }
    }
}
