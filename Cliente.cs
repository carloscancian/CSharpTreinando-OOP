namespace ProjetoVSCode
{
    public class Cliente
    {
        public string nome{get; set;}
        private int _codPessoa;
        public int CodPessoa
        {
            get
            {
                return _codPessoa; 
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _codPessoa = value;
            }
        }
        public string endereco {get; set;}
        private double _devendo;
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

        public Cliente(int codPessoa, double devendo )
        {
            CodPessoa = codPessoa;
            Devendo = devendo;
        }
        
        public bool VenderFiado(double valor)
        {
          if (this.Devendo > 25.5 )
          {
              return false;
          }
          this.Devendo += valor;
          return true;
        } 
    }
}