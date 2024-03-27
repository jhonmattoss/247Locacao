// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Adicione os seguintes arquivos de classe:

// Nome do arquivo: Item.cs
namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Representa a entidade Item, detalhando os itens disponíveis para aluguel.
    /// </summary>
    public class Item : EntidadeBase
    {
        /// <summary>
        /// Inicializa uma nova instância da entidade Item.
        /// </summary>
        public Item() : base("ITM", "Item", "Detalha os itens disponíveis para aluguel, como características e estado.", "Admin", "Negócios")
        {
        }
    }
}