// Caminho: Domain/Types/PercentageRate.cs

namespace _247Locacao.Domain.Types
{
    public class PercentageRate : IBaseProprietaryType
    {
        public Type TipoBase => typeof(float); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Percentual de uma alíquota";
        public object DefaultValue => 0.0f; // Um float padrão
        public int? Size => null; // Tamanho não aplicável para float

        // Outros métodos e propriedades específicas, se necessário
    }
}

