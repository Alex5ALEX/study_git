function exercise_1() {
  var m = 5;
  var n = 4;

  var R = [3, 7, 5];

  for (let i = 0; i < m; i++) {
    R.unshift(i + 1);
  }

  for (let i = 0; i < n; i++) {
    R.push("text" + (i + 1).toString());
  }

  console.log(R);
}
//exercise_1();

function exercise_2() {
  var m = 3;
  var n = 6;

  var array = [];

  for (let i = 0; i < m; i++) {
    var row = [];
    for (let j = 0; j < n; j++) {
      row.push(Math.floor(Math.random() * 100));
    }
    array.push(row);
  }

  for (let i = 0; i < array.length; i++) {
    if (i % 2 === 0) {
      array[i].sort((a, b) => a - b);
    }
  }

  console.log(array);
}
//exercise_2();

function print2DArray(array) {
  for (let i = 0; i < array.length; i++) {
    console.log(i + 1 + " : " + array[i].join(" | ")); // Вывод строки массива, элементы разделены "|"
  }
  console.log("\n\n\n");
}

function exercise_3() {
  var k = 6;
  var m = 8;

  var array = [];

  for (let i = 0; i < k; i++) {
    const row = [];
    for (let j = 0; j < m; j++) {
      // Случайно выбираем текстовый или числовой элемент
      if (Math.random() < 0.5) {
        row.push(Math.floor(Math.random() * 100)); // Число
      } else {
        row.push(`Text${Math.floor(Math.random() * 100)}`); // Текст
      }
    }
    array.push(row);
  }

  print2DArray(array);

  var transformedArray = array.map((row) => {
    return row.map((element) => {
      // Преобразуем число в строку
      return typeof element === "number"
        ? "text" + element.toString()
        : element;
    });
  });

  print2DArray(transformedArray);
}
//exercise_3();

function exercise_4() {
  var m = 6;
  var k = 7;

  var array = [];

  for (let i = 0; i < m; i++) {
    var row = [];
    for (let j = 0; j < k; j++) {
      row.push(Math.floor(Math.random() * 100));
    }
    array.push(row);
  }

  print2DArray(array);

  for (let i = 0; i < m; i++) {
    var row = [];
    for (let j = 0; j < k; j++) {
      row.push(Math.floor(Math.random() * 100));
    }
    array.unshift(row);
  }

  for (let i = 0; i < m - 3; i++) {
    array.pop();
  }

  print2DArray(array);
}
exercise_4();
