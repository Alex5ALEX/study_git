<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Заполнение матрицы по спирали</title>
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
        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }
        td {
            border: 1px solid #ccc;
            padding: 10px;
            text-align: center;
            font-weight: bold;
        }
    </style>
</head>
<body>

<div class="container">
    <h1>Заполнение квадратной матрицы по спирали</h1>

    <?php
    function createSpiralMatrix($n) {
        $matrix = array_fill(0, $n, array_fill(0, $n, 0)); // Инициализация матрицы
        $value = 1; // Начальное значение
        $top = 0;   // Верхняя граница
        $bottom = $n - 1; // Нижняя граница
        $left = 0;   // Левая граница
        $right = $n - 1; // Правая граница

        while ($top <= $bottom && $left <= $right) {
            // Заполнение верхней строки
            for ($i = $left; $i <= $right; $i++) {
                $matrix[$top][$i] = $value++;
            }
            $top++;

            // Заполнение правого столбца
            for ($i = $top; $i <= $bottom; $i++) {
                $matrix[$i][$right] = $value++;
            }
            $right--;

            // Заполнение нижней строки, если еще не заполнена
            if ($top <= $bottom) {
                for ($i = $right; $i >= $left; $i--) {
                    $matrix[$bottom][$i] = $value++;
                }
                $bottom--;
            }

            // Заполнение левого столбца, если еще не заполнен
            if ($left <= $right) {
                for ($i = $bottom; $i >= $top; $i--) {
                    $matrix[$i][$left] = $value++;
                }
                $left++;
            }
        }

        return $matrix;
    }

    // Размер матрицы
    $n = 5; // Можно изменить размер матрицы
    $spiral_matrix = createSpiralMatrix($n);

    // Вывод матрицы
    echo "<table>";
    foreach ($spiral_matrix as $row) {
        echo "<tr>";
        foreach ($row as $cell) {
            echo "<td>$cell</td>";
        }
        echo "</tr>";
    }
    echo "</table>";
    ?>
</div>

</body>
</html>