
namespace HashSharedPackages.Interfaces
{
    public interface IToken
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
