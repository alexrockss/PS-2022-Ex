namespace UserLogin
{
    public class LoginValidation
    {
        private string username;
        private string password;
        private string errorMessage;
        private ActionOnError errorAction;

        public delegate void ActionOnError(string errorMsg);

        public static UserRoles currentUserRole { get; private set; }

        public LoginValidation(string username, string password, ActionOnError errorAction)
        {
            this.username = username;
            this.password = password;
            this.errorAction = errorAction;
        }
        
        public bool ValidateUserInput(ref User user) 
        {
            bool emptyUserName;
            emptyUserName = username.Equals(string.Empty);

            if (emptyUserName)
            {
                errorMessage = "Не е посочено потребителско име";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            bool emptyPassword;
            emptyPassword = password.Equals(string.Empty);

            if (emptyPassword)
            {
                errorMessage = "Не е посочена парола";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (username.Length < 5)
            {
                errorMessage = "Потребителското име трябва да бъде поне 5 символа";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            if (password.Length < 5)
            {
                errorMessage = "Паролата трябва да бъде поне 5 символа";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            user = UserData.IsUserPassCorrect(username, password);

            if (user == null)
            {
                errorMessage = "Потребителят не беше намерен";
                errorAction(errorMessage);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            currentUserRole = (UserRoles)user.Role;
            Logger.LogActivity("Успешен Login");
            return true;
        }
    }
}
