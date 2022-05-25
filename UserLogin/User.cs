namespace UserLogin
{
    public class User
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string FakNum { get; set; }

        public int Role { get; set; }

        public DateTime Created { get; set; }

        public DateTime? AccountExpireDate { get; set; }
    }
}
