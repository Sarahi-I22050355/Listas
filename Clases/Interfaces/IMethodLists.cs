
namespace Listas.Clases.Interfaces
{
    public interface IMethodLists
    {
        void Add(int data);
        void Delete(int data);
        void Search(int data);
        void Show();
        bool IsEmpty();
        void Clear();
    }
}
