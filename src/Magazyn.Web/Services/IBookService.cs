using Magazyn.Web.Models;

namespace Magazyn.Web.Services;

public interface IBookService
{
    IEnumerable<Ksiazka> GetAll();
    Ksiazka? GetById(int id);
    void Add(Ksiazka ksiazka);
    void Update(Ksiazka ksiazka);
    void Delete(int id);
}
