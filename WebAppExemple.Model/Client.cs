using System;
using System.Collections.Generic;
using System.Text;

namespace WebAppExemple.Model
{
    public class Client
    {
        /// <summary>
        /// Identifiant technique
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nom de famille
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Société
        /// </summary>
        public string Profession { get; set; }
    }
}
