using System.Globalization;

namespace ConsolePOOProduto.Entidade
{
  internal class Produto
  {
    public string Nome= "";
    public double Preco;
    public int quantidade;

    public double ValorTotalEmEstoque() {
      return this.quantidade * this.Preco;
    }

    public void AdicionarProdutos(int quantity ) {
      this.quantidade += quantity;
    }

    public void RemoverProdutos(int quantity) {
      this.quantidade -= quantity;
    }

    public override string ToString()
    {
      return this.Nome + ", $" +
             this.Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " +
             this.quantidade + " unidades, Total: " +
             this.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

    }

  }
  }
