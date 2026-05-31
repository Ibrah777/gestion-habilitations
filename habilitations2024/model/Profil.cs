using System;

namespace habilitations2024.model
{
    public class Profil
    {
        public int IdProfil { get; set; }
        public string LibelleProfil { get; set; }

        public Profil() { }

        public Profil(int idProfil, string libelleProfil)
        {
            IdProfil = idProfil;
            LibelleProfil = libelleProfil;
        }

        public override string ToString()
        {
            return LibelleProfil;
        }
    }
}
