// Pasta: Domain/Entities
// Subpasta: DicionarioDeDados
// Nome do arquivo: EntidadeBase.cs

using System;

namespace _247Locacao.Domain.Entities.DicionarioDeDados
{
    /// <summary>
    /// Classe base para entidades do dicionário de dados.
    /// </summary>
    public abstract class EntidadeBase
    {
        /// <summary>
        /// Prefixo de três dígitos que identifica unicamente a entidade.
        /// </summary>
        public string Prefixo { get; protected set; }

        /// <summary>
        /// Nome da entidade.
        /// </summary>
        public string NomeEntidade { get; protected set; }

        /// <summary>
        /// Descrição da entidade, explicando sua utilização e importância.
        /// </summary>
        public string DescricaoEntidade { get; protected set; }

        /// <summary>
        /// Mapa da entidade, pode ser Admin, Negócios ou ZFM.
        /// </summary>
        public string Mapa { get; protected set; }

        /// <summary>
        /// Grupo ao qual a entidade pertence: Tabelas Base, Admin ou Negócios.
        /// </summary>
        public string GrupoEntidade { get; protected set; }

        protected EntidadeBase(string prefixo, string nomeEntidade, string descricaoEntidade, string mapa, string grupoEntidade)
        {
            if (string.IsNullOrWhiteSpace(prefixo) || prefixo.Length != 3)
                throw new ArgumentException("O prefixo deve conter exatamente três dígitos.", nameof(prefixo));

            Prefixo = prefixo;
            NomeEntidade = nomeEntidade ?? throw new ArgumentNullException(nameof(nomeEntidade));
            DescricaoEntidade = descricaoEntidade ?? throw new ArgumentNullException(nameof(descricaoEntidade));
            Mapa = mapa ?? throw new ArgumentNullException(nameof(mapa));
            GrupoEntidade = grupoEntidade ?? throw new ArgumentNullException(nameof(grupoEntidade));
        }
    }
}