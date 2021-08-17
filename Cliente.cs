using System;
using CSharpTreinando_OOP;

namespace ProjetoVSCode
{
    public class Cliente
    {
        public string nome{get; set;}
        public int CodPessoa{get;}
        public string endereco {get; set;}
        private double _devendo;
        public double Valor { get; }

        public double Devendo
        {
            get
            {
                return _devendo;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _devendo = value;
            }
        }
        public Cliente(int codPessoa)
        { 
            if (codPessoa <=0)
            {
               throw new ArgumentException("CodPessoa igual ou menor que 0",nameof(codPessoa)); 
            }
            CodPessoa = codPessoa;
           
        }
        public void VenderFiado(double valor)
        {
            
          if (valor <= 0 )
          {
              throw new DevendoException(valor);
          }
          else
          {
          _devendo += valor;
          }
          
        } 
    }
}