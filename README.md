# Avalonia + REST API Project

This project contains:

* 🖥️ **Avalonia UI (Desktop App)**
* 🌐 **ASP.NET Core REST API**
* 🔗 Connected via HTTP

---

## 📂 Project Structure

```
Avalonia_Full_API/
 ├── MyApp/        → Avalonia Desktop App
 ├── MyApp.Api/    → REST API (CRUD + Swagger)
 ├── Avalonia_Full_API.sln
```

---

## ⚙️ Requirements

* .NET 8 SDK
* Linux (WSL) or Windows
* Git

---

## 🚀 How to Run the Project

### 1️⃣ Run the API

Open terminal:

```bash
cd MyApp.Api
dotnet run
```

API will run at:

```
http://localhost:5000
```

Swagger UI:

```
http://localhost:5000/swagger
```

---

### 2️⃣ Run the Avalonia App

Open another terminal:

```bash
cd MyApp
dotnet run
```

---

## 🔗 How It Works

* API provides data:

```
GET /api/periods
```

* Avalonia app calls API using `HttpClient`
* Data is shown in a ComboBox

---

## 🧪 API Endpoints

| Method | Endpoint          | Description     |
| ------ | ----------------- | --------------- |
| GET    | /api/periods      | Get all items   |
| GET    | /api/periods/{id} | Get item by id  |
| POST   | /api/periods      | Create new item |
| PUT    | /api/periods/{id} | Update item     |
| DELETE | /api/periods/{id} | Delete item     |

---

## 📌 Example Request (POST)

```json
{
  "name": "Quarterly"
}
```

---

## ⚠️ Notes

* API must be running before the UI
* If ComboBox is empty → check API URL
* Default API URL:

```
http://localhost:5000/api/periods
```

---

## 🎯 Features

* Avalonia UI (MVVM)
* REST API (Minimal API)
* Swagger documentation
* CRUD operations

---



## 🚀 Future Improvements

* Add database (SQLite / SQL Server)
* Add authentication
* Improve UI design

---

Happy coding 🎉

