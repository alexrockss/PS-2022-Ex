using System;
using System.Collections.Generic;

namespace UserLogin
{
    public static class UserData
    {
        private static List<User> testUser;

        public static List<User> TestUser
        {
            get
            {
                ResetTestUserData();
                return testUser;
            }
            set { }
        }

        private static void ResetTestUserData()
        {
            if (testUser != null) return;

            testUser = new List<User>();
            testUser.Add(new User("alexandra", "121219092", "", UserRoles.ADMIN, new DateTime(2022, 1, 1)));
            testUser.Add(new User("alex123", "121219093", "", UserRoles.ADMIN, new DateTime(2022, 2, 2)));
            testUser.Add(new User("123alex", "121219093", "121219093", UserRoles.STUDENT, new DateTime(2022, 3, 3)));
        }

        public static void GetUsers()
        {
            foreach (var user in testUser)
            {
                Console.WriteLine(user.ToString());
            }
        }

        public static User IsUserPassCorrect(string username, string password)
        {
            foreach (var user in TestUser)
            {
                if (user.username == username && user.password == password)
                    return user;
            }

            return null;
        }

        public static void SetUserActiveTo(string username, DateTime activity)
        {
            foreach (var user in TestUser)
            {
                if (user.username == username)
                {
                    user.Created = activity;
                    Logger.LogActivity("Role changed for " + username);
                }
            }
        }

        public static void AssignUserRole(string username, UserRoles newRole)
        {
            foreach (var user in TestUser)
            {
                if (user.username == username)
                {
                    user.userRole = newRole;
                    Logger.LogActivity("Activity changed for " + username);
                }
            }
        }
    }
}