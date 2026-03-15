using Magazyn.Web.Models;

namespace Magazyn.Web.Services;

public interface IUserService
{
    IEnumerable<Uzytkownik> GetAll();
    Uzytkownik? GetById(int id);
    void Add(Uzytkownik uzytkownik);
    void Update(Uzytkownik uzytkownik);
    void Delete(int id);
}
