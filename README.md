# Stock Project

A simple C# learning project for practicing **OOP fundamentals, collections, console input, and unit testing with xUnit**.

## Solution Structure

The solution contains the following projects:

### 1. Stock
- A class library containing the main logic.
- **Product** – a basic data model representing a product:
  - `Id` (automatically assigned integer)
  - `Name` (string)
  - `Price` (decimal)
- **Stock** – a class for managing a list of products, with methods:
  - `AddProduct(Product product)` – adds a product to the stock
  - `FindProductById(int id)` – finds a product by its Id
  - `GetProductById(int id)` – finds a product by Id and removes it from the stock

### 2. StockApp
- A console application for interacting with the stock.
- Allows users to:
  - Add products interactively (enter Name and Price)
  - Automatically assign sequential Ids
  - Display all products
  - Search for products by Id

### 3. Stock.Test
- A separate xUnit test project containing unit tests:
  - `FindExistingProductTest` – checks that a product added to stock can be found using `FindProductById`
  - `FindNotExistingProductTest` – checks that searching for a non-existing product returns `null`

## Features

- Object-oriented programming fundamentals
- Working with collections (`List<Product>`)
- Console input/output (`Console.ReadLine`, `Console.WriteLine`)
- Writing simple unit tests using xUnit

## How to Use

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Set **StockApp** as the startup project to run the console application.
4. Run `StockApp`:
   - Enter product names and prices when prompted.
   - Products will automatically get unique Ids.
   - You can view all products and search by Id.
5. Run **Stock.Test** using the Test Explorer in Visual Studio to verify unit tests.

## Example Console Output

