// Caminho: Domain/Types/TimeType.cs
namespace _247Locacao.Domain.Types
{
    public class TimeType : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Formato de hora (HH:mm)";
        public object DefaultValue => "00:00"; // Valor padrão como string
        public int? Size => 5;
    }
}
