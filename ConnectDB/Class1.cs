using System;

namespace ConnectDB
{
    internal class Con_zadanie4
    {
        public static string C()
        {
            const string host = "caseum.ru";
            const int port = 33333;
            const string user = "test_user";
            const string db = "db_test";
            const string pass = "test_pass";
            string connStr = $"server={host};port={port};user={user};" +
            $"database={db};password={pass};";
            return connStr;
        }
    }
}
