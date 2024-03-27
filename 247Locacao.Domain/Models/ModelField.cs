// Caminho: Projeto247Locacao\247Locacao.Domain\Models\ModelField.cs

using Projeto247Locacao.Domain.Interfaces;

namespace Projeto247Locacao.Domain.Models
{
    /// <summary>
    /// Classe genérica para representar um campo de modelo no sistema.
    /// </summary>
    /// <typeparam name="T">O tipo de dado do campo, que deve implementar IBaseType.</typeparam>
    public class ModelField<T> where T : IBaseType
    {
        /// <summary>
        /// Obtém o tipo de dados do campo.
        /// </summary>
        public T DataType { get; }

        /// <summary>
        /// Obtém ou define o valor padrão do campo.
        /// </summary>
        public string DefaultValue { get; set; }

        /// <summary>
        /// Obtém ou define se o campo é somente leitura.
        /// </summary>
        public bool IsReadOnly { get; set; }

        /// <summary>
        /// Obtém ou define a máscara de entrada de dados do campo.
        /// </summary>
        public string Mask { get; set; }

        /// <summary>
        /// Obtém ou define o rótulo do campo.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Obtém ou define a descrição do campo.
        /// </summary>
        public string FieldDescription { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe ModelField com parâmetros específicos.
        /// </summary>
        /// <param name="dataType">O tipo de dados do campo.</param>
        /// <param name="defaultValue">O valor padrão do campo.</param>
        /// <param name="isReadOnly">Indica se o campo é somente leitura.</param>
        /// <param name="mask">A máscara de entrada de dados do campo.</param>
        /// <param name="label">O rótulo do campo.</param>
        /// <param name="description">A descrição do campo.</param>
        public ModelField(T dataType, string defaultValue, bool isReadOnly, string mask, string label, string description)
        {
            DataType = dataType;
            DefaultValue = defaultValue;
            IsReadOnly = isReadOnly;
            Mask = mask;
            Label = label;
            FieldDescription = description;
        }
    }
}
