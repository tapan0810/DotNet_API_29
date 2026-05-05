# 🏠 StayEase API

A scalable and production-ready ASP.NET Core Web API for managing Paying Guest (PG) accommodations. Built using clean architecture principles with Repository Pattern, Service Layer, DTOs, AutoMapper, and centralized exception handling.

---

## 🚀 Features

* ✅ CRUD operations for PG listings
* ✅ Clean Architecture (Controller → Service → Repository → DbContext)
* ✅ Repository Pattern implementation
* ✅ DTO-based data transfer
* ✅ AutoMapper for object mapping
* ✅ Global Exception Handling Middleware
* ✅ Entity Framework Core integration
* ✅ Asynchronous programming (async/await)
* ✅ Scalable and maintainable code structure

---

## 🧱 Tech Stack

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* AutoMapper

---

## 📂 Project Structure

```
Controllers/
Services/
Repositories/
Entities/
DTOs/
Mapping/
Exceptions/
Middleware/
```

---

## ⚙️ API Endpoints

| Method | Endpoint     | Description  |
| ------ | ------------ | ------------ |
| GET    | /api/pg      | Get all PGs  |
| GET    | /api/pg/{id} | Get PG by ID |
| POST   | /api/pg      | Create PG    |
| PUT    | /api/pg/{id} | Update PG    |
| DELETE | /api/pg/{id} | Delete PG    |

---

## 🛠️ Setup & Run

1. Clone the repository

```
git clone https://github.com/your-username/StayEase-API.git
```

2. Navigate to project folder

```
cd StayEase-API
```

3. Restore dependencies

```
dotnet restore
```

4. Update connection string in `appsettings.json`

5. Run migrations

```
dotnet ef database update
```

6. Run the application

```
dotnet run
```

---

## 🧪 Sample Request (POST)

```
POST /api/pg
Content-Type: application/json

{
  "name": "Sunrise PG",
  "description": "Comfortable stay with all amenities",
  "location": "Bangalore",
  "contact": "9876543210",
  "owner": "Ravi"
}
```

---

## 🎯 Highlights

* Clean separation of concerns
* Industry-standard architecture
* Easy to extend and maintain
* Production-ready error handling

---

## 🔮 Future Enhancements

* 🔍 Search & filtering (location-based)
* 📄 Pagination & sorting
* 🔐 Authentication & Authorization (JWT)
* 📊 Logging & monitoring

---

## 👨‍💻 Author

**Tapan Ray**
Software Engineer

---
