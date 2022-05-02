using System;

namespace UserLogin
{
    public class User
    {
        public string username;
        public string password;
        public string facultyNumber;
        public UserRoles userRole;
        public DateTime Created;

        public User()
        {

        }

        public User(string username, string password, string facultyNumber, UserRoles userRole, DateTime created)
        {
            this.username = username;
            this.password = password;
            this.facultyNumber = facultyNumber;
            this.userRole = userRole;
            this.Created = created;
        }

        public override string ToString()
        {
            return username + " " + facultyNumber + " " + userRole + " " + Created;
        }
    }
}