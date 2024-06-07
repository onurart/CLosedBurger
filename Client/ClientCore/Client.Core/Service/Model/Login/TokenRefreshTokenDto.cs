namespace Client.Core.Service.Model.Login
{
    public class TokenRefreshTokenDto
    {
        public Data data { get; set; }
        public object[] errorMessages { get; set; }
        public bool isSuccessful { get; set; }
        //public TokenModel Token { get; set; }
        //public string Email { get; set; }
        //public string UserId { get; set; }
        //public string NameLastName { get; set; }
        //public string MainRole { get; set; }


    }
    public class Data
    {
        public Token token { get; set; }
        public string email { get; set; }
        public string userId { get; set; }
        public string nameLastName { get; set; }
        public string mainRole { get; set; }
    }

    public class Token
    {
        public string token { get; set; }
        public string refreshToken { get; set; }
        public DateTime refreshTokenExpires { get; set; }
    }
}
