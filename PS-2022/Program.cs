using System;
using System.Collections.Generic;
using System.Text;
using UserLogin;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Enter username: ");
string? username = Console.ReadLine();

Console.Write("Enter password: ");
string? password = Console.ReadLine();

LoginValidation validation = new LoginValidation(username, password, ActionOnError);

User? user = null;

if (validation.ValidateUserInput(ref user))
{
    Console.WriteLine(user.username);
    Console.WriteLine(user.Password);
    Console.WriteLine(user.facultyNumber);
    Console.WriteLine((UserRoles)user.Role);
    Console.WriteLine(user.Created);

    switch (user.Role)
    {
        case 0:
            Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
            break;
        case 1:
            Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
            Console.WriteLine();

            ShowAdminMenu();
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Приятен ден!");

                    return;
                case 1:

                    Console.Write("Въведете потребителско име: ");
                    string usernameForRole = Console.ReadLine();

                    Console.Write("Въведете новата роля (число): ");
                    UserRoles newRole = (UserRoles)int.Parse(Console.ReadLine());

                    UserData.AssignUserRole(usernameForRole, newRole);

                    break;
                case 2:

                    Console.Write("Въведете потребителско име: ");
                    string usernameForStatus = Console.ReadLine();

                    Console.Write("Въведете новата дата: ");
                    DateTime resultDateTime;

                    DateTime.TryParse(Console.ReadLine(), out resultDateTime);

                    UserData.SetUserActiveTo(usernameForStatus, resultDateTime);

                    break;
                case 3:
                    break;
                case 4:

                    StringBuilder logStringBuilder = new StringBuilder();
                    IEnumerable<string> allActs = Logger.GetAllActivities();

                    foreach (string act in allActs)
                    {
                        logStringBuilder.AppendLine(act);
                    }

                    Console.WriteLine(logStringBuilder.ToString());

                    break;
                case 5:

                    StringBuilder sb = new StringBuilder();
                    string filter = "user";
                    IEnumerable<string> currentActs = Logger.GetCurrentSessionActivities(filter);

                    foreach (string line in currentActs)
                    {
                        sb.Append(line);
                    }

                    Console.WriteLine(sb.ToString());

                    break;
                default:
                    break;
            }
            break;
        case 2:
            Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
            break;
        case 3:
            Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
            break;
        case 4:
            Console.WriteLine($"Welcome, {(UserRoles)user.Role}");
            break;
        default:
            Console.WriteLine("Error");
            break;
    }
}

void ActionOnError(string errorMessage)
{
    Console.WriteLine($"{errorMessage}!");
}

void ShowAdminMenu()
{
    Console.WriteLine("Изберете опция:");
    Console.WriteLine("1: Промяна на роля на потребител");
    Console.WriteLine("2: Промяна на активност на потребител");
    Console.WriteLine("3: Списък на потребителите");
    Console.WriteLine("4: Преглед на лог на активност");
    Console.WriteLine("5: Преглед на текущата активност");
}