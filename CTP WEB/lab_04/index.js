function exercise_1() {
  var lang = "бел";

  const daysOfWeek = {
    russian: [
      "понедельник",
      "вторник",
      "среда",
      "четверг",
      "пятница",
      "суббота",
      "воскресенье",
    ],
    english: [
      "Monday",
      "Tuesday",
      "Wednesday",
      "Thursday",
      "Friday",
      "Saturday",
      "Sunday",
    ],
    belarusian: [
      "панядзелак",
      "аўторак",
      "серада",
      "чацвер",
      "пятніца",
      "субота",
      "нядзеля",
    ],
    german: [
      "Montag",
      "Dienstag",
      "Mittwoch",
      "Donnerstag",
      "Freitag",
      "Samstag",
      "Sonntag",
    ],
  };

  var msv;
  switch (lang) {
    case "рус":
      msv = daysOfWeek.russian;
      break;
    case "англ":
      msv = daysOfWeek.english;
      break;
    case "бел":
      msv = daysOfWeek.belarusian;
      break;
    case "нем":
      msv = daysOfWeek.german;
      break;
  }

  var out = msv.join(", ");

  alert(out);
}


function exercise_2() {
  var str = "123abcde45";
  var k = 5;

  if (!isNaN(str[k - 1])) {
    alert(`Символ : ${k} в строке - число`);
  } else {
    alert(`Символ : ${k} в строке - не число`);
  }

  var iter = 0;
  for (let i = 0; i < str.length; i++) {
    if (!isNaN(str[i])) {
      iter += parseInt(str[i]);
    }
  }

  alert("Сумма чисел в строке : " + iter);
  if (iter % 2 == 0) {
    alert("Сумма чисел число четное");
  } else {
    alert("Сумма чисел число не четное");
  }
}

function exercise_3() {
  const inputDate = document.getElementById("dateInput").value;
  const date = new Date(inputDate);

  // Определение времени года
  const month = date.getMonth(); // Месяцы начинаются с 0
  let season;
  if (month === 11 || month === 0 || month === 1) {
    season = "Зима";
  } else if (month >= 2 && month <= 4) {
    season = "Весна";
  } else if (month >= 5 && month <= 7) {
    season = "Лето";
  } else {
    season = "Осень";
  }

  // Определение декады месяца
  const day = date.getDate();
  let decade;
  if (day >= 1 && day <= 10) {
    decade = "Первая декада";
  } else if (day >= 11 && day <= 20) {
    decade = "Вторая декада";
  } else {
    decade = "Третья декада";
  }

  // Определение месяца
  const monthNames = [
    "Январь",
    "Февраль",
    "Март",
    "Апрель",
    "Май",
    "Июнь",
    "Июль",
    "Август",
    "Сентябрь",
    "Октябрь",
    "Ноябрь",
    "Декабрь",
  ];
  const monthName = monthNames[month];

  // Определение високосного года
  const year = date.getFullYear();
  const isLeapYear = (year % 4 === 0 && year % 100 !== 0) || year % 400 === 0;

  // Вывод результатов
  const resultDiv = document.getElementById("result_3");

  resultDiv.innerHTML = `
        <p>Время года: ${season}</p>
        <p>Декада месяца: ${decade}</p>
        <p>Месяц: ${monthName}</p>
        <p>Високосный год: ${isLeapYear ? "Да" : "Нет"}</p>`;
}

function exercise_4() {
  const input = document.getElementById("numberInput").value;
  const numbers = input
    .split(",")
    .map((num) => parseFloat(num.trim()))
    .filter((num) => !isNaN(num));

  // Проверка: должен быть массив из 25 чисел
  if (numbers.length !== 25) {
    document.getElementById("result").innerHTML =
      "<p>Пожалуйста, введите ровно 25 чисел.</p>";
    return;
  }

  let sumEven = 0; // СЧЭ - сумма четных элементов
  let productOddIndices = 1; // ПЭНН - произведение элементов с нечетными номерами
  let sumMultiplesOfThree = 0; // СЭКЗ - сумма элементов, номера которых кратны трем
  let productOddNumbers = 1; // ПНЧЭ - произведение нечетных элементов
  let hasOddNumbers = false; // Флаг для проверки наличия нечетных чисел

  for (let i = 0; i < numbers.length; i++) {
    const number = numbers[i];

    // СЧЭ - сумма четных элементов
    if (number % 2 === 0) {
      sumEven += number;
    }

    // ПЭНН - произведение элементов с нечетными номерами (индексы 1, 3, 5, ...)
    if (i % 2 === 1) {
      productOddIndices *= number;
    }

    // СЭКЗ - сумма элементов, номера которых кратны трем
    if (i % 3 === 0) {
      sumMultiplesOfThree += number;
    }

    // ПНЧЭ - произведение нечетных элементов
    if (number % 2 !== 0) {
      productOddNumbers *= number;
      hasOddNumbers = true;
    }
  }

  // Условие для ПНЧЭ, если нечетных чисел нет
  if (!hasOddNumbers) {
    productOddNumbers = 0; // Или можно оставить 1, в зависимости от требований
  }

  // Вывод результатов
  const resultDiv = document.getElementById("result_4");
  resultDiv.innerHTML = `
        <p>СЧЭ (Сумма четных элементов): ${sumEven}</p>
        <p>ПЭНН (Произведение элементов с нечетными номерами): ${productOddIndices}</p>
        <p>СЭКЗ (Сумма элементов, номера которых кратны трем): ${sumMultiplesOfThree}</p>
        <p>ПНЧЭ (Произведение нечетных элементов): ${productOddNumbers}</p>
    `;
}
