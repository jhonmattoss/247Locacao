
// Caminho: Domain/Types/SelectionDescription.cs
namespace _247Locacao.Domain.Types
{
    public class SelectionDescription : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Descrição para seleção";
        public object DefaultValue => string.Empty;
        public int? Size => null; // Tamanho indefinido para textos longos
    }
}

