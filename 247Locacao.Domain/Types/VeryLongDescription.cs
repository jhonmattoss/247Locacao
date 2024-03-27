
// Caminho: Domain/Types/VeryLongDescription.cs
namespace _247Locacao.Domain.Types
{
    public class VeryLongDescription : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Descrição muito longa";
        public object DefaultValue => string.Empty;
        public int? Size => 255;
    }
}
