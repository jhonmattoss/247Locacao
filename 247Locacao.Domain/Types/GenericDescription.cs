// Caminho: Domain/Types/GenericDescription.cs
namespace _247Locacao.Domain.Types
{
    public class GenericDescription : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Descrição genérica";
        public object DefaultValue => string.Empty;
        public int? Size => 50;
    }
}

