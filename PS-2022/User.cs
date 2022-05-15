namespace UserLogin
{
    public class User
    {
        public int UserId { get; set; }

        public string username { get; set; }

        public string Password { get; set; }

        public string facultyNumber { get; set; }

        public int Role { get; set; }

        public System.DateTime Created { get; set; }

        public System.DateTime? AccountExpireDate { get; set; }
    }
}