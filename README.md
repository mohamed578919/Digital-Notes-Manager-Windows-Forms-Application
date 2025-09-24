# 📝 Digital Notes Manager – Windows Forms Application

##  Overview
**Digital Notes Manager** is a Windows Forms application that allows users to create, edit, organize, and manage personal notes efficiently.  
The system supports a Multi-Document Interface (MDI), a custom category selector with events, and file dialog operations for saving and loading notes.  

---

##  Features
- **Multi-Document Interface (MDI):** Open and manage multiple notes simultaneously.
- **Custom Control with Custom Event:** Category selector component that triggers `CategoryChanged` events.
- **File Operations:** Save and open notes using `SaveFileDialog` and `OpenFileDialog`.
- **Rich Text Editing:** Basic formatting such as **Bold**, *Italic*, and _Underline_.
- **Notes Management:** View notes in a `DataGridView` with sorting and filtering options.
- **Reminders:** Set reminders using `DateTimePicker` with notifications when due.
- **MenuStrip Navigation:** Comprehensive navigation (File, Edit, View, Help).
- **Search & Organization:** Search within notes and filter/group by category.
- **User Authentication (Bonus):** Login system for securing user notes.

---

##  UI Components
- **Main Form (MDI Parent):** Hosts `MenuStrip` and `ToolStrip`.
- **Note Editor (MDI Child Form):** Contains `RichTextBox`, `ComboBox`, `DateTimePicker`.
- **Category Selector (Custom Control):** Provides note categorization with custom events.
- **Notes List:** Managed using `DataGridView`.
- **File Dialogs:** Enable saving/loading notes from external `.txt` files.
- **Search & Filter:** Includes search box and filtering tools.

---

##  Database Schema (SQL Server)
- **Users Table:** `Username`, `Password`
- **Notes Table:** `NoteID`, `Title`, `Content`, `Category`, `CreationDate`, `ReminderDate`, `UserID`

---

##  Technologies Used
- **C# (.NET Framework / Windows Forms)**
- **SQL Server** (for storing notes and user data)
- **Windows Forms Controls** (`DataGridView`, `RichTextBox`, `DateTimePicker`, `MenuStrip`)
- **Custom User Controls & Events**

---

##  Installation & Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/Digital-Notes-Manager.git
