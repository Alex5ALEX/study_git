<?php
declare(strict_types=1);

// Функция для вычисления суммы двух целых чисел
function sum(int $a, int $b): int {
    return $a + $b;
}
?>

<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Пример строгой типизации</title>
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
        .result {
            background: #e0e0e0;
            padding: 10px;
            border-radius: 5px;
            margin: 10px 0;
            text-align: center;
            font-weight: bold;
            color: #007BFF;
        }
        .error {
            color: red;
        }
    </style>
</head>
<body>

<div class="container">
    <h1>Пример строгой типизации в PHP</h1>

    <?php
    // Вызов функции с целыми числами
    $first_number = 5;
    $second_number = 10;

    echo "<div class='result'>Сумма целых чисел: " . sum($first_number, $second_number) . "</div>";

    // Попытка вызвать функцию, передав одно число в виде строки
    $third_number = "15";

    try {
        echo "<div class='result'>Сумма с числом в виде строки: " . sum($first_number, (int)$third_number) . "</div>";
    } catch (TypeError $e) {
        echo "<div class='error'>Ошибка: " . $e->getMessage() . "</div>";
    }
    ?>
</div>

</body>
</html>