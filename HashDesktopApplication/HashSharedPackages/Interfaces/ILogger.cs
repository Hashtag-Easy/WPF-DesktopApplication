
namespace HashSharedPackages.Interfaces
{
    public interface ILogger
    {
        public void Save(string message);
        public void GetAll();
        public void Clear();
    }
}
