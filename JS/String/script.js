/*Написать функцию, которая принимает строку и выводит
статистику о ней: количество букв, количество цифр и
количество других знаков.*/
function stringStatistic(str){
    var word=0;
    var digits=0;
    var symbols=0;
    var char;
for(var i=0; i < str.length; i++) {
    char = str.charAt(i);
    if (!isNaN(char * 1)){
        digits++;
    }
    else if("<>@!#$%^&*()_+[]{}?:;|'\"\\,./~`-=".indexOf(char) != -1) {
        symbols++;
    }
    else if (char == char.toUpperCase()) {
        word++;
    }
    else if (char == char.toLowerCase()){
        word++;
    }
}
    document.write('<p>Количество цифр = '+digits+'</p>');
    document.write('<p>Количество букв = '+word+'</p>');
    document.write('<p>Количество символов = '+symbols+'</p>')
}
stringStatistic('Qqw#er!ty123|45');
/*Написать функцию, которая принимает двузначное число
и возвращает его в текстовом виде.
Например: 35 – тридцать пять, 89 – восемьдесят девять,
12 – двенадцать*/
function textNumber(number) {
  let first = ['Один', 'Два', 'Три', 'Четыре', 'Пять', 'Шесть', 'Семь', 'Восемь', 'Девять'];
  let second = ['Десять', 'Одинадцать', 'Двенадцать', 'Тринадцать', 'Четырнадцать', 'Пятнадцать', 'Шестнадцать', 'Семьнадцать', 'Восемьнадцать', 'Девяднадцать', 'Двадцать'];
  let third = ['Двадцать', 'Тридцать', 'Сорок', 'Пятьдесят', 'Шестьдесят', 'Семьдесят', 'Восемьдесят', 'Девяносто'];
  if (number > 0 && number <= 9) {
    return first[number - 1];
  }
  if (number >= 10 && number <= 20) {
    return second[number - 10];
  }
  if (number > 20 && number <= 99) {
    let str = `${number}`;
    str = str.split('');
    let firstNumber = str[0];
    let secondNumber = str[1];
    return `${third[firstNumber - 2]} ${first[secondNumber - 1]}`;
  }
}
//alert(textNumber(77));
//alert(textNumber(20));
//alert(textNumber(55));
/*Написать функцию, которая заменяет в полученной строке
большие буквы на маленькие, маленькие – на большие, а
цифры – на знак нижнего подчеркивания. */
function change_register(str) {
var new_str = "";
var len = str.length;
  for (var i = 0; i < len; i++) {
    if (str[i] === str[i].toLowerCase()) {
      new_str += str[i].toUpperCase();
    } 
    else {
      new_str += str[i].toLowerCase();
    }
  }
  document.write('<p>'+new_str.replace(/\d/g,'_')+'</p>');
}
change_register('QuNtanamo156');
/*Написать функцию, которая преобразует названия cssстилей с дефисом в название в СamelСase стиле: font-size
в fontSize, background-color в backgroundColor, textalign в textAlign*/
function camelize(str) {
  return str.split('-').map(
      (word, index) => index == 0 ? word : word[0].toUpperCase() + word.slice(1)).join('');
}
document.write('<p>'+camelize('font-size')+'</p>');
/*Написать функцию, которая принимает словосочетание
и превращает его в аббревиатуру.
Например: cascading style sheets в CSS, объектноориентированное программирование в ООП. */
function abreviature(str){
  return str.match(/\b(\w)/g).join('').toUpperCase();
}
document.write('<p>'+abreviature('cascading style sheets')+'</p>');
/*Написать функцию, которая принимает любое количество строк, объединяет их в одну длинную строку и
возвращает ее. */
function PVA(str){
    return str.split(' ').join('');
}
document.write('<p>'+PVA('В лесу родилась елочка в лесу она жила')+'</p>');
/*Написать функцию – калькулятор. Функция принимает
строку с примером, определяет, какое действие необходимо
выполнить (+ - * /), переводит операнды в числа, решает
пример и возвращает результат*/
function Calculator(str) {

    let splite = str.split(' ');
     var a = +splite[0];
     let op = splite[1];
     var b = +splite[2];
    var res=0;
    if(op=='*'){
        res=a*b;
    }
    if(op=='/'){
        res=a/b;
    }
    if(op=='+'){
        res=a+b;
    } 
    if(op=='-'){
        res=a-b;
    }
    return res;
  }
document.write('<p>'+Calculator('12 + 15')+'</p>');
/*Написать функцию, которая получает url и выводит подробную информацию о нем.
Например: url “https://itstep.org/ua/about”, информация
“протокол: https, домен: itstep.org, путь: /ua/about”*/
function domen(str){
    let temp=str.split('/');
    let t='/';
   console.log(temp[0].substr(1,(temp[0].length-2)));
for (let i=3;i<temp.length;i++){
    t+=(temp[i]+'/');
    }
    (t.substr(0,(t.length-1)));
    console.log(temp);
    document.write('<p>Протокол: '+temp[0].substr(0,(temp[0].length-1))+'<p>');
    document.write('<p>Домен: '+temp[2]+'</p>');
    document.write('<p>Путь: '+t.substr(0,(t.length-1))+'</p>');
}
domen('https://itstep.org/ua/about');

