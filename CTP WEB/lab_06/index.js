



function exercise_1(){
    var k = 2;
    var m = 5;
    var n = 4;

    var R = [3,7];

    for(let i =0;i < m;i++){
        R.unshift(i);
    }

    R.push("a");
    R.push("b");
    R.push("c");
    R.push("d");

    console.log(R);

}
//exercise_1();



function exercise_2(){

    var m = 3;
    var n = 6;

    var array = [];
    
    
    for (let i = 0; i < m; i++) {
        const row = [];
        for (let j = 0; j < n; j++) {
            row.push((Math.random()*10).toFixed(0));
        }
        array.push(row);
    }


    for (let i = 0; i < array.length; i++) {
        if (i % 2 === 0) { // Проверка на четный номер строки
            array[i].sort((a, b) => a - b); // Сортировка строки
        }
    }

    console.log(array)
}
//exercise_2();


function exercise_3(){
    var k = 6;
    var m = 8;

    var array = [k];
    
    for (let i = 0; i < k; i++) {
        array[i] = [];
        for (let j = 0; j < m; j++) {
            if (j % 2 === 0) {
                array[i].push(j); // числовые элементы
            } else {
                array[i].push(`text${j}`); // текстовые элементы
            }
        }
    }

    console.log("Array: \n");
    console.log(array);

    // Преобразуем числовые элементы в строки
    for (let i = 0; i < k; i++) {
        for (let j = 0; j < m; j++) {
            if (typeof array[i][j] === 'number') {
                array[i][j] = array[i][j].toString();
            }
        }
    }

    // Изменяем порядок следования элементов на обратный
    array.reverse();

    console.log("Array: \n");
    console.log(array);
}

//exercise_3();



function exercise_4(){
    let m = 6;
    let k = 7;
    let array = [];

    // Заполняем массив строками
    for (let i = 0; i < m; i++) {
        array[i] = `line${i + 1}`;
    }

    // Добавляем k - 4 строки в начало массива
    for (let i = 0; i < (k - 4); i++) {
        array.unshift(`newLine${i + 1}`);
    }

    // Удаляем m - 3 строки из конца массива
    for (let i = 0; i < (m - 3); i++) {
        array.pop();
    }


    console.log(array);
}
exercise_4();