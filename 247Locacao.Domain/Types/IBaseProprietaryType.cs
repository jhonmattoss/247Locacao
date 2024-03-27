// Caminho: Domain/Types/IBaseProprietaryType.cs

namespace _247Locacao.Domain.Types
{
    public interface IBaseProprietaryType
    {
        Type TipoBase { get; }
        string Description { get; }
        object DefaultValue { get; }
        int? Size { get; }
    }
}
