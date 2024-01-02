using application.repositories;

namespace application.usecases
{
    public class ListUser
    {
        private readonly IUserRepository userRepository;
        public ListUser(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        public string execute()
        {
            return userRepository.get();
        }
    }
}