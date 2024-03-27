
// Caminho: Domain/Types/LongDescription.cs
namespace _247Locacao.Domain.Types
{
    public class LongDescription : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Descrição longa";
        public object DefaultValue => string.Empty;
        public int? Size => 120;
    }
}

