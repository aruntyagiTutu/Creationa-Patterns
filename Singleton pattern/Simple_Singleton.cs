namespace Simple_Singleton
{

    class Database 
    {
        // private constructor 
        private Database()
        {

        }
        public static Database Instance()
        {
            if(_Instance == null)
            {
                _Instance = new Database();
            }

            return _Instance;
        }

        private static Database _Instance;


        public object GetData()
        {
            return null;
        }
        // other useful methods...
        
    }
}