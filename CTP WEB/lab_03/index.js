

function exercise_1(){
    var num = -487.6511234;

    num = Math.abs(num);

    alert(num);

    num = num.toFixed(3);

    alert(num);
}

//exercise_1();





function exercise_2(){
    var num = 5;
    var list = [];

    for(let i=0; i < num; i++){
        list.push((Math.random() * 1000).toFixed(3))
    }

    var list_out = "";
    var num_out = 0;
    for(let i=0; i < list.length ;i++){
        list_out += list[i] + "  ";
        num_out += Math.sqrt(list[i]);
    }

    alert(list_out);
    alert(num_out);
}

exercise_2();