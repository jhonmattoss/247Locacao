// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Adicione os seguintes arquivos de classe:

// Nome do arquivo: User.cs
namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Representa a entidade User, armazenando detalhes dos usuários.
    /// </summary>
    public class User : EntidadeBase
    {
        /// <summary>
        /// Inicializa uma nova instância da entidade User.
        /// </summary>
        public User() : base("USR", "User", "Armazena detalhes dos usuários, como nome, contato e credenciais.", "Admin/Negócios", "Negócios")
        {
        }
    }
}