using habilitations2024.model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace habilitations2024.dal
{
    /// <summary>
    /// Accès aux données pour la table profil
    /// </summary>
    public class ProfilAccess : Access
    {
        /// <summary>
        /// Récupère tous les profils
        /// </summary>
        public List<Profil> GetAllProfils()
        {
            List<Profil> profils = new List<Profil>();
            string query = "SELECT idprofil, libelle FROM profil ORDER BY libelle;";
            List<Dictionary<string, object>> records = bddManager.ReqSelect(query);
            foreach (Dictionary<string, object> record in records)
            {
                Profil profil = new Profil(
                    (int)record["idprofil"],
                    record["libelle"].ToString()
                );
                profils.Add(profil);
            }
            return profils;
        }
    }
}
