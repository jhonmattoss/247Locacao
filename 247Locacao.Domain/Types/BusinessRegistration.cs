// Caminho: Domain/Types/BusinessRegistration.cs

namespace _247Locacao.Domain.Types
{
    /// <summary>
    /// Representa o tipo para Cadastro Geral de Contribuinte.
    /// </summary>
    public class BusinessRegistration : IBaseProprietaryType
    {
        /// <summary>
        /// Obtém o tipo base do Cadastro Geral de Contribuinte, que é uma string.
        /// </summary>
        public Type TipoBase => typeof(string);

        /// <summary>
        /// Obtém a descrição do Cadastro Geral de Contribuinte.
        /// </summary>
        public string Description => "Cadastro Geral de Contribuinte";

        /// <summary>
        /// Obtém o valor padrão para o Cadastro Geral de Contribuinte, que é uma string vazia.
        /// </summary>
        public object DefaultValue => string.Empty;

        /// <summary>
        /// Obtém o tamanho máximo para o Cadastro Geral de Contribuinte, que é de 18 caracteres.
        /// </summary>
        public int? Size => 18;
    }
}
