# MVVM Toolkit Starter

Dieses Projekt demonstriert ein modernes MVVM-Setup für WPF-Anwendungen unter Verwendung von [CommunityToolkit.Mvvm](https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/).  
Es richtet sich an Entwickler:innen, die strukturierte, testbare und erweiterbare Desktop-Anwendungen mit .NET erstellen möchten.

---

## 🔧 Technologien & Frameworks

- [.NET 6+](https://dotnet.microsoft.com/)
- WPF (Windows Presentation Foundation)
- [CommunityToolkit.Mvvm](https://www.nuget.org/packages/CommunityToolkit.Mvvm)
- Dependency Injection (`IServiceProvider`)
- ViewModel-basierte Navigation

---

## 📁 Projektstruktur
- 📁 Views
  - 📄 UI-Komponenten (XAML)
- 📁ViewModels
  - 📄 Logikschicht (MVVM-Logik)
- 📁Services
  - 📄 Abstraktion & Businesslogik
📄 App.xaml.cs   (Einstiegspunkt & Konfiguration)
  
---

## 🧠 MVVM mit CommunityToolkit

**MVVM (Model-View-ViewModel)** ist ein Entwurfsmuster, das UI und Geschäftslogik sauber trennt.  
Dieses Projekt nutzt das Toolkit zur Reduktion von Boilerplate-Code:

- `[ObservableProperty]` für automatische `INotifyPropertyChanged`-Implementierung
- `[RelayCommand]` für einfache Commands ohne eigene Klassen
- Unterstützung für DI & Navigation durch einfache Muster

### Vorteile des MVVM-Patterns

✅ Testbarkeit durch Trennung von Logik und UI  
✅ Wiederverwendbare Komponenten  
✅ Gute Wartbarkeit & Erweiterbarkeit  
✅ Klare Zuständigkeiten (Single Responsibility Principle)

---

## 🚀 Einstieg

1. Repository klonen
2. Mit Visual Studio öffnen
3. Build ausführen und starten

> Alle Services und ViewModels sind im `App.xaml.cs` registriert.

---

## 🧪 Beispiel

Im Projekt ist eine einfache Navigation zwischen MainView und SecondaryView enthalten.  
Navigation erfolgt über das `INavigationService`, das die ViewModels verwaltet.

---

## 🧑‍💻 Autor

**Gandalug** – [github.com/Gandalug](https://github.com/Gandalug)  
_Made with ❤️ for clean architecture._
