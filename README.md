# 🚀 ApiService – Modern .NET 9 Web API  

![.NET 9](https://img.shields.io/badge/.NET%209-blue?style=for-the-badge)
![Web API](https://img.shields.io/badge/Web%20API-%F0%9F%93%8C-green?style=for-the-badge)
![OpenAPI](https://img.shields.io/badge/OpenAPI-%F0%9F%94%A5-orange?style=for-the-badge)
![Swagger](https://img.shields.io/badge/Swagger-%E2%9C%85-purple?style=for-the-badge)
![ReDoc](https://img.shields.io/badge/ReDoc-%F0%9F%91%80-red?style=for-the-badge)

## 🎯 Overview  

**ApiService** is a modern **.NET 9 Web API** that leverages **OpenAPI** for documentation and **Swagger UI** for interactive API exploration. It provides **custom service defaults** and integrates with **Scalar** for efficient data handling. Designed for **scalability, maintainability, and ease of use**, this project is an **excellent starting point** for building robust web APIs.  

> **Why Use ApiService?**  
> - 🚀 **Rapid API Development** – Pre-configured for **fast API setup**.  
> - 📖 **Comprehensive Documentation** – Automatically generates **OpenAPI specs**.  
> - ⚡ **Interactive API Testing** – Integrated **Swagger UI & ReDoc**.  
> - 🛠 **Scalable & Customizable** – Supports **custom service defaults** for flexibility.  

---

## 🌟 Features  

✅ **Built with .NET 9** – Leverages the latest **ASP.NET Core** innovations.  
✅ **OpenAPI Documentation** – Provides **standardized API specs**.  
✅ **Swagger UI & ReDoc** – Enables **real-time API exploration & testing**.  
✅ **Scalar Integration** – Ensures **efficient data handling**.  
✅ **Custom Service Defaults** – Allows **customized configurations** for services.  

---

## 🏗️ Architecture & Project Structure  

📌 **src/ApiService** – Main API project with controllers and configurations.  
📌 **src/ApiService/Services** – Business logic and API services.  
📌 **src/ApiService/Endpoints** – Defines RESTful API endpoints.  

---

## 🚀 Getting Started  

### **📌 Prerequisites**  
✅ [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)  

### **Step 1: Clone the Repository**  
```bash
git clone https://github.com/MrEshboboyev/aspire-customization.git
cd ApiService
```

### **Step 2: Install Dependencies**  
```bash
dotnet restore
```

### **Step 3: Build the Application**  
```bash
dotnet build
```

### **Step 4: Run the Application**  
```bash
dotnet run
```

---

## 🌍 API Documentation  

Once the application is running, explore the API using:  

🔹 **Swagger UI** – [http://localhost:<port>/swagger](http://localhost:<port>/swagger)  
🔹 **ReDoc** – [http://localhost:<port>/redoc](http://localhost:<port>/redoc)  

> 📝 **Swagger UI** provides an interactive API experience, allowing you to test endpoints directly.  
> 🧐 **ReDoc** offers a beautifully structured API reference, making it easy to understand.  

---

## 📡 API Endpoints  

| Method | Endpoint       | Description |
|--------|--------------|-------------|
| **GET**  | `/api/status`  | Returns API health status |
| **GET**  | `/api/data`    | Fetches sample data |
| **POST** | `/api/data`    | Submits new data |
| **PUT**  | `/api/data/{id}` | Updates existing data |
| **DELETE** | `/api/data/{id}` | Removes a record |

---

## 🛠 Configuration  

Customize API settings in `appsettings.json`:  

```json
{
  "ApiSettings": {
    "ServiceName": "ApiService",
    "Version": "v1",
    "EnableSwagger": true
  }
}
```

---

## 🧪 Testing  

### **Unit Tests**  
Run tests to ensure API stability:  
```bash
dotnet test
```

### **Manual API Testing**  
📌 **Use Postman or Swagger UI** to:  
✅ **Check API health** → `/api/status`  
✅ **Fetch data** → `/api/data`  
✅ **Submit data** → `/api/data (POST)`  

---

## 🎯 Why Use This Project?  

✅ **Supercharged API Development** – Reduces setup time & boosts productivity.  
✅ **Well-Documented & Interactive** – Easily explore endpoints with Swagger & ReDoc.  
✅ **Scalable & Flexible** – Supports **custom service configurations**.  
✅ **Built for .NET 9** – Utilizes **latest performance improvements**.  

---

## 📜 License  

This project is licensed under the **MIT License**. See [LICENSE](LICENSE) for details.  

---

## 📞 Contact  

For feedback, contributions, or questions:  
📧 **Email**: mreshboboyev@gmail.com  
💻 **GitHub**: [MrEshboboyev](https://github.com/MrEshboboyev)  

---

🚀 **Start building scalable APIs with ApiService!** Clone the repo & get started today!  
