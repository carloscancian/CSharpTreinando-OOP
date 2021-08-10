using ProjetoVSCode;
namespace ProjetoVSCode.Funcionarios
{
    public class RepresentanteExterno : Funcionario, IFuncionario
    {
        public RepresentanteExterno(double salario, int codPessoaV) : base(salario, codPessoaV)
        {

        }

        public bool AumentarSalario()
        {
              if (this.VendaSemeste < 2350.0)
              {
                  return false;
              }
              this.Salario = Salario + Salario * 0.50;
              return true;  
        }
    }
}
