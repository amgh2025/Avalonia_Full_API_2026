# Avalonia + API Project (Beginner Guide)

This project demonstrates how to build a simple desktop application using **Avalonia UI** and connect it to a backend **ASP.NET Core API**.

---

## 📌 Requirements

Make sure you have the following installed:

* [.NET SDK 8.0](https://dotnet.microsoft.com/download)
* Git
* Linux (WSL) or Windows

---

## 🚀 Step 1: Install Avalonia Templates

Open terminal and run:

```bash
dotnet new install Avalonia.Templates
```

---

## 📁 Step 2: Create the Project

```bash
mkdir Project
cd Project

# Create Avalonia App
dotnet new avalonia.mvvm -n MyApp

# Enter project folder
cd MyApp
```

---

## ⚠️ Step 3: Fix .NET Version

Open the project file:

```bash
nano MyApp.csproj
```

Change this line:

```xml
<TargetFramework>net10.0</TargetFramework>
```

To:

```xml
<TargetFramework>net8.0</TargetFramework>
```

---

## ▶️ Step 4: Run the Application

```bash
dotnet restore
dotnet run
```

You should see a window like:

```
Welcome to Avalonia!
```

---

## 🧩 Step 5: Add ComboBox Example

### Update View (MainWindow.axaml)

```xml
<ComboBox ItemsSource="{Binding Periods}"
          SelectedItem="{Binding SelectedPeriod}" />
```

---

### Update ViewModel

```csharp
public ObservableCollection<string> Periods { get; } = new()
{
    "Daily",
    "Weekly",
    "Monthly",
    "Yearly"
};
```

---

## 🌐 Step 6: Create API Project

Go back to root folder:

```bash
cd ..
dotnet new web -n MyApp.Api
cd MyApp.Api
```

---

### Replace Program.cs

```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var periods = new[]
{
    "Daily",
    "Weekly",
    "Monthly",
    "Yearly"
};

app.MapGet("/api/periods", () => periods);

app.Run("http://localhost:5000");
```

Run API:

```bash
dotnet run
```

---

## 🔗 Step 7: Connect Avalonia to API

In ViewModel:

```csharp
using System.Net.Http.Json;

var items = await client.GetFromJsonAsync<string[]>(
    "http://localhost:5000/api/periods");
```

---

## 🧠 How It Works

* API provides data (`/api/periods`)
* Avalonia fetches data using HTTP
* ComboBox displays the data

---

## ⚠️ Common Issues

### ComboBox is empty

* Check `DataContext`
* Check property name (`Periods`)
* Make sure API is running

### App doesn't open in WSL

* Run UI from Windows
* Or configure WSL GUI

---

## 🎯 Result

You will have:

* Desktop UI (Avalonia)
* Backend API (ASP.NET Core)
* Data binding between them



Happy coding 🚀
