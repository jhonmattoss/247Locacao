
// Caminho: Domain/Types/PostalCode.cs

namespace _247Locacao.Domain.Types
{
    public class PostalCode : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Código Postal";
        public object DefaultValue => string.Empty;
        public int? Size => 9;

        // Outros métodos e propriedades específicas, se necessário
    }
}
