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
              if (VendaSemeste < 2350.0)
              {
                  return false;
              }
              Salario = Salario + Salario * 0.50;
              return true;  
        }
    }
}
