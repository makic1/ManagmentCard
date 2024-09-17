namespace WineCardVersionFive.Service
{
    public class AuthService
    {
        /// <summary>
        /// singleton Authservice
        /// </summary>
        public static AuthService _instance;

        public static AuthService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AuthService();
                }
                return _instance;
            }
        }

        private AuthService()
        {
            
        }

        public bool IsAuthenticated { get; set; } = false;
        public string Username { get; set; }

        public void Login(string username)
        {
            Username = username;
            IsAuthenticated = true;
        }

        public void Logout()
        {
            IsAuthenticated = false;
            Username = string.Empty;
        }
    }
}
