using ProjetoVSCode;
namespace ProjetoVSCode.Funcionarios
{
    public class Vendedor : Funcionario, IFuncionario
    {
        public Vendedor(double salario, int codPessoaV) : base(salario, codPessoaV)
        {
        }

        public bool AumentarSalario()
        {
            if (this.VendaSemeste < 2000.0)
              {
                  return false;
              }
              this.Salario = Salario + Salario * 0.10;
              return true;
        }
    }      
}