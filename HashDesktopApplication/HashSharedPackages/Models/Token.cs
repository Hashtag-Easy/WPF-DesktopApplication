
namespace HashSharedPackages.Models
{
    public class Token
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }

        public Token()
        {
            AccessToken = string.Empty;
            RefreshToken = string.Empty;
        }
    }
}
