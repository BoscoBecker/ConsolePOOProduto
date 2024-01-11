// See https://aka.ms/new-console-template for more information
using ConsolePOOProduto.Entidade;
using System.Globalization;

Console.Write("Entre com  os dados do produto: ");
Produto produto = new Produto();
Console.Write("Nome:");
produto.Nome = Console.ReadLine();
Console.Write("Preço: ");
produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
produto.quantidade = int.Parse(Console.ReadLine());

/// Esse é o  exemplo fazendo o override no método virtual ToString();
Console.Write("Dados do produto: " + produto);

//Console.WriteLine("Dados do produto: "+ produto.Nome + " R$"+produto.Preco+ " Quantidade:"+produto.ValorTotalEmEstoque()+ " Total :"+(produto.quantidade*produto.Preco));
/*Console.WriteLine("Dados do produto: " + produto);
Console.WriteLine("Digite o numero de produtos a ser adicionado no estoque: ");
produto.AdicionarProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados Atualizados " + produto.Nome + " R$" + produto.Preco + " Quantidade:" + produto.ValorTotalEmEstoque() + " Total :" + (produto.quantidade * produto.Preco));
Console.WriteLine("Digite  o Numero de produtos a ser removido do estoque ");
produto.RemoverProdutos(int.Parse(Console.ReadLine()));
Console.WriteLine("Dados Atualizados " + produto.Nome + " R$" + produto.Preco + " Quantidade:" + produto.ValorTotalEmEstoque() + " Total :" + (produto.quantidade * produto.Preco));
*/