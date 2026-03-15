# Magazyn

Aplikacja webowa ASP.NET Core MVC do zarządzania magazynem.

## Struktura projektu

```
Magazyn/
├── Magazyn.sln
├── Directory.Build.props
├── .gitignore
├── README.md
└── src/
    └── Magazyn.Web/          # Projekt ASP.NET Core MVC
        ├── Controllers/       # Kontrolery MVC
        │   ├── HomeController.cs
        │   ├── AccountController.cs
        │   ├── UzytkownicyController.cs
        │   └── KsiazkirController.cs
        ├── Models/            # Modele danych
        │   ├── Uzytkownik.cs
        │   └── Ksiazka.cs
        ├── Services/          # Warstwa logiki biznesowej
        │   ├── IUserService.cs
        │   ├── UserService.cs
        │   ├── IBookService.cs
        │   └── BookService.cs
        ├── Views/             # Widoki Razor
        │   ├── Home/
        │   ├── Account/
        │   ├── Uzytkownicy/
        │   ├── Ksiazki/
        │   └── Shared/
        ├── wwwroot/           # Zasoby statyczne (CSS, JS, obrazy)
        ├── appsettings.json
        ├── appsettings.Development.json
        └── Program.cs
```

## Wymagania

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Uruchamianie projektu

```bash
# Przywróć zależności
dotnet restore

# Zbuduj projekt
dotnet build

# Uruchom aplikację
dotnet run --project src/Magazyn.Web
```

Aplikacja będzie dostępna pod adresem `https://localhost:5001` (lub `http://localhost:5000`).

## Architektura

Projekt oparty jest na architekturze trójwarstwowej:

- **Warstwa prezentacji** (`Controllers` + `Views`) – obsługa żądań HTTP i renderowanie widoków Razor
- **Warstwa logiki biznesowej** (`Services`) – interfejsy i implementacje logiki aplikacji
- **Warstwa danych** (`Models`) – modele encji danych

## Moduły

| Moduł          | Ścieżka                          | Opis                        |
|----------------|----------------------------------|-----------------------------|
| Strona główna  | `/`                              | Strona startowa aplikacji   |
| Konto          | `/Account`                       | Zarządzanie kontem          |
| Użytkownicy    | `/Uzytkownicy`                   | Zarządzanie użytkownikami   |
| Książki        | `/Ksiazki`                       | Zarządzanie książkami       |
