using habilitations2024.dal;
using habilitations2024.model;
using System.Collections.Generic;

namespace habilitations2024.controller
{
    /// <summary>
    /// Contrôleur de la fenêtre principale FrmHabilitations
    /// </summary>
    public class FrmHabilitationsController
    {
        private readonly DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();
        private readonly ProfilAccess profilAccess = new ProfilAccess();

        /// <summary>
        /// Retourne la liste de tous les développeurs
        /// </summary>
        public List<Developpeur> GetAllDeveloppeurs()
        {
            return developpeurAccess.GetAllDeveloppeurs();
        }

        /// <summary>
        /// Retourne la liste de tous les profils
        /// </summary>
        public List<Profil> GetAllProfils()
        {
            return profilAccess.GetAllProfils();
        }

        /// <summary>
        /// Ajoute un développeur (pwd initialisé avec le nom)
        /// </summary>
        public void AddDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.AddDeveloppeur(developpeur);
        }

        /// <summary>
        /// Modifie un développeur
        /// </summary>
        public void UpdateDeveloppeur(Developpeur developpeur)
        {
            developpeurAccess.UpdateDeveloppeur(developpeur);
        }

        /// <summary>
        /// Supprime un développeur
        /// </summary>
        public void DeleteDeveloppeur(int idDeveloppeur)
        {
            developpeurAccess.DeleteDeveloppeur(idDeveloppeur);
        }

        /// <summary>
        /// Modifie le mot de passe d'un développeur
        /// </summary>
        public void UpdatePwd(int idDeveloppeur, string nouveauPwd)
        {
            developpeurAccess.UpdatePwd(idDeveloppeur, nouveauPwd);
        }
    }
}
