namespace ProCatalog.API.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal Preco { get; set; }
    public int Estoque { get; set; }

    //------Relacionamento------//
    
    /*Anotação: Todo produto precisa pertencer a uma categoria.
                Aqui guardamos o ID da categoria para o Banco de Dados saber o vínculo. */
    public int CategoriaId { get; set; }

    /*Anotação: Está é a "Propriedade de navegação".
                Ela permite que, no C#, eu faça: meuProduto.Categoria.Nome */
    public Categoria? Categoria { get; set; } 

}
