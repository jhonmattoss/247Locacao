// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Adicione os seguintes arquivos de classe:

// Nome do arquivo: Customer.cs
namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Representa a entidade Customer, armazenando detalhes dos clientes.
    /// </summary>
    public class Customer : EntidadeBase
    {
        /// <summary>
        /// Inicializa uma nova instância da entidade Customer.
        /// </summary>
        public Customer() : base("CSM", "Customer", "Armazena detalhes dos Clientes, como nome, contato, segurança...", "Admin", "Negócios")
        {
        }
    }
}