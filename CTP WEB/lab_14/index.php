<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Преобразование строки в camelCase</title>
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
    <h1>Преобразование строки в camelCase</h1>

    <?php
    // Функция для преобразования строки в camelCase с использованием цикла
    function toCamelCase($string) {
        $result = '';
        $toUpper = false; // Флаг для определения, нужно ли делать букву заглавной

        // Проходим по каждому символу строки
        for ($i = 0; $i < strlen($string); $i++) {
            $char = $string[$i];

            if ($char === '_') {
                // Если символ подчеркивания, следующий символ должен быть заглавным
                $toUpper = true;
            } else {
                // Если флаг установлен, делаем букву заглавной
                if ($toUpper) {
                    $result .= strtoupper($char);
                    $toUpper = false; // Сбрасываем флаг
                } else {
                    $result .= $char;
                }
            }
        }

        // Приводим первую букву к нижнему регистру для camelCase
        return lcfirst($result);
    }

    // Пример строки
    $input_string = 'var_text_hello';
    $camel_case_string = toCamelCase($input_string);

    // Вывод результата
    printf("<p>Исходная строка: %s</p>", htmlspecialchars($input_string));
    printf("<p class='result'>Преобразованная строка: %s</p>", htmlspecialchars($camel_case_string));
    ?>
</div>

</body>
</html>