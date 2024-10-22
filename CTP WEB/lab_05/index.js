function print_list(list) {
  if (typeof list != typeof []) {
    console.log("ERROR");
    return;
  }

  var out = "";
  for (let i = 0; i < list.length; i++) {
    out += list[i] + " ";
  }
  console.log(out);
}

function exercise_1() {
  var list = [];
  var len = 14;

  for (let i = 0; i < len; i++) {
    list.push((1 - Math.tan(Math.random() * 100)).toFixed(2));
  }

  print_list(list);

  list.sort();
  list.reverse();

  print_list(list);
}
//exercise_1();

function exercise_2() {
  var time = Date.parse(new Date());
  console.log(time);

  const date = new Date().getTime();
  time = Math.floor(date / 1000);
  console.log(`количество секунд от 01.01.1970 г. по текущий момент : ${time}`);

  //день рождения
  const day = new Date(2005, 7, 3, 14, 31);
  const dayNumber = day.getDay(); // Получаем номер дня недели (0 - воскресенье, 6 - суббота)

  console.log(dayNumber);
  day.get;
  // Массив с названиями дней недели
  const daysOfWeek = [
    "Воскресенье",
    "Понедельник",
    "Вторник",
    "Среда",
    "Четверг",
    "Пятница",
    "Суббота",
  ];
  const dayName = daysOfWeek[dayNumber];

  console.log(`Номер дня: ${dayNumber}, Название дня: ${dayName}`);
  console.log(`Час: ${day.getHours()}, Минута: ${day.getMinutes()}`);
}
exercise_2();

function exercise_3() {
  var BasisSide = 10;
  var Height = 15;

  var volume = (1 / 3) * Math.pow(BasisSide, 2) * Height;

  console.log(`объем пирамиды : ${volume}`);
}

exercise_3();
