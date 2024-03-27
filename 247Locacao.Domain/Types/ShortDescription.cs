
// Caminho: Domain/Types/ShortDescription.cs
namespace _247Locacao.Domain.Types
{
    public class ShortDescription : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Descrição curta";
        public object DefaultValue => string.Empty;
        public int? Size => 20;
    }
}
