using System;

namespace habilitations2024.model
{
    public class Developpeur
    {
        public int IdDeveloppeur { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string Pwd { get; set; }
        public Profil LeProfil { get; set; }

        public Developpeur() { }

        public Developpeur(int idDeveloppeur, string nom, string prenom, string tel, string mail, string pwd, Profil leProfil)
        {
            IdDeveloppeur = idDeveloppeur;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Mail = mail;
            Pwd = pwd;
            LeProfil = leProfil;
        }

        public override string ToString()
        {
            return Nom + " " + Prenom;
        }
    }
}
