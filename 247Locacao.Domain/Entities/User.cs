using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _247Locacao.Domain.Entities
{
    /// <summary>
    /// Represents a user in the 247Locacao system.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the username for the user.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the email for the user.
        /// </summary>
        public string Email { get; set; }

        // Inclua outros campos com descrições semelhantes
    }
}
