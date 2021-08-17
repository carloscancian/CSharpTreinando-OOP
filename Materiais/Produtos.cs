using ProjetoVSCode;

namespace ProjetoVSCode.Materiais
{
    public abstract class Produtos
    {
       public string Cor {get; set;}
       private int _codProduto;
       public int CodProduto
       {
           get
           {
               return _codProduto;
           }
           set
           {
               if (value <= 0)
               {
                   return;
               }
               _codProduto = value;
           }  
       } 
       public string Marca{get; set;}
       public int QuantEstoque{get; set;}
       public double Valor{get; protected set;}

       
       public Produtos(int codProduto, int quantEstoque, double valor )
       {
           QuantEstoque = quantEstoque;
           CodProduto = codProduto;
           Valor = valor;
       }

    }

}