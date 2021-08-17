using System;

namespace CSharpTreinando_OOP
{
    public class DevendoExeption : Exception
    {
        public DevendoExeption()
        {

        }

        public DevendoExeption(string mensagem) : base (mensagem)
        {

        }

        public double Devendo { get; }

        public DevendoExeption(double devendo) : this ("Erro, valor devedor negativo!" + devendo)
        {
          Devendo = devendo;
        }
    }
}