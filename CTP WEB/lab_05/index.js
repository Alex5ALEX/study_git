
function print_list(list){
    if(typeof(list) != typeof([])){
        console.log("ERROR");
        return;
    }

    var out = "";
    for(let i=0 ;i < list.length;i++){
        out += list[i] + " ";
    }
    console.log(out);
}




function exercise_1(){
    var list = []
    var len = 14;

    for (let i =0;i< len ;i++){
        list.push((1-Math.tan(Math.random() *100)).toFixed(3))
    }

    print_list(list);

    list.sort();
    list.reverse();

    print_list(list);

}



function exercise_2(){
    var time = Date.parse(new Date());
    console.log(time);

    const date = new Date().getTime();
    time = Math.floor(date / 1000);
    console.log(time);

    const birthday = new Date('1990-10-15'); // Замените на вашу дату рождения
    const dayNumber = birthday.getDay(); // Получаем номер дня недели (0 - воскресенье, 6 - суббота)

    console.log(dayNumber);

    // Массив с названиями дней недели
    const daysOfWeek = ['Воскресенье', 'Понедельник', 'Вторник', 'Среда', 'Четверг', 'Пятница', 'Суббота'];
    const dayName = daysOfWeek[dayNumber];

    console.log(`Номер дня: ${dayNumber}, Название дня: ${dayName}`);

}


//exercise_1();
exercise_2()
