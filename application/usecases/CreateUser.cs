using application.repositories;

namespace application.usecases
{
    public class CreateUser
    {
        private readonly IUserRepository userRepository;
        public CreateUser(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public string execute(string name)
        {
            return name;
        }
    }
}