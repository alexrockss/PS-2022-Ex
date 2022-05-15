using System;
using System.Collections.Generic;
using System.Linq;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> _testusers;
        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return _testusers;
            }
            set
            {

            }
        }

        public static User? IsUserPassCorrect(string username, string password)
        {
            UserContext context = new UserContext();

            return context.Users.FirstOrDefault(u => u.username == username && u.Password == password);
        }

        public static void SetUserActiveTo(string username, DateTime newExpireDate)
        {
            UserContext context = new UserContext();

            User? user = context.Users.FirstOrDefault(u => u.username == username);

            if (user != null)
            {
                user.AccountExpireDate = newExpireDate;
                Logger.LogActivity("Промяна на активност на " + username);
            }
        }

        public static void AssignUserRole(string username, UserRoles role)
        {
            UserContext context = new UserContext();

            User? user = context.Users.FirstOrDefault(u => u.username == username);

            if (user != null)
            {
                user.Role = (int)role;
            }

            context.SaveChanges();
        }

        private static void ResetTestUserData()
        {
            if (_testusers == null)
            {
                _testusers = new List<User>();

                for (int i = 0; i < 3; i++)
                {
                    if (i == 0)
                    {
                        _testusers.Add(new User()
                        {
                            username = "usertest1",
                            Role = 4,
                            Created = DateTime.Now,
                            AccountExpireDate = DateTime.MaxValue,
                            facultyNumber = "12345",
                            Password = "00000"
                        });
                    }

                    if (i == 1)
                    {
                        _testusers.Add(new User()
                        {
                            username = "useradmin",
                            Role = 1,
                            Created = DateTime.Now,
                            AccountExpireDate = DateTime.MaxValue,
                            facultyNumber = "12345",
                            Password = "00000"
                        });
                    }

                    if (i == 2)
                    {
                        _testusers.Add(new User()
                        {
                            username = "usertest2",
                            Role = 4,
                            Created = DateTime.Now,
                            AccountExpireDate = DateTime.MaxValue,
                            facultyNumber = "12345",
                            Password = "00000"
                        });
                    }
                }
            }
        }
    }
}