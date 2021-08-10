using System;
using ProjetoVSCode.Materiais;
using ProjetoVSCode.Funcionarios;


namespace ProjetoVSCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************Estoque de Tintas*************");

            Tintas tinta1 = new Tintas(96,7,78.8);

            tinta1.Cor = "Vermelho ferrari";
            tinta1.Marca = "Corsini";
            
            
            Console.WriteLine("A cor da tinta é: " + tinta1.Cor);
            Console.WriteLine("A marca da tinta é: " + tinta1.Marca);
            Console.WriteLine("o Codigo da tinta no estoque é: " + tinta1.CodProduto);
            Console.WriteLine("o Valor da tinta é de: R$ " + tinta1.Valor);
            Console.WriteLine("A quantidade desta tinta no estoque é de: " + tinta1.QuantEstoque);
            
            
            Ferramentas ferramentas1 = new Ferramentas(87,4,74.1);
            Console.WriteLine("*************Estoque de Ferramentas*************");

            ferramentas1.Cor = "Prateado";
            ferramentas1.Marca = "Gianini";

            Console.WriteLine("A cor da ferramentasé: " + ferramentas1.Cor);
            Console.WriteLine("A marca da ferramentasé: " + ferramentas1.Marca);
            Console.WriteLine("o Codigo da ferramentasno estoque é: " + ferramentas1.CodProduto);
            Console.WriteLine("o Valor da ferramentasé de: R$ " + ferramentas1.Valor);
            Console.WriteLine("A quantidade desta ferramentasno estoque é de: " + ferramentas1.QuantEstoque);

            Parafusos Parafusos1 = new Parafusos(47,36,0.10);
            Console.WriteLine("*************Estoque de Parafusos*************");

            Parafusos1.Cor = "Galvanizado";
            Parafusos1.Marca = "Caterpilla";


            Console.WriteLine("A cor da Parafusosé: " + Parafusos1.Cor);
            Console.WriteLine("A marca da Parafusosé: " + Parafusos1.Marca);
            Console.WriteLine("o Codigo da Parafusosno estoque é: " + Parafusos1.CodProduto);
            Console.WriteLine("o Valor da Parafusosé de: R$ " + Parafusos1.Valor);
            Console.WriteLine("A quantidade desta Parafusosno estoque é de: " + Parafusos1.QuantEstoque);

            Cliente cliente1 = new Cliente(87, 20.0);

            cliente1.nome = "Maria";
            cliente1.endereco = "Rua das bergamotas";
            Console.WriteLine(cliente1.nome + " deve: " + cliente1.Devendo);
            cliente1.VenderFiado(32);
            bool resultadoVenderFiado = cliente1.VenderFiado(32);

            
            Console.WriteLine("O nome do cliente é: " + cliente1.nome);
            Console.WriteLine("O endereço de " + cliente1.nome + " é: " + cliente1.endereco);
            Console.WriteLine("Maria pode comprar fiado? " + resultadoVenderFiado);
            Console.WriteLine(cliente1.nome + " agora deve: " + cliente1.Devendo);

            Vendedor vendedor1 = new Vendedor(1980,89);

            vendedor1.nome = "Airton";
            vendedor1.VendaSemeste = 2030;

            Console.WriteLine("O nome do vendedor é: " + vendedor1.nome);
            Console.WriteLine("O codigo do vendedor é: " + vendedor1.CodPessoaV);
            Console.WriteLine("A venda semestral do vendedor é de: " + vendedor1.VendaSemeste); 
            Console.WriteLine("O salario do vendedor é de : " + vendedor1.Salario); 

            vendedor1.AumentarSalario();

            Console.WriteLine("O novo salario do vendedor após aumento de 10% é de:" + vendedor1.Salario);  

            RepresentanteExterno RepresentanteExterno1 = new RepresentanteExterno  (2072,90);

           RepresentanteExterno1.nome = "Airton";
           RepresentanteExterno1.VendaSemeste = 12000;

            Console.WriteLine("O nome do RepresentanteExterno é: " +RepresentanteExterno1.nome);
            Console.WriteLine("O codigo do RepresentanteExterno é: " +RepresentanteExterno1.CodPessoaV);
            Console.WriteLine("A venda semestral do RepresentanteExterno é de: " +RepresentanteExterno1.VendaSemeste); 
            Console.WriteLine("O salario do RepresentanteExterno é de : " +RepresentanteExterno1.Salario); 

           RepresentanteExterno1.AumentarSalario();

            Console.WriteLine("O novo salario doRepresentanteExterno após aumento de 50% é de:" +RepresentanteExterno1.Salario);            
        }
    }
}
