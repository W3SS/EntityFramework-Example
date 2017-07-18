using System.Configuration;
using EfTUtorial.Utils.Contracts;

namespace EfTUtorial.Utils
{
    public class Configuration : IConfiguration
    {
        private string _databaseConnection;
        private bool _initialized;
        private readonly object _lockObject = new object();

        private void Load()
        {
            if (_initialized) return;

            lock (_lockObject)
            {
                if (_initialized) return;

                _initialized = true;
                _databaseConnection = ConfigurationManager.AppSettings["db"];
            }
        }

        public string DatabaseConnection
        {
            get
            {
                Load();
                return _databaseConnection;
            }
        }
    }
}