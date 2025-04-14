# 🧰 MVVM Toolkit Starter Template

Ein schlankes WPF-Starterprojekt mit MVVM-Pattern (CommunityToolkit), Dependency Injection und Navigation – ideal für moderne .NET Desktop-Anwendungen.

---

## 🚀 Projektvorlage installieren (`dotnet new` Template)

Diese Vorlage erlaubt es dir, mit einem einzigen Befehl eine WPF-App mit MVVM, DI und Navigation zu erstellen.

---

### 📦 1. Vorlage herunterladen und entpacken

Lade [diese ZIP-Datei](./MvvmToolkitStarterTemplate.zip) herunter und entpacke sie z. B. nach:

```
C:\Templates\MvvmToolkitStarterTemplate
```

> Die entpackte Vorlage muss den Ordner `.template.config` enthalten.

---

### 🛠️ 2. Vorlage lokal installieren

```bash
dotnet new install C:\Templates\MvvmToolkitStarterTemplate
```

> Das registriert die Vorlage unter dem Kurznamen `mvvmtoolkitstarter`.

---

### 🧪 3. Neues Projekt mit der Vorlage erstellen

```bash
dotnet new mvvmtoolkitstarter -n MeinProjekt
```

Dadurch wird ein neues Verzeichnis `MeinProjekt` erstellt mit einem sauberen MVVM-Starterprojekt.

---

### 🧹 4. Vorlage wieder entfernen (optional)

```bash
dotnet new uninstall C:\Templates\MvvmToolkitStarterTemplate
```

---

## ℹ️ Features

- ✅ WPF (.NET 6+)
- ✅ MVVM mit [CommunityToolkit.Mvvm](https://learn.microsoft.com/en-us/windows/communitytoolkit/mvvm/)
- ✅ Navigation via ViewModel
- ✅ Services & Dependency Injection
- ✅ Saubere Projektstruktur für einfache Erweiterung

---

## 🧑‍💻 Autor

**[Gandalug](https://github.com/Gandalug)** – made with ❤️ and pragmatism.
