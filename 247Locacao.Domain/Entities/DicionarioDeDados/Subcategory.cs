// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Adicione os seguintes arquivos de classe:

// Nome do arquivo: Subcategory.cs
namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Representa a entidade Subcategory, uma subdivisão das categorias de itens.
    /// </summary>
    public class Subcategory : EntidadeBase
    {
        /// <summary>
        /// Inicializa uma nova instância da entidade Subcategory.
        /// </summary>
        public Subcategory() : base("SUB", "Subcateg", "Subdivisão das categorias para especificação detalhada dos itens.", "Admin", "Negócios")
        {
        }
    }
}