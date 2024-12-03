<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Обработка текста на PHP</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 20px;
        }
        .container {
            max-width: 600px;
            margin: auto;
            background: white;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
        }
        h1 {
            color: #333;
            text-align: center;
        }
        p {
            background: #e0e0e0;
            padding: 10px;
            border-radius: 5px;
            margin: 10px 0;
            line-height: 1.5;
        }
        .result {
            font-weight: bold;
            color: #007BFF;
        }
    </style>
</head>
<body>

<div class="container">
    <h1>Обработка текста на PHP</h1>

    <?php
    // Исходный текст с HTML-тегами
    $input_text = "<p>Привет! Это <strong>пример</strong> программы на PHP.</p>";

    // Удаление HTML-тегов с помощью функции strip_tags
    $clean_text = strip_tags($input_text);

    // Поиск позиции последнего вхождения слова "пример"
    $last_position = strrpos($clean_text, 'пример');

    // Форматированный вывод с помощью функции printf
    printf("<p class='result'>Обработанный текст: %s</p>", $clean_text);
    printf("<p class='result'>Последнее вхождение слова 'пример' находится на позиции: %d</p>", $last_position);

    // Преобразование первой буквы каждого слова в верхний регистр с помощью функции ucwords
    $formatted_text = ucwords($clean_text);
    printf("<p class='result'>Текст с заглавными буквами: %s</p>", $formatted_text);
    ?>
</div>

</body>
</html>