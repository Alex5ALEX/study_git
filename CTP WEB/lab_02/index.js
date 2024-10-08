
function exercise_1(){
    var str = 'абвгдежзийклмнопрстуфхцчшщъыьэюя';
    var spliter = '-9-';
    var out = '';

    for(let i=0;i<str.length; i++){
        out = out + str[i] + spliter;
    }

    alert(out);
}


function exercise_2(){
    var str = '020916171821';
    let num_arr = new Array();


    var temp = '';
    for(let i=0;i<str.length; i++){
        temp += str[i];
        if(i%3===2){
            num_arr.push(parseInt(temp));
            temp = '';
        }
    }

    alert(num_arr.join(', '));

    let out = num_arr[0] * num_arr[1] + num_arr[2] % num_arr[3];

    alert(out);
}


function exercise_3(){

    var out = document.getElementById("text1");

    out.innerHTML = 'БИПРСУ';

}

function exercise_4(){
    let a =  2;
    let b = 9;
    let c = 16;
    let d = 17;
    let e = 18;
    let f = 21;



    let choi = confirm("y/n");

    var out = '';
    if (choi){
        out = (a - (b / (a * 2))) / (c ** 2);
    }
    else{
        out = (d / (e * f / 2)) + (d * e / f);
    }

    document.writeln(`<p> ${out}</p>`);
}






