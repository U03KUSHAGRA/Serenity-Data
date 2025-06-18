# Serenity-Based .NET Application

A **role-based access control (RBAC)** application built with **Serenity** and **.NET**, supporting **multitenancy** and offering two specialized portals:

## 🔐 Login Portals

1.  Inventory Portal  
   Manage products, stock levels, and operations.

2.  Analytics Portal  
   Visualize and track ERP and business softwares.

## 🧩 Features

- **Role-Based Access Control (RBAC)**  
  Secure and customizable access by user roles.

- **Multitenancy**  
  Serve multiple tenants with complete data isolation.

- **Inventory Management**  
  Streamline product tracking and operational workflows.

- **Analytics Dashboard**  
  Clear, detailed charts powered by **Chart.js**.


## 🛠️ Technology Stack

- **Backend:** `.NET`, **Serenity Framework**  
- **Frontend:** **Serenity UI**, **Charts.js**  
- **Database:** SQL Server *(or your preferred provider)*  


## 🧪 Installation Guide

1. **Clone the repository:**
   ```bash
   git clone https://github.com/your-repo.git
   cd your-repo
   ```

2. **Configure database settings** in `appsettings.json`.

3. **Run the application:**
   ```bash
   dotnet run
   ```

## ⚙️ Sample `appsettings.json`

```json
{
  "Data": {
    "Default": {
      "ConnectionString": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER; Password=YOUR_PASSWORD;TrustServerCertificate=True;",
      "ProviderName": "System.Data.SqlClient"
    },
    "SerenityData": {
      "ConnectionString": "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER; Password=YOUR_PASSWORD;TrustServerCertificate=True;",
      "ProviderName": "System.Data.SqlClient"
    }
  },
  "Logging": {
    "LogLevel": {
      "Default": "Debug",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "CssBundling": {
    "Enabled": false,
    "Minimize": true,
    "UseMinCss": true
  },
  "LocalTextPackages": {
    "Site": "^(Controls|Db|Dialogs|Enums|Forms|Permission|Site|Validation)\\.",
    "Login": "^(Forms\\.Membership\\.Login|Db\\.Administration\\.User|Validation\\.Required|Dialogs)\\."
  },
  "ScriptBundling": {
    "Enabled": false,
    "Minimize": true,
    "UseMinJS": true
  },
  "UploadSettings": {
    "Path": "~/App_Data/upload/"
  },
  "MailSettings": {
    "DeliveryMethod": "Network",
    "From": "YOUR_EMAIL",
    "Smtp": {
      "Host": "YOUR_SMTP_HOST",
      "Port": 587,
      "Username": "YOUR_SMTP_USER",
      "Password": "YOUR_SMTP_PASSWORD",
      "EnableSsl": true
    }
  },
  "EnvironmentSettings": {
    "SiteExternalUrl": null
  }
}
```


## 📘 Usage

- **Inventory Portal**  
  Log in to manage products, stock, and business operations.  
  - **Username:** `Inventory`  
  - **Password:** `Digisure@123`

- **Analytics Portal**  
  Log in to monitor ERP performance and visualize key data.  
  - **Username:** `Analytics`  
  - **Password:** `Digisure@123`


