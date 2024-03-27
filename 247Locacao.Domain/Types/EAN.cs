// Caminho: Domain/Types/EAN.cs
namespace _247Locacao.Domain.Types
{
    public class EAN : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "European Article Number";
        public object DefaultValue => string.Empty;
        public int? Size => 13;
    }
}
