/*Задание 1: Использование свойства event.target
Создайте список из 5-6 любых пословиц или цитат.
При клике на любом элементе этого списка пословица должна быть выведена
в div-е, расположенном ниже списка, но буквы должны идти в обратном
порядке.
Важно: решение должно быть с использованием свойства event.target.
Обработчик события назначается для элемента ul, а не для каждого li.
Подсказка: используйте методы для работы со строками.*/
let main = document.getElementById('main');
let div = document.getElementById('red');
console.log(main);

main.onclick = function (event) {
        console.log(event.target.closest('li'));
        let temp = event.target.closest('li').textContent.split(' ');
        for (let i = 0; i < temp.length; i++) {
            temp[i] = temp[i].split('').reverse().join('');
        }
        console.log(temp);
        div.textContent = temp.reverse().join(' ');
    }
    /*Задание 2
    Создать html-страницу с текстом и палитрой цветов. При клике на цвет
    палитры, должен изменяться цвет текста на выбранный. Для указания, какой
    ячейке какой цвет соответствует, можно использовать атрибут data-color в
    каждой ячейке, а потом с помощью JS получать необходимый цвет из этого
    атрибута*/
let cont = document.getElementById('container');
let lor = document.getElementById('lorem');

cont.onclick = function (event) {
    console.log(event.target.closest('div'));
    let temp = event.target.closest('div').style.background;
    console.log(temp);
    lor.style.color = temp;
}
