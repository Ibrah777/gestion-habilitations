using habilitations2024.bddmanager;
using System.Configuration;

namespace habilitations2024.dal
{
    /// <summary>
    /// Classe mère des classes DAL — fournit l'accès au BddManager
    /// </summary>
    public class Access
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["habilitations"].ConnectionString;
        protected readonly BddManager bddManager = BddManager.GetInstance(connectionString);
    }
}
