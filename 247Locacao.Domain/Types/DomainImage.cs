
// Caminho: Domain/Types/DomainImage.cs
namespace _247Locacao.Domain.Types
{
    public class DomainImage : IBaseProprietaryType
    {
        public Type TipoBase => typeof(string); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Imagem de domínio";
        public object DefaultValue => null; // Pode ser uma URL padrão ou identificador de imagem
        public int? Size => null; // Tamanho pode variar
    }
}

