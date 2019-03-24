using System.Collections.Generic;

namespace Unibox
{
    public struct AppStates
    {
        public User currentUser;
        public List<User> users;
        public List<Group> groups;

        public User User
        {
            get => default(User);
            set
            {
            }
        }

        public Group Group
        {
            get => default(Group);
            set
            {
            }
        }
    }
}
