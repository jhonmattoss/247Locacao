// Caminho: Domain/Types/IntegerValue.cs
namespace _247Locacao.Domain.Types
{
    public class IntegerValue : IBaseProprietaryType
    {
        public Type TipoBase => typeof(int); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Valor inteiro genérico";
        public object DefaultValue => 0; // Valor padrão como inteiro
        public int? Size => null; // Não aplicável para inteiros
    }
}

