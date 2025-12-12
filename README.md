# AnyStore - Inventory & Billing Management System

**AnyStore** is a comprehensive desktop application developed in **C# (.NET Framework)** designed to manage retail store inventories, billing processes, and user management efficiently. It features a robust **SQL Server** database backend to ensure data integrity and fast transaction handling.

---

## 📸 Screenshots

### Admin Dashboard
![Admin Dashboard](screenshots/dashboard.png)

### Purchase & Billing Module
![Billing System](screenshots/billing.png)

### Inventory Management
![Inventory](screenshots/inventory.png)

---

## 🚀 Features

### 🔐 User Authentication
* **Role-Based Access Control:** Distinct Login for **Admins** and **Standard Users**.
* **Admin Privileges:** Full access to Users, Categories, Products, Inventory, and Transactions.
* **User Privileges:** Restricted access focused on Sales and Purchase operations.

### 📦 Inventory Management
* **Categories:** Add, update, and delete product categories.
* **Products:** Manage product details including Name, Category, Description, Rate, and Quantity.
* **Real-time Stock:** Inventory counts update automatically upon Purchase or Sales transactions.

### 💰 Billing & Transactions
* **Purchase Module:** Manage inventory procurement from Dealers.
* **Sales Module:** Handle customer billing with automated calculations.
* **Automated Math:** Automatically calculates **Sub Total**, **Discount (%)**, **VAT**, and **Grand Total**.
* **Search Functionality:** Quickly find products or dealers/customers by ID or Name.

### 🗄️ Database Management
* **Dealers & Customers:** A unified module to manage vendor and client contact details.
* **Transaction History:** Logs all financial movements for reporting.

---

## 🛠️ Technology Stack

* **Language:** C#
* **Framework:** .NET Framework
* **IDE:** Visual Studio
* **Database:** Microsoft SQL Server (MSSQL)
* **Tools:** SQL Server Management Studio (SSMS)

---

## 💾 Database Schema

The project uses a relational database design. Key tables include:

* `tbl_users`: Stores login credentials and user roles (Admin/User).
* `tbl_categories`: Product categories.
* `tbl_products`: Product details and current stock levels.
* `tbl_dea_cust`: Stores details for both Dealers and Customers.
* `tbl_transactions`: Records the main transaction header (Type, Date, Grand Total).
* `tbl_transaction_detail`: Records individual items within a transaction (Product ID, Rate, Qty).

---

## 👤 Author

**Dinod Deshanjana**

* **LinkedIn:** https://www.linkedin.com/in/dinod-deshanjana/
* **View My Portfolio:** https://dinoddeshanjana.github.io/Portfolio/
