using System;
using ProjetoVSCode;
namespace ProjetoVSCode.Funcionarios
{
    public class Vendedor : Funcionario, ISalario
    {
        public Vendedor(double salario, int codPessoaV) : base(salario, codPessoaV)
        {
        }

        public bool AumentarSalario()
        {
            try
            {
             if (VendaSemeste < 2000.0)
              {
                  return false;
              }
              Salario += Salario * 0.10;
              return true;
            }
            catch (Exception e)
            {
               Console.WriteLine(e.Message);
               Console.WriteLine(e.StackTrace);
               throw;
            }  
        }
    }      
}