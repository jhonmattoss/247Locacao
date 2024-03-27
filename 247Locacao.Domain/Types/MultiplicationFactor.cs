
// Caminho: Domain/Types/MultiplicationFactor.cs
namespace _247Locacao.Domain.Types
{
    public class MultiplicationFactor : IBaseProprietaryType
    {
        public Type TipoBase => typeof(float); // Mudamos para usar o sistema de tipos do C#
        public string Description => "Fator de multiplicação";
        public object DefaultValue => 1.0f; // Valor padrão como float
        public int? Size => null;
    }
}

