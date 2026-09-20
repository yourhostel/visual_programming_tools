# Практична робота № 3. Налаштування інтерфейсу користувача

- Мова програмування: C#
- Технологія: Windows Forms (.NET 8.0)
- Середовище розробки: Visual Studio Community 2022

Мета роботи

Навчитися налаштовувати інтерфейс користувача у Windows Forms, працювати з властивостями
елементів керування та обробляти їхні події. Закріпити навички перевірки введених даних,
керування доступністю кнопок, використання циклу `for` і виведення результатів
у багаторядкове текстове поле.

Реалізовані завдання

1. Вартість придбаного товару [ProductCostForm.cs](https://github.com/yourhostel/visual_programming_tools/blob/main/IV_course/2026-09-20-user-interface/ProductCostForm.cs)

![Screenshot 2026-09-20 170653.png](screenshots/Screenshot%202026-09-20%20170653.png)

![Screenshot 2026-09-20 170717.png](screenshots/Screenshot%202026-09-20%20170717.png)

Форма зчитує кількість одиниць товару та обчислює загальну вартість за заданою
константою ціни. Кнопка «Обчислити» активується після заповнення поля введення
за допомогою обробника події `TextChanged`. Перед обчисленням перевіряється,
чи є введена кількість цілим додатним числом.

2. Сума непарних чисел [OddNumbersSumForm.cs](https://github.com/yourhostel/visual_programming_tools/blob/main/IV_course/2026-09-20-user-interface/OddNumbersSumForm.cs)

![Screenshot 2026-09-20 170842.png](screenshots/Screenshot%202026-09-20%20170842.png)

![Screenshot 2026-09-20 170905.png](screenshots/Screenshot%202026-09-20%20170905.png)

![Screenshot 2026-09-20 170930.png](screenshots/Screenshot%202026-09-20%20170930.png)

![Screenshot 2026-09-20 170951.png](screenshots/Screenshot%202026-09-20%20170951.png)

![Screenshot 2026-09-20 171005.png](screenshots/Screenshot%202026-09-20%20171005.png)

Форма зчитує два цілих числа A і B та обчислює суму всіх непарних чисел
у проміжку від A до B включно. Для перебору чисел використано цикл `for`,
а для перевірки непарності — оператор остачі від ділення `%`.
Перед обчисленням перевіряються коректність введення та порядок меж проміжку.

3. Куби чисел [NumberCubesForm.cs](https://github.com/yourhostel/visual_programming_tools/blob/main/IV_course/2026-09-20-user-interface/NumberCubesForm.cs)

![Screenshot 2026-09-20 171038.png](screenshots/Screenshot%202026-09-20%20171038.png)

Програма обчислює куби чисел від 1 до 9 із кроком 2 за допомогою циклу `for`.
Результати виводяться стовпчиком у багаторядкове текстове поле `TextBox`
за допомогою методу `AppendText()`. Перед повторним обчисленням попередні
результати очищуються. Передбачено окремі кнопки для очищення поля та закриття форми.

Структура додатка

[MainForm.cs](https://github.com/yourhostel/visual_programming_tools/blob/main/IV_course/2026-09-20-user-interface/MainForm.cs)

![Screenshot 2026-09-20 170632.png](screenshots/Screenshot%202026-09-20%20170632.png)

`MainForm.cs` є стартовою формою та містить меню вибору завдання. Кожне завдання реалізовано
в окремій формі, яка відкривається з головного меню.