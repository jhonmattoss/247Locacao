using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _247Locacao.Domain.Exceptions
{
    /// <summary>
    /// Exceção específica do domínio que representa erros que ocorrem dentro da lógica de negócio.
    /// </summary>
    public class DomainException : Exception
    {
        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="DomainException"/> sem mensagem de erro.
        /// </summary>
        public DomainException()
        {
        }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="DomainException"/> com uma mensagem de erro específica.
        /// </summary>
        /// <param name="message">A mensagem que descreve o erro.</param>
        public DomainException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="DomainException"/> com uma mensagem de erro específica e uma referência à exceção interna que é a causa desta exceção.
        /// </summary>
        /// <param name="message">A mensagem de erro que explica o motivo da exceção.</param>
        /// <param name="inner">A exceção que é a causa da exceção atual, ou uma referência nula (Nothing em Visual Basic) se nenhuma causa interna for especificada.</param>
        public DomainException(string message, Exception inner)
            : base(message, inner)
        {
        }

        // Aqui você pode adicionar qualquer lógica adicional específica ao domínio ou propriedades adicionais conforme necessário.
    }
}
