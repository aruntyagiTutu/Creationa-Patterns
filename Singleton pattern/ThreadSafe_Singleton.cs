namespace ThreadSafe_Singleton
{
    class Database
    {

        private static readonly object s_lock = new object();
        // private constructor 
        private Database()
        {

        }
        public static Database Instance()
        {
            lock (s_lock)
            {
                if (_Instance == null)
                {
                    _Instance = new Database();
                }

                return _Instance;
            }
        }

        private static Database _Instance;


        public object GetData()
        {
            return null;
        }
        // other useful methods...

    }
}