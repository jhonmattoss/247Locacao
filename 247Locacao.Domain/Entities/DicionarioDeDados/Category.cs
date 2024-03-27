// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Adicione os seguintes arquivos de classe:

// Nome do arquivo: Category.cs
namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Representa a entidade Category, classificando itens em categorias.
    /// </summary>
    public class Category : EntidadeBase
    {
        /// <summary>
        /// Inicializa uma nova instância da entidade Category.
        /// </summary>
        public Category() : base("CAT", "Categ", "Classifica os itens em categorias para organização e busca.", "Admin", "Negócios")
        {
        }
    }
}