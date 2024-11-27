<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Пример PHP</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 20px;
        }
        pre {
            background-color: #f4f4f4;
            padding: 10px;
            border: 1px solid #ccc;
            overflow: auto;
        }
    </style>
</head>
<body>

<?php
// Определение строк
$string1 = 'Это строка с одинарными кавычками.';
$string2 = "Это строка с двойными кавычками.";
$string3 = <<<EOL
Это строка с использованием heredoc.
Она может занимать несколько строк.
EOL;

// Определение массива
$array = [
    'первый' => 'Элемент 1',
    'второй' => 'Элемент 2',
    'третий' => 'Элемент 3'
];

// Вывод строк
echo '<h2>Вывод строк:</h2>';
echo '<p>' . $string1 . '</p>';
echo '<p>' . $string2 . '</p>';
echo '<pre>' . htmlspecialchars($string3) . '</pre>';

// Вывод массива
echo '<h2>Вывод массива:</h2>';
echo '<h3>С помощью print_r:</h3>';
echo '<pre>';
print_r($array);
echo '</pre>';

echo '<h3>С помощью serialize:</h3>';
$serializedArray = serialize($array);
echo '<pre>' . htmlspecialchars($serializedArray) . '</pre>';
?>

</body>
</html>