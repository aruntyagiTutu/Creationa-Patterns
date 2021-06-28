using Singleton_Base;
using ThreadSafe_Singleton;

namespace DIUsage_Singleton
{
    class ClientWithoutDI
    {
        // this is tight coupling, avoid this
        Database db = Database.Instance();

        public void SomeWork()
        {
            var data = db.GetData();

            // other work...
        }
    }


    class ClientWithDI
    {
        IDatabase db;
        public ClientWithDI(IDatabase database)
        {
            db = database;
        }


        public void SomeWork()
        {
            var data = db.GetData();

            // other work...
        }
    }

}