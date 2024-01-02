using application.repositories;

namespace infra.database.entityFramework.repositories
{
    public class UserRepository : IUserRepository
    {
        public string create()
        {
            return "teste 123";
        }

        public string get()
        {
            return "teste 456";
        }
    }
}