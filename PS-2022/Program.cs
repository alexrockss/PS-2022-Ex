using System;
using System.IO;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username...");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password...");
            string password = Console.ReadLine();

            User user = new User();
            
            if (new LoginValidation(username, password, Messages).ValidateUserInput(user))
            {
                Console.WriteLine(user.username);
                Console.WriteLine(user.facultyNumber);

                switch (LoginValidation.CurrentUserRole)
                {
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("Anonymous user...");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("Administrator...");
                        break;
                    case UserRoles.INSPECTOR:
                        Console.WriteLine("Inspector...");
                        break;
                    case UserRoles.PROFESSOR:
                        Console.WriteLine("Professor...");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("Student...");
                        break;
                }

                Menu();
            }
        }

        public static void Menu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Choose option:");
                Console.WriteLine("0: Exit");
                Console.WriteLine("1: Change role of user");
                Console.WriteLine("2: Change activity of user");
                Console.WriteLine("3: List of users");
                Console.WriteLine("4: View log file");
                Console.WriteLine("5: View current activity");
                Console.WriteLine();

                string option = Console.ReadLine();
                int opt = -1;
                int.TryParse(option, out opt);

                if (opt == 0 || opt == -1)
                {
                    break;
                }
                else if (opt == 1)
                {
                    Console.WriteLine("Enter username");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter role: A->Admin, P->Professor, S-<Student, I->Inspector");
                    string role = Console.ReadLine();
                    UserRoles uRole = UserRoles.ANONYMOUS;
                    switch (role)
                    {
                        case "A":
                            uRole = UserRoles.ADMIN;
                            break;
                        case "P":
                            uRole = UserRoles.PROFESSOR;
                            break;
                        case "S":
                            uRole = UserRoles.STUDENT;
                            break;
                        case "I":
                            uRole = UserRoles.INSPECTOR;
                            break;
                    }
                    UserData.AssignUserRole(name, uRole);
                }
                else if (opt == 2)
                {
                    Console.WriteLine("Enter username");
                    string name = Console.ReadLine();
                    int year, month, day;
                    Console.WriteLine("Enter year");
                    year = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter month");
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter day");
                    day = int.Parse(Console.ReadLine());
                    UserData.SetUserActiveTo(name, new DateTime(year, month, day));
                }
                else if (opt == 3)
                {
                    UserData.GetUsers();
                }
                else if (opt == 4)
                {
                    if (File.Exists("test.txt"))
                        Console.WriteLine(File.ReadAllText("test.txt"));
                }
                else if (opt == 5)
                {
                    Console.WriteLine(Logger.GetCurrentSessionActivities());
                }
            }
        }

        public static void Messages(string message)
        {
            Console.WriteLine(message);
        }
    }
}
