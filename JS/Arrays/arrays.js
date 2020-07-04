/*Задание 1
Создать массив «Список покупок». Каждый элемент массива
является объектом, который содержит название продукта, необходимое количество и куплен или нет. Написать несколько функций для работы с таким массивом.
1. Вывод всего списка на экран таким образом, чтобы сначала
шли некупленные продукты, а потом – купленные.
2. Добавление покупки в список. Учтите, что при добавлении
покупки с уже существующим в списке продуктом, необходимо увеличивать количество в существующей покупке,
а не добавлять новую.
3. Покупка продукта. Функция принимает название продукта
и отмечает его как купленный.*/
//let size=+prompt("Введите количество покупок: ",3);
//let list=[];
//let x='';
//let y=0;
//let z=false;
//for(let i=0;i<size;i++){
//    x=prompt("Введите название продукта: ",'Яблоки');
//    y=+prompt("Введите количество: ",5);
//    confirm("Куплен?") ? z=true : z=false;
//    list[i]={
//        nameProduct: x,
//        countProduct: y,
//        chekProduct: z
//    }
//}
//function printArray(mas){
//    document.write('<ol start="1">');
//    for(let i=0; i<size;i++){
//        document.write('<li>' + mas[i].nameProduct+' '+mas[i].countProduct+' '+mas[i].chekProduct+ '</li>')
//    }
//    document.write('</ol>');
//    console.log(mas);
//}
//function sortArray(mas){
//    for(let i=1;i<size;i++){
//        let buf=mas[i];
//        let j=i-1;
//        while (j>=0 && buf.chekProduct<mas[j].chekProduct)
//            {
//                mas[j+1]=mas[j];
//                j--;
//            }
//        mas[j+1]=buf;
//    }
//    printArray(mas);
//}
//function addProduct(mas){
//    x=prompt("Введите название продукта: ",'Яблоки');
//    y=+prompt("Введите количество: ",5);
//    confirm("Куплен?") ? z=true : z=false;
//    let item={
//        nameProduct: x,
//        countProduct: y,
//        chekProduct: z
//    }
//    let newMas=[];
//    for(let i=0;i<size;i++){
//        if(mas[i].nameProduct==item.nameProduct){
//            mas[i].countProduct+=item.countProduct;
//            newMas = mas;break;
//        }
//        else{
//           newMas = mas.push(item);break;
//        }
//    }
//    printArray(newMas);
//    return newMas;
//}
//function buyProduct(mas){
//   let x=prompt("Введите название продукта для покупки: ",'Яблоки');
//    for(let i=0;i<size;i++){
//        if(mas[i].nameProduct==x){
//            mas[i].chekProduct=true;
//        }
//    }
//    printArray(mas);
//}
//printArray(list);
//sortArray(list);
//addProduct(list);
//buyProduct(list);

/*Задание 2
Создать массив, описывающий чек в магазине. Каждый элемент массива состоит из названия товара, количества и цены за
единицу товара. Написать следующие функции.
1. Распечатка чека на экран.
2. Подсчет общей суммы покупки.
3. Получение самой дорогой покупки в чеке.
4. Подсчет средней стоимости одного товара в чеке.*/
//let sizeCheck=3;
//let listCheck=[];
//let x=['апельсин','мандарин','виски','фанта','мыло'];
//let x1=0;
//let y=0;
//let z=0.0;
//
//for(let i=0;i<sizeCheck;i++){
//    z=Math.random() * 500 + 50;
//    x1=(Math.floor(Math.random() * x.length));
//    listCheck[i]={
//        nameProd: x[x1],
//        countProd: Math.round(Math.random() * 5 + 1),
//        priceProd: z.toFixed(2)
//    }
//}
//console.log(listCheck);
//function printArray(mas){
//    let sum=0;
//    document.write('<ol start="1">');
//    for(let i=0; i<sizeCheck;i++){
//        document.write('<li>' + mas[i].nameProd+', кол-во: '+mas[i].countProd+', стоимостью: '+mas[i].priceProd+ ' грн</li>')
//        sum+=(mas[i].priceProd*mas[i].countProd);
//    }
//    document.write('</ol>');
//    document.write('<b style="margin-left: 135px;"> Итого к оплате: '+sum.toFixed(2)+' грн</b>')
//    console.log(mas);
//}
//function maxPrice(mas){
//    let max=(mas[0].countProd*mas[0].priceProd);
//    let buf=0;
//    let pos=0;
//    for(let i=1;i<sizeCheck;i++){
//        buf=(mas[i].countProd*mas[i].priceProd);
//        if(buf>max){
//           max=buf;
//           pos=i; 
//        }
//        buf=0;
//    }
//    document.write('<p> Самая дорогая позиция в чеке: '+'<b>'+mas[pos].nameProd.toUpperCase()+'</b>'+' общей стоимостью: '+max+' грн</p>')
//}
//function svgPrice(mas){
//    let sum=0;
//    let count=0;
//        for(let i=0; i<sizeCheck;i++){
//        count+=mas[i].countProd;
//        sum+=(mas[i].priceProd*mas[i].countProd);
//    }
//    sum/=count;
//    document.write('<p> Средняя стоимость одного товара в чеке = '+sum.toFixed(2)+' грн</p>')
//}
//printArray(listCheck);
//maxPrice(listCheck);
//svgPrice(listCheck);
/*Задание 3
Создать массив css-стилей (цвет, размер шрифта, выравнивание, подчеркивание и т. д.). Каждый элемент массива – это объект, состоящий из двух свойств: название стиля и значение стиля.
Написать функцию, которая принимает массив стилей и
текст, и выводит этот текст с помощью document.write() в тегах
<p></p>, добавив в открывающий тег атрибут style со всеми стилями, перечисленными в массиве. */
//let styles=[
//    {nameStyle:'colorred',style:' style="color: red; font-size: 26pt; align-items: center; text-decoration: underline;"'},
//    {nameStyle:'colorgreen',style:' style="color: green; font-size: 26pt; align-items: center; text-decoration: underline;"'}    
//];
//
//function docWrite(mas, nameOfStyle, text){
//    let zy='';
//    mas.forEach((item)=>{
//        if(item.nameStyle==nameOfStyle){
//            zy='<p'+item.style+'>'+text+'</p>';
//            console.log(zy);
//            document.write(zy);
//        }
//    });
//}
//console.log(styles);
//docWrite(styles,'colorred','Hello world!!!!!');

/*Задание 4
Создать массив аудиторий академии. Объект-аудитория состоит из названия, количества посадочных мест (от 10 до 20) и 
названия факультета, для которого она предназначена. 
Написать несколько функций для работы с ним.
1.  Вывод на экран всех аудиторий. 
2.  Вывод на экран аудиторий для указанного факультета.
3.  Вывод на экран только тех аудиторий, которые подходят для 
переданной группы. Объект-группа состоит из названия, 
количества студентов и названия факультета. 
4.  Функция сортировки аудиторий по количеству мест.
5.  Функция сортировки аудиторий по названию (по алфа- 
виту).*/
let auditores=[
    {nameAuditory:'Asdasda', countMest: 13, nameFak: 'Fghtf asfg'},
    {nameAuditory:'trjfgj', countMest: 17, nameFak: 'asdzxc tyuty'},
    {nameAuditory:'vcnnbm', countMest: 15, nameFak: 'jklhh qaad'}
];
function printArray(mas){
    document.write('<ol start="1">');
    for(let i=0; i<mas.length;i++){
        document.write('<li>' + mas[i].nameAuditory+' '+mas[i].countMest+' '+mas[i].nameFak+ '</li>')
    }
    document.write('</ol>');
    console.log(mas);
}
printArray(auditores);
function printArrayFak(mas, text){
    document.write('<ol start="1">');
    for(let i=0; i<mas.length;i++){
        if(mas[i].nameFak==text){
        document.write('<li>' + mas[i].nameAuditory+' '+mas[i].countMest+' '+mas[i].nameFak+ '</li>')            
        }
    }
    document.write('</ol>');
    console.log(mas);
}
printArrayFak(auditores, 'jklhh qaad');
const objGroup={nameGroup: '33aa00', countStud: '9', nameOfFak:'Fghtf asfg'};

function forGroup(mas, obje){
    document.write('<ol start="1">');
    for(let i=0; i<mas.length;i++){
        if(mas[i].nameFak==obje){
        document.write('<li>' + mas[i].nameAuditory+' '+mas[i].countMest+' '+mas[i].nameFak+ '</li>')            
        }
    }
    document.write('</ol>');
    console.log(mas);   
}
forGroup(auditores, objGroup.nameOfFak);
function sortArrayMest(mas){
    for(let i=1;i<mas.length;i++){
        let buf=mas[i];
        let j=i-1;
        while (j>=0 && buf.countMest<mas[j].countMest)
            {
                mas[j+1]=mas[j];
                j--;
            }
        mas[j+1]=buf;
    }
    printArray(mas);
}
sortArrayMest(auditores);