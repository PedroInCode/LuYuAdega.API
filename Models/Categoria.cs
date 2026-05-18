using System.ComponentModel.DataAnnotations;

namespace ProCatalog.API.Models;

public class Categoria
{
    /* 
     Anotação: 
     -> O "ID" é a chave primária.
     -> O Entity Framework entende automaticamente que esse campo deve ser auto-incremento no banco de dados. */
    [Key]
    public int Id { get; set; }

    /* 
     Anotação: 
     -> Uso "string.Empty" para evitar que o campo venha nulo.
     -> Em uma API, o Nome é o que identifica a categoria para o usuário. */
    public string Nome { get; set; } = string.Empty;

    public ICollection<Produto>? Produtos { get; set; } // Propriedade de navegação para os produtos relacionados a essa categoria.
}
