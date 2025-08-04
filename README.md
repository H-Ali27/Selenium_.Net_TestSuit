# 🧪 Selenium Automation Framework (.NET Framework)

This repository contains a robust and scalable **Selenium WebDriver automation framework** built using **.NET Framework (v4.7.2)**. It demonstrates best practices in test automation using:

- ✅ **Object-Oriented Programming (OOP)**
- 🧱 **Page Object Model (POM)**
- 📁 **External JSON locator files**
- 📊 **Data-driven testing with CSV files**
- 📸 **Screenshot capture on test status**
- 📝 **Extent HTML Reporting** for detailed execution logs
---
## 📂 Project Structure
UnitTestProject1/
│
├── Pages/ # POM-based page classes
├── Locators/ # JSON files for element locators
├── TestData/ # CSV files for data-driven testing
├── Reports/ # Generated HTML test reports
├── Screenshots/ # Screenshots of test execution
├── Utilities/ # Helper classes (e.g., JSON reader, CSV parser)
└── Tests/ # Test classes using NUnit or MSTest


---

## 🚀 Features

- **Page Object Model (POM)** for clear and reusable UI interactions
- **Data-driven testing** using CSV files for dynamic inputs
- **JSON-based element locators** to simplify maintenance
- **Screenshot capture** on pass/failure for reporting
- **Extent Reports** for professional HTML report generation
- Easy integration with CI/CD pipelines

---

## 🔧 Prerequisites

- Visual Studio 2019 or newer
- .NET Framework 4.7.2
- NuGet packages:
  - `Selenium.WebDriver` (v4.18.1)
  - `ExtentReports` (v4.1.0)
  - `Newtonsoft.Json`
  - `CsvHelper` or equivalent (optional)

---

## 📌 How to Run

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/your-repo-name.git


Open the solution in Visual Studio.
Build the project to restore dependencies.
Update test data paths (CSV/JSON) if needed.
Run tests using Test Explorer or terminal:
dotnet test
Open the generated HTML report in /Reports directory.

📷 Sample Report & Screenshots
📍 HTML Report: Located in Screenshots/Index.html
🖼️ Screenshots: Saved in the Screenshots/ folder and embedded in the report

💡 Customization
Modify JSON locator files in /Locators to manage UI elements
Use additional CSV data files to extend test coverage
Customize report name and path inside the ExtentHtmlReporter config

📄 License
This project is open-source and available under the MIT License.


---

Let me know if you'd like me to tailor this more toward MSTest, NUnit, or provide badge support (build, license, etc.) for GitHub display.
Built with 💙 by HAMZAL ALI


