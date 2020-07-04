//1 Задание
let pic = document.getElementsByTagName('img')[0];
let cont = document.cont;
cont.onclick = function(event){
    console.log(event.target.name);
    if(event.target.name=='change'){
        pic.width=event.target.value;
        console.log(pic);
    }
}
//2 Задание
let but = document.getElementById('sing');
sing.onclick = function(){
    if(pass.value!=pass2.value){
        pass.style.borderColor = 'red';
        alert('Пароли не совпадают');
    }
    else
        alert('Сообщение отправленно на адрес:'+mail.value);
}
//3 Задание
let save = document.getElementById('save');
let answer = document.getElementById('answer');
let skil = document.getElementById('skil');
save.onclick = function(){
    console.log(document.main.Firstname.name); 
    console.log(document.main.length);
    for(let i=0;i<7;i++){
        if(document.main.elements[i].name!='gender')
          answer.insertAdjacentHTML('beforeEnd', '<tr><td>'+document.main.elements[i].name+'</td><td>'+document.main.elements[i].value+'</td></tr>'); 
        else
          if(document.main.elements[i].checked){
          answer.insertAdjacentHTML('beforeEnd', '<tr><td>'+document.main.elements[i].name+'</td><td>'+document.main.elements[i].value+'</td></tr>');              
          } 
    }
    answer.insertAdjacentHTML('beforeEnd','<tr><td>'+skil.textContent.slice(0,5)+'</td>')
    for(let j=7;j<15;j++){
        if(document.main.elements[j].checked){
            answer.insertAdjacentHTML('beforeEnd','<td>'+document.main.elements[j].value+' ');
        }
    }
    answer.insertAdjacentHTML('beforeend','<td></tr>');
}














