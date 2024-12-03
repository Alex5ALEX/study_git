<?php
function displayStrings() {
    // Определение строки с использованием синтаксиса одинарных кавычек
    $string_single = 'Это строка в одинарных кавычках.';
    $output = "<p>$string_single</p>";

    // Определение строки с использованием синтаксиса двойных кавычек
    $string_double = "Это строка в двойных кавычках.";
    $output .= "<p>$string_double</p>";

    // Определение строки с использованием heredoc-синтаксиса
    $string_heredoc = <<<EOD
    Это строка, определенная с использованием heredoc-синтаксиса.
    Она может занимать несколько строк.
    EOD;
    $output .= "<p>$string_heredoc</p>";

    return $output;
}

function displayArray() {
    // Создание массива из трех - пяти элементов
    $array = array("Первый элемент", "Второй элемент", "Третий элемент", "Четвертый элемент", "Пятый элемент");

    // Вывод массива с использованием echo (только строка)
    $output = "<p>Эхо первого элемента массива: {$array[0]}</p>";

    // Вывод массива с использованием print
    $output .= "<p>Печать второго элемента массива: {$array[1]}</p>";

    // Вывод массива с использованием print_r
    $output .= "<h2>Вывод массива с использованием print_r:</h2>";
    $output .= "<pre>";
    ob_start();
    print_r($array);
    $output .= ob_get_clean();
    $output .= "</pre>";

    // Вывод массива с использованием serialize
    $serialized_array = serialize($array);
    $output .= "<h2>Сериализованный массив:</h2>";
    $output .= "<p>$serialized_array</p>";

    return $output;
}
?>