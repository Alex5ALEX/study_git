

function exercise_1(){
    var lang="бел";

    const daysOfWeek = {
        russian: ["понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресенье"],
        english: ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"],
        belarusian: ["панядзелак", "аўторак", "серада", "чацвер", "пятніца", "субота", "нядзеля"],
        german: ["Montag", "Dienstag", "Mittwoch", "Donnerstag", "Freitag", "Samstag", "Sonntag"]
    };

    var msv;
    switch (lang){
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

    var out = "";
    for(let i =0;i < msv.length;i++){
        out += msv[i] + ", ";
    }
    alert(out);
}
//exercise_1();


function stringOrNumber(str) {
    if (isNaN(str)) {
      return "string";
    } else {
      return "number";
    }
  }


function exercise_2(){
    var str = "123abcde45";
    var k = 5;


    if(!isNaN(str[k-1])){
        alert(`Символ : ${k} в строке - число`);
    } else{
        alert(`Символ : ${k} в строке - не число`);
    }

    var iter = 0;
    for(let i =0; i < str.length;i++){
        if(!isNaN(str[i])){
            iter += parseInt(str[i]);
        }
    }

    alert("Сумма чисел в строке : " + iter);
    if(iter %2 == 0){
        alert("Сумма чисел число четное");
    }else{
        alert("Сумма чисел число не четное");
    }


}
//exercise_2();



function exercise_3(){

}

exercise_3();
