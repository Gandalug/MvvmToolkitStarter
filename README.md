# MvvmToolkitStarter
====================

Dieses Projekt zeigt ein sauberes MVVM-Setup für WPF-Anwendungen mit dem CommunityToolkit.Mvvm.

Ziel ist es, eine erweiterbare und wartbare Architektur für moderne .NET-Desktopanwendungen zu schaffen, mit Fokus auf:

- Klare Trennung von View, ViewModel und Model
- Navigation über ViewModels
- Dependency Injection
- Services für testbare Geschäftslogik

VERZEICHNISSTRUKTUR
--------------------

/Views           -> WPF Views (XAML)
/ViewModels      -> ViewModel-Logik (mit ObservableObject, RelayCommand, etc.)
/Services        -> Interfaces und Implementierungen von Services

App.xaml         -> Application Entry Point
App.xaml.cs      -> Registrierung von Services & Start-ViewModel


MVVM MIT COMMUNITY TOOLKIT
---------------------------

Das Projekt nutzt `CommunityToolkit.Mvvm`, um Boilerplate zu reduzieren:

- [ObservableProperty] für automatische PropertyChanged-Logik
- [RelayCommand] für einfache Commands
- Dependency Injection direkt via App.xaml.cs oder IServiceProvider
- Messenger-Pattern bei Bedarf leicht integrierbar

ZIELGRUPPE
----------

Für Entwickler:innen, die ein leichtgewichtiges, aber professionelles MVVM-Grundgerüst benötigen,
um damit ihre eigene WPF-App aufzubauen oder zu lernen, wie moderne WPF-Architektur funktioniert.

AUTOR
-----

Gandalug – https://github.com/Gandalug
