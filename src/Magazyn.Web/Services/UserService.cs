using Magazyn.Web.Models;

namespace Magazyn.Web.Services;

public class UserService : IUserService
{
    public IEnumerable<Uzytkownik> GetAll()
    {
        return Enumerable.Empty<Uzytkownik>();
    }

    public Uzytkownik? GetById(int id)
    {
        return null;
    }

    public void Add(Uzytkownik uzytkownik)
    {
    }

    public void Update(Uzytkownik uzytkownik)
    {
    }

    public void Delete(int id)
    {
    }
}
