# csharp_course

C# course repository for laboratory work, practical exercises, and Windows Forms development.

## Development environment

- Language: C#
- Framework: .NET 8.0
- UI: Windows Forms
- IDE: Visual Studio Community 2022
- Office integration: Microsoft Office LTSC 2024
- Database: PostgreSQL (planned)

## Practical works

| №  | Topic                          | Project directory                                                               | Status    |
|----|--------------------------------|---------------------------------------------------------------------------------|-----------|
| 1  | Introduction to Windows Forms  | [2026-09-17-introduction](IV_course/2026-09-17-introduction/)                   | Completed |
| 2  | Visual Application Development | [2026-09-20-visual-development](IV_course/2026-09-20-visual-development/)       | Completed |
| 3  | User Interface Controls        | [2026-09-20-user-interface](IV_course/2026-09-20-user-interface/)               | Completed |
| 4  | System Dialogs and Text Editor | [2026-10-03-system-dialogs](IV_course/2026-10-03-system-dialogs/)               | Completed |
| 5  | Base Point Drawing             | [practical-05-base-point-drawing](IV_course/practical-05-base-point-drawing/)   | Planned   |
| 6  | Drawing Animation              | [practical-06-animation](IV_course/practical-06-animation/)                     | Planned   |
| 7  | Cafe Order Interface           | [practical-07-cafe-order](IV_course/practical-07-cafe-order/)                   | Planned   |
| 8  | Tabular Data and XML           | [practical-08-tabular-data](IV_course/practical-08-tabular-data/)               | Planned   |
| 9  | Image Rendering                | [practical-09-image-rendering](IV_course/practical-09-image-rendering/)         | Planned   |
| 10 | Graphics Chart                 | [practical-10-graphics-chart](IV_course/practical-10-graphics-chart/)           | Planned   |
| 11 | Database Connection            | [practical-11-database-connection](IV_course/practical-11-database-connection/) | Planned   |
| 12 | Database Operations            | [practical-12-database-operations](IV_course/practical-12-database-operations/) | Planned   |
| 13 | Word Automation                | [practical-13-word-automation](IV_course/practical-13-word-automation/)         | Planned   |
| 14 | Excel Automation               | [practical-14-excel-automation](IV_course/practical-14-excel-automation/)       | Planned   |

## Project initialization

The `IV_course/init_practicals.ps1` PowerShell script automates the initialization of Windows Forms projects for practical works №5–14.

It creates C# projects targeting .NET 8.0, generates the required project files, and adds a `screenshots` directory to each project. Existing projects are skipped to prevent overwriting.

Run from the `IV_course` directory:

```powershell
powershell -ExecutionPolicy Bypass -File .\init_practicals.ps1
```


