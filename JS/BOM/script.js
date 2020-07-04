let mas = ["https://www.youtube.com/embed/2Dpj7MXoFC4","https://www.youtube.com/embed/K6-QcsI5798","https://www.youtube.com/embed/6HTVN-Cxa8Y", "https://www.youtube.com/embed/me4FZy9wOaQ","https://www.youtube.com/embed/-e_3Cg9GZFU","https://www.youtube.com/embed/8soWgePuT0E","https://www.youtube.com/embed/CLuoNrkO8mg","https://www.youtube.com/embed/L1vAQztojfw"];

//<iframe width="560" height="315" src="https://www.youtube.com/embed/2Dpj7MXoFC4" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>

let easy = document.getElementById('easy');
let frame = document.getElementById('frame');
let cont = document.getElementById('cont');
console.log(screen.availWidth);
console.log(screen.availHeight);
let wid = ((screen.availWidth)/4)-8;
let hei = ((screen.availHeight)/2)-60;
let widMas = [0,wid,wid*2,wid*3,0,wid,wid*2,wid*3];
let heiMas = [0,0,0,0,hei,hei,hei,hei];
console.log(wid);
console.log(hei);
console.log(widMas);
console.log(heiMas);
easy.onclick = function(event){

    for(let i=0;i<mas.length;i++){
     window.open(mas[i], 'wind'+i,"top="+heiMas[i]+", left="+widMas[i]+", width="+wid+", height="+hei+", scrollbars=yes, resizable=yes");
        console.log(mas[i]);
    }
} 
let fr =0;
frame.onclick = function(event){
    for(let i=0;i<mas.length;i++){
        fr = document.createElement('iframe');
        fr.src = mas[i];
        console.log(fr);
        cont.appendChild(fr);
    }
}