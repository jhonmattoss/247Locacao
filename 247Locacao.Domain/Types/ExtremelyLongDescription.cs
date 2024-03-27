// Caminho: Domain/Types/ExtremelyLongDescription.cs
namespace _247Locacao.Domain.Types
{
    public class ExtremelyLongDescription : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Descrição extremamente longa";
        public object DefaultValue => string.Empty;
        public int? Size => 7000;
    }
}
