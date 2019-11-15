using System;

namespace Jaulas
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public DateTime DataEntrada { get; set; }
        public int NumeroJaula { get; set; }
    }
}
