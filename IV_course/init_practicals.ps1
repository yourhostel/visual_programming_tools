# Зупиняти виконання скрипту, якщо команда PowerShell завершується помилкою.
$ErrorActionPreference = 'Stop'

# Скрипт потрібно запускати з каталогу IV_course.
# Ключ словника: назва каталогу практичної роботи.
# Значення словника: назва C# проєкту.
# [ordered] зберігає порядок оголошення проєктів.
$projects = [ordered]@{
    # Виконані, на момент створення скрипту, практичні роботи №1–4.
    # '2026-09-17-introduction' = 'Introduction'
    # '2026-09-20-visual-development' = 'VisualDevelopment'
    # '2026-09-20-user-interface' = 'UserInterface'
    # '2026-10-03-system-dialogs' = 'SystemDialogs'

    # Практичні роботи №5–14.
    'practical-05-base-point-drawing' = 'BasePointDrawing'
    'practical-06-animation' = 'DrawingAnimation'
    'practical-07-cafe-order' = 'CafeOrder'
    'practical-08-tabular-data' = 'TabularData'
    'practical-09-image-rendering' = 'ImageRendering'
    'practical-10-graphics-chart' = 'GraphicsChart'
    'practical-11-database-connection' = 'DatabaseConnection'
    'practical-12-database-operations' = 'DatabaseOperations'
    'practical-13-word-automation' = 'WordAutomation'
    'practical-14-excel-automation' = 'ExcelAutomation'
}

# Перевірити, чи встановлено .NET SDK і чи доступна команда dotnet.
# Якщо команда відсутня, припинити виконання з повідомленням про помилку.
if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    throw 'dotnet SDK was not found. Install .NET 8 SDK and retry.'
}

# Послідовно перебрати всі записи словника.
foreach ($entry in $projects.GetEnumerator()) {

    # Отримати назву каталогу та назву проєкту.
    $folder = $entry.Key
    $name = $entry.Value

    # Якщо файл проєкту .csproj уже існує, пропустити його,
    # щоб не перезаписати результати попередньої роботи.
    if (Test-Path (Join-Path $folder "$name.csproj")) {
        Write-Host "Skipping existing project: $folder"
        continue
    }

    # Вивести інформацію про створюваний проєкт.
    Write-Host "Creating $name in $folder..."

    # Створити Windows Forms проєкт:
    # --framework: цільова версія .NET
    # --name: назва проєкту та простору імен
    # --output: каталог для створених файлів
    dotnet new winforms --framework net8.0 --name $name --output $folder

    # Перевірити код завершення зовнішньої команди dotnet.
    # Значення 0 означає успішне виконання.
    if ($LASTEXITCODE -ne 0) {
        throw "Failed to create $name"
    }

    # Створити каталог для скриншотів практичної роботи.
    # -Force дозволяє не отримувати помилку, якщо каталог уже існує.
    # Out-Null приховує службовий результат команди.
    New-Item -ItemType Directory -Path (Join-Path $folder 'screenshots') -Force | Out-Null
}

# Повідомити про завершення ініціалізації всіх проєктів.
Write-Host 'All projects initialized.'