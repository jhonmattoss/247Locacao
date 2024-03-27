// Caminho: Projeto247Locacao\247Locacao.Domain\Interfaces\IBaseType.cs

using System;

namespace Projeto247Locacao.Domain.Interfaces
{
    /// <summary>
    /// Interface para definir um tipo base.
    /// </summary>
    public interface IBaseType
    {
        /// <summary>
        /// Obtém o tipo do objeto.
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Obtém o tamanho do objeto.
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Obtém a descrição do objeto.
        /// </summary>
        string Description { get; }
    }
}
