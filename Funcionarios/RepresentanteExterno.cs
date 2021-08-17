using System;
using ProjetoVSCode;
namespace ProjetoVSCode.Funcionarios
{
    public class RepresentanteExterno : Funcionario, ISalario
    {
        public RepresentanteExterno(double salario, int codPessoaV) : base(salario, codPessoaV)
        {

        }

        public bool AumentarSalario()
        {
            try 
            {
              if (VendaSemeste < 2350.0)
              {
                  return false;
              }
              Salario += Salario * 0.50;
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
