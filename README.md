# Stock Project  
A simple C# learning project for practicing **OOP fundamentals, collections, console input, and unit testing with xUnit**.

---

## 📂 Solution Structure

### **1. Stock (Class Library)**  
The main logic of the application.

#### **Product**  
Represents a single product in stock:  
- `Id` – automatically assigned integer  
- `Name` – string  
- `Price` – decimal  

#### **Stock**  
Manages a collection of products. Contains:  
- `List<Product> Products` – internal list of products  
- `AddProduct(Product product)` – adds a product to stock  
- `FindProductById(int id)` – returns the product if it exists  
- `GetProductById(int id)` – returns and removes the product  

---

### **2. Stock.Test (xUnit Tests)**  
A fully separated test project used to validate business logic.

Contains unit tests such as:  
- `FindExistingProductTest` – verifies that added products can be found  
- `FindNotExistingProductTest` – checks that searching for non‑existent products returns `null`  
- Additional assertion tests using:  
  - `Equal`  
  - `True`  
  - `False`  
  - `Null`  
  - `NotNull`  
  - `Throws`  
- Parameterized tests using `InlineData`

These tests ensure the Stock logic is stable, predictable, and maintainable.

---

### **3. StockApp (Deprecated / Not Used Anymore)**  
> ⚠️ **This project is no longer used and is kept only for reference.**  
It previously served as a console UI, but the project has been refactored and StockApp is no longer needed.  
Stock and Stock.Test are the only active projects.

---

## ⭐ Features  
This project demonstrates:  
- Object‑oriented programming fundamentals  
- Creating and managing collections (`List<T>`)  
- Encapsulating logic inside classes  
- Writing and organizing unit tests with **xUnit**  
- Using parameterized tests (`[Theory]` + `InlineData`)  
- Clean structure based on best practices

---

## ▶️ How to Run  

### **Running Tests**
1. Open the solution in Visual Studio  
2. Open **Test Explorer** (`Test → Test Explorer`)  
3. Run all tests or individual methods  

### **Running Application Logic**
The logic exists in the `Stock` library — it is tested and used programmatically (StockApp is no longer used).

---

## 🧪 Example Test Snippets  

### Parameterized test:
```csharp
[Theory]
[InlineData(2, 3, 5)]
[InlineData(10, 5, 15)]
[InlineData(-1, 1, 0)]
public void AddingNumbersTest(int a, int b, int expected)
{
    int result = a + b;
    Assert.Equal(expected, result);
}
```

### Example Stock test:
```csharp
[Fact]
public void FindExistingProductTest()
{
    var stock = new Stock();
    stock.AddProduct(new Product("Mouse", 100));
    var found = stock.FindProductById(1);

    Assert.NotNull(found);
    Assert.Equal("Mouse", found.Name);
}
```

---

## 🎯 Summary  
This repository contains a clean, educational C# project built to learn:  
✔ classes and objects  
✔ list management  
✔ unit testing  
✔ project structure  
✔ writing maintainable code  

StockApp has been deprecated, and the main focus is now on **Stock** and **Stock.Test**.

