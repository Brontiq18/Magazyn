using Magazyn.Web.Models;

namespace Magazyn.Web.Services;

public class BookService : IBookService
{
    public IEnumerable<Ksiazka> GetAll()
    {
        return Enumerable.Empty<Ksiazka>();
    }

    public Ksiazka? GetById(int id)
    {
        return null;
    }

    public void Add(Ksiazka ksiazka)
    {
    }

    public void Update(Ksiazka ksiazka)
    {
    }

    public void Delete(int id)
    {
    }
}
