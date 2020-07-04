/*Создать html-страницу со списком ссылок. Ссылки на внешние источники (которые 
начинаются с http://) необходимо подчеркнуть пунктиром. Искать такие ссылки в 
списке и устанавливать им дополнительные стили необходимо с помощью JS. */
for (let e of Array.from(document.links)) {
    if (e.href.match(/^http?:/i))
        e.classList.add("dot")
}
/*Создать html-страницу с меню, которое имеет выпадающие списки. Список с 
элементами подменю должен появляться по щелчку на соответствующий элемент 
меню. */
var el = document.getElementsByClassName('menu-item');
for (var i = 0; i < el.length; i++) {
    el[i].addEventListener("click", showSub, false);
    el[i].addEventListener("mouseleave", hideSub, false);
}

function showSub(e) {
    if (this.children.length > 1) {
        this.children[1].style.display = "block";
    } else {
        return false;
    }
}

function hideSub(e) {
    if (this.children.length > 1) {
        this.children[1].style.display = "none";
    } else {
        return false;
    }
}
/*Создать html-страницу с кнопкой Like, при нажатии на которую увеличивается счетчик 
лайков*/
Array.prototype.forEach.call(document.querySelectorAll('.button'), function (v) {
    v.addEventListener('click', inc);
})

function inc() {
    var input = this.children.item(1);
    input.textContent = ((parseInt(input.textContent) + 1).toString());
}
/*Создать html-страницу с блоками информации, которые открываются по щелчку на 
заголовок. В один момент времени может быть развернут только один блок 
информации.*/
var title1 = document.getElementsByClassName('text');

for (let i = 0; i < title1.length; i++) {
    title1[i].onclick = function () {
            let active = document.querySelector('.active');
            active.classList.remove('active');
            this.classList.add('active');
            active.nextElementSibling.classList.add('hidden');
            this.nextElementSibling.classList.remove('hidden');
    }
};

