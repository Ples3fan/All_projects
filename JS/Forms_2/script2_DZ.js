//1 Задине
let tarea = document.getElementById('tarea');
let button = document.getElementById('but');
let pol = document.getElementById('polu');
let kurs = document.getElementById('kurs');
let color = document.getElementById('color');
let colored = document.getElementById('colored');
let answer = document.getElementById('answer');

color.onclick = function(){
        colored.classList.remove('hidden');
}
let string = '';
let cvet ='black';
colored.onclick = function(tar){
     if(tar.target.name=='co'){
        cvet=event.target.value;
         console.log(cvet);
    }   
}
button.onclick = function(event){
    if(pol.checked){
        string ="<strong>" + tarea.value + "</strong>";
        answer.innerHTML=string;
        answer.style.color = cvet;
    }
    if(kurs.checked){
        string = "<i>" + tarea.value + "</i>";
        answer.innerHTML=string;
        answer.style.color = cvet;
    }
    if(pol.checked&&kurs.checked){
        string = "<i><strong>"+tarea.value+"</i></strong>";
        answer.innerHTML=string;
        answer.style.color = cvet;
    }
}
//2 Задание
let edu_options = document.edu_options,
    endPrice = document.getElementById('end_price'),
    tr = document.getElementsByTagName('tr'),
    trLen = tr.length,
    div = document.getElementsByClassName('price');
console.log(div[2].textContent);
function showPrice() {
    let sum = 0,
        price = [0, 0, 0, 0];
    for (let i = 1; i < trLen - 1; i++) {

            price[i] += +div[i-1].textContent;
            price[i] *= parseInt(edu_options.elements["edu_lang"+i].value);
            edu_options.elements["edu_price"+i].value = price[i];
            sum+= price[i];


    }
    endPrice.textContent = sum;
}
showPrice();

 

for(number of edu_options){
   if(number.type == 'number'){
       number.onchange = showPrice;
   }
}