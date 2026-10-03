# Практична робота № 4. Розробка діалогових вікон. Системні діалоги

[![YouTube](https://img.shields.io/badge/YouTube-демонстрація_роботи-red?logo=youtube&logoColor=white)](https://youtu.be/QcgI9hq4OJU)

- Мова програмування: C#
- Технологія: Windows Forms (.NET 8.0)
- Середовище розробки: Visual Studio Community 2022

Мета роботи

Ознайомитися із системними діалоговими вікнами Windows Forms та навчитися
використовувати їх під час розробки прикладних програм.

Закріпити навички роботи з компонентами `OpenFileDialog`, `SaveFileDialog`,
`FontDialog` і `PrintDialog`, а також елементами інтерфейсу `MenuStrip`,
`ContextMenuStrip`, `ToolStrip` і `RichTextBox`.

Завдання

Розробити текстовий редактор із використанням стандартних компонентів
Windows Forms для роботи з файлами, текстом і системними діалоговими вікнами.

Програма повинна забезпечувати:

- відкриття текстових файлів;
- збереження тексту у файл;
- друк;
- копіювання, вирізання та вставлення тексту;
- зміну шрифту виділеного тексту;
- головне меню програми;
- контекстне меню текстового поля;
- довідку з інформацією про розробника;
- панель інструментів зі стандартним набором кнопок.

### Елементи головного меню `mainMenuStrip`

| Розділ меню | Пункт     | Ім'я компонента |
|-------------|-----------|-----------------|
| Файл        | —         | `fileMenuItem`  |
| Файл        | Відкрити  | `openMenuItem`  |
| Файл        | Зберегти  | `saveMenuItem`  |
| Файл        | Друк      | `printMenuItem` |
| Файл        | Вихід     | `exitMenuItem`  |
| Правка      | —         | `editMenuItem`  |
| Правка      | Копіювати | `copyMenuItem`  |
| Правка      | Вирізати  | `cutMenuItem`   |
| Правка      | Вставити  | `pasteMenuItem` |
| Довідка     | —         | `helpMenuItem`  |

### Елементи контекстного меню `editorContextMenuStrip`

| Text      | `(Name)`               |
| --------- | ---------------------- |
| Копіювати | `contextCopyMenuItem`  |
| Вирізати  | `contextCutMenuItem`   |
| Вставити  | `contextPasteMenuItem` |
| Шрифт     | `contextFontMenuItem`  |

### Системні діалогові компоненти

| Компонент        | Ім'я компонента  | Призначення                    |
|------------------|------------------|--------------------------------|
| `OpenFileDialog` | `openFileDialog` | Вибір файлу для відкриття      |
| `SaveFileDialog` | `saveFileDialog` | Вибір файлу для збереження     |
| `FontDialog`     | `fontDialog`     | Вибір параметрів шрифту        |
| `PrintDialog`    | `printDialog`    | Налаштування параметрів друку  |
| `PrintDocument`  | `printDocument`  | Формування документа для друку |

### Обробники подій

| Компонент              | Подія       | Обробник                    | Призначення                                        |
|------------------------|-------------|-----------------------------|----------------------------------------------------|
| `openMenuItem`         | `Click`     | `openMenuItemClick`         | Відкриття файла за допомогою `OpenFileDialog`      |
| `saveMenuItem`         | `Click`     | `saveMenuItemClick`         | Збереження тексту за допомогою `SaveFileDialog`    |
| `exitMenuItem`         | `Click`     | `exitMenuItemClick`         | Закриття текстового редактора                      |
| `copyMenuItem`         | `Click`     | `copyMenuItemClick`         | Копіювання виділеного тексту                       |
| `cutMenuItem`          | `Click`     | `cutMenuItemClick`          | Вирізання виділеного тексту                        |
| `pasteMenuItem`        | `Click`     | `pasteMenuItemClick`        | Вставлення тексту з буфера обміну                  |
| `contextCopyMenuItem`  | `Click`     | `contextCopyMenuItemClick`  | Копіювання виділеного тексту через контекстне меню |
| `contextCutMenuItem`   | `Click`     | `contextCutMenuItemClick`   | Вирізання виділеного тексту через контекстне меню  |
| `contextPasteMenuItem` | `Click`     | `contextPasteMenuItemClick` | Вставлення тексту через контекстне меню            |
| `contextFontMenuItem`  | `Click`     | `contextFontMenuItemClick`  | Зміна шрифту виділеного тексту через `FontDialog`  |
| `printMenuItem`        | `Click`     | `printMenuItemClick`        | Відкриття системного діалогу друку та запуск друку |
| `printDocument`        | `PrintPage` | `printDocumentPrintPage`    | Формування вмісту сторінки для друку               |
| `helpMenuItem`         | `Click`     | `helpMenuItemClick`         | Відображення інформації про програму та розробника |

### Робота з файлами та форматуванням тексту

Редактор підтримує роботу з текстовими файлами форматів `.txt` і `.rtf`.

![Screenshot 2026-10-03 210744.png](screenshots/Screenshot%202026-10-03%20210744.png)

Для звичайних текстових файлів `.txt` читання та запис виконуються за допомогою
методів `File.ReadAllText()` і `File.WriteAllText()`. Формат `.txt` зберігає
лише текст без параметрів його оформлення.

Для файлів `.rtf` використовуються методи `LoadFile()` і `SaveFile()` компонента
`RichTextBox` із типом `RichTextBoxStreamType.RichText`. Формат `.rtf` дозволяє
зберігати не тільки текст, а й його форматування, зокрема гарнітуру, розмір
і накреслення шрифту.

![Screenshot 2026-10-03 210850.png](screenshots/Screenshot%202026-10-03%20210850.png)

Тип файла визначається за його розширенням. Після відкриття або збереження файла
його ім'я відображається в заголовку головного вікна редактора.

![Screenshot 2026-10-03 210633.png](screenshots/Screenshot%202026-10-03%20210633.png)

Зміна шрифту виконується для виділеного фрагмента тексту за допомогою
`FontDialog`. Операції копіювання, вирізання та вставлення доступні як
у головному меню, так і в контекстному меню `RichTextBox`.

### Друк документа

Для друку тексту використовуються компоненти `PrintDialog` і `PrintDocument`.

Компонент `PrintDialog` відкриває стандартне системне діалогове вікно Windows,
у якому користувач може вибрати доступний принтер і налаштувати параметри друку.

Компонент `PrintDocument` формує документ для друку. У події `PrintPage`
вміст `editorRichTextBox` передається на сторінку документа за допомогою
методу `DrawString()` з урахуванням установлених полів сторінки.

Після підтвердження параметрів у системному діалозі викликається метод
`Print()`, який передає сформований документ вибраному принтеру.

![Screenshot 2026-10-03 213548.png](screenshots/Screenshot%202026-10-03%20213548.png)

![Screenshot 2026-10-03 213636.png](screenshots/Screenshot%202026-10-03%20213636.png)

![Screenshot 2026-10-03 213743.png](screenshots/Screenshot%202026-10-03%20213743.png)

![Screenshot 2026-10-03 215111.png](screenshots/Screenshot%202026-10-03%20215111.png)

### Інформація про програму та розробника

Пункт головного меню `Довідка` відкриває стандартне інформаційне діалогове
вікно `MessageBox`, у якому відображаються назва практичної роботи та
інформація про розробника програми.

![Screenshot 2026-10-04 010258.png](screenshots/Screenshot%202026-10-04%20010258.png)