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
            if (VendaSemeste < 2000.0)
              {
                  return false;
              }
              Salario = Salario + Salario * 0.10;
              return true;
        }
    }      
}