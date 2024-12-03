<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Определение декады месяца</title>
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
    <h1>Определение декады месяца</h1>

    <?php
    // Массив с числами от 1 до 31
    $day = range(1, 31); // Можно заменить на любой другой массив чисел

    // Определение декады
    $decades = [
        'Первая декада' => [],
        'Вторая декада' => [],
        'Третья декада' => []
    ];

    foreach ($day as $number) {
        if ($number >= 1 && $number <= 10) {
            $decades['Первая декада'][] = $number;
        } elseif ($number >= 11 && $number <= 20) {
            $decades['Вторая декада'][] = $number;
        } elseif ($number >= 21 && $number <= 31) {
            $decades['Третья декада'][] = $number;
        }
    }

    // Вывод результатов
    foreach ($decades as $decade => $numbers) {
        echo "<p class='result'>$decade: " . implode(', ', $numbers) . "</p>";
    }
    ?>
</div>

</body>
</html>