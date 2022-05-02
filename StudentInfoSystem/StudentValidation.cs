using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            if (String.IsNullOrEmpty(user.facultyNumber))
            {
                Logger.LogActivity("User " + user.username + " has no faculty number.");
                throw new ArgumentException("User " + user.username + " has no faculty number.");
            }

            User foundUser = UserData.FindUserByFacultyNumber(user.facultyNumber);
            if (foundUser == null)
            {
                Logger.LogActivity("User " + user.username + " with faculty number: " + user.facultyNumber + " doesn't exist.");
                throw new ArgumentException("User " + user.username + " with faculty number: " + user.facultyNumber + " doesn't exist.");
            }

            return null;
        }
    }
}