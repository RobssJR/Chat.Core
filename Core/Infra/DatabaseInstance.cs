using LiteDB;

namespace Database.Infra
{
    public sealed class DatabaseInstance
    {
        private static DatabaseInstance _instance;
        private const string PATH = @"C:\Db\MyData.db";
        public LiteDatabase database;

        private DatabaseInstance() 
        {
            database = new LiteDatabase(PATH);
        }

        public static DatabaseInstance GetInstance()
        {
            if (_instance == null)
                _instance = new DatabaseInstance();

            return _instance;
        }
    }
}
