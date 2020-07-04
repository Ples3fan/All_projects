console.log(document.documentElement);
console.log(document.body);
console.log(document.body.firstElementChild);
console.log(document.body.children[3]);
console.log(document.getElementsByClassName('google-list-item'));
console.log(document.querySelectorAll('ul>li'));
console.log(document.querySelector('a').href);
console.log(document.body.lastElementChild);
console.log(document.body.lastElementChild.previousElementSibling);
console.log(document.querySelector('span'));
console.log(document.documentElement.parentNode);

    
function rec(el){
    let childs = el.childNodes, i = childs.length;
    while(i--){

        if(el.nodeType === 1){
            rec( childs[i] );
        }
        console.log(childs[i]);
    }
}
console.log(rec(document.documentElement));