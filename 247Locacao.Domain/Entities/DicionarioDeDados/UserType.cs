// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Adicione os seguintes arquivos de classe:

// Nome do arquivo: UserType.cs
namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Representa a entidade UserType, definindo os tipos de usuários (locador ou locatário).
    /// </summary>
    public class UserType : EntidadeBase
    {
        /// <summary>
        /// Inicializa uma nova instância da entidade UserType.
        /// </summary>
        public UserType() : base("USR_T", "UserType", "Define se o usuário será locador ou locatário.", "Negócios", "Negócios")
        {
        }
    }
}