using habilitations2024.model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace habilitations2024.dal
{
    /// <summary>
    /// Accès aux données pour la table developpeur
    /// </summary>
    public class DeveloppeurAccess : Access
    {
        /// <summary>
        /// Récupère tous les développeurs avec leur profil
        /// </summary>
        public List<Developpeur> GetAllDeveloppeurs()
        {
            List<Developpeur> developpeurs = new List<Developpeur>();
            string query = @"SELECT d.iddeveloppeur, d.nom, d.prenom, d.tel, d.mail, d.pwd,
                                    p.idprofil, p.libelle
                             FROM developpeur d
                             JOIN profil p ON d.idprofil = p.idprofil
                             ORDER BY d.nom, d.prenom;";
            List<Dictionary<string, object>> records = bddManager.ReqSelect(query);
            foreach (Dictionary<string, object> record in records)
            {
                Profil profil = new Profil((int)record["idprofil"], record["libelle"].ToString());
                Developpeur dev = new Developpeur(
                    (int)record["iddeveloppeur"],
                    record["nom"].ToString(),
                    record["prenom"].ToString(),
                    record["tel"].ToString(),
                    record["mail"].ToString(),
                    record["pwd"].ToString(),
                    profil
                );
                developpeurs.Add(dev);
            }
            return developpeurs;
        }

        /// <summary>
        /// Ajoute un développeur (pwd = nom par défaut)
        /// </summary>
        public void AddDeveloppeur(Developpeur developpeur)
        {
            string query = "INSERT INTO developpeur (nom, prenom, tel, mail, pwd, idprofil) VALUES (@nom, @prenom, @tel, @mail, @pwd, @idprofil);";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom",       developpeur.Nom },
                { "@prenom",    developpeur.Prenom },
                { "@tel",       developpeur.Tel },
                { "@mail",      developpeur.Mail },
                { "@pwd",       developpeur.Nom },   // pwd par défaut = nom
                { "@idprofil",  developpeur.LeProfil.IdProfil }
            };
            bddManager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Modifie un développeur
        /// </summary>
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            string query = "UPDATE developpeur SET nom=@nom, prenom=@prenom, tel=@tel, mail=@mail, idprofil=@idprofil WHERE iddeveloppeur=@id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@nom",       developpeur.Nom },
                { "@prenom",    developpeur.Prenom },
                { "@tel",       developpeur.Tel },
                { "@mail",      developpeur.Mail },
                { "@idprofil",  developpeur.LeProfil.IdProfil },
                { "@id",        developpeur.IdDeveloppeur }
            };
            bddManager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Supprime un développeur
        /// </summary>
        public void DeleteDeveloppeur(int idDeveloppeur)
        {
            string query = "DELETE FROM developpeur WHERE iddeveloppeur=@id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@id", idDeveloppeur }
            };
            bddManager.ReqUpdate(query, parameters);
        }

        /// <summary>
        /// Modifie le mot de passe d'un développeur
        /// </summary>
        public void UpdatePwd(int idDeveloppeur, string nouveauPwd)
        {
            string query = "UPDATE developpeur SET pwd=@pwd WHERE iddeveloppeur=@id;";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@pwd", nouveauPwd },
                { "@id",  idDeveloppeur }
            };
            bddManager.ReqUpdate(query, parameters);
        }
    }
}
