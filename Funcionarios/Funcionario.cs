namespace ProjetoVSCode.Funcionarios
{
    public abstract class Funcionario
    {
         public string nome{get; set;}
        private int _codPessoaV;
        public int CodPessoaV
        {
            get
            {
                return _codPessoaV;
            }
            set 
            { 
                if (value <= 0)
                {
                    return;
                }
                _codPessoaV = value;
            }
        }
        private double _vendaSemestre;
        public double VendaSemeste
        {
            get
            {
                return _vendaSemestre;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _vendaSemestre = value;
            }
        }

        protected double _salario;
        public double Salario
        {
            get
            {
                return _salario;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _salario = value;
            }

        }
            public Funcionario(double salario, int codPessoaV)
          {
              Salario = salario;
              CodPessoaV = codPessoaV;
          }   
        }
    }
