using System;

namespace CSharpTreinando_OOP
{
    public class DevendoException : Exception
    {
        public DevendoException()
        {

        }

        public DevendoException(string mensagem) : base (mensagem)
        {

        }

        public double Devendo { get; }

        public DevendoException(double devendo) : this ("Erro, valor devedor negativo!" + devendo)
        {
          Devendo = devendo;
        }
    }
}