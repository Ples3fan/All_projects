let xhr = new XMLHttpRequest();
let xhr2 = new XMLHttpRequest();
let divi = document.getElementsByClassName('btn-group-horizontal')[0];
let perem = document.getElementsByClassName('border-dark')[0];
let showPosts = document.getElementsByClassName('btn-lg')[0];
let cardio = document.getElementsByClassName('cardio')[0];
let butAll = null;
let tabi = document.getElementsByClassName('table-info');
let tabbody = document.getElementsByClassName('tabbody')[0];
let tdlist = document.getElementsByTagName('td');
console.log(showPosts);
//console.log(but);
xhr.open('GET', 'users.json', true);
xhr.onreadystatechange = function (event) {
    console.log(this.readyState);
    if (this.readyState === 4 && this.status === 200) {
        let dataARR = JSON.parse(this.responseText);
        console.log(dataARR);
        showUserList(dataARR);
    }
}
xhr.send(null);

xhr2.open('GET', 'posts.json', true);
xhr2.onreadystatechange = function (event) {
    console.log(this.readyState);
    if (this.readyState === 4 && this.status === 200) {
        let dataARR2 = JSON.parse(this.responseText);
        console.log(dataARR2);
        showUserPosts(dataARR2);
    }
}
xhr2.send(null);
let arr =[];
function showUserPosts(data) {
    let divItems = '';
    
        console.log(index);
        showPosts.onclick = function(event){
            console.log(event.target.closest('btn-outline-primary'));
            let heved = document.getElementsByClassName('haved')[0];
            for (index in data) {
//            for(let i=0;i<data.length;i++){
//                if(haved.dataset.id==data[index].userId)
                  divItems+='<div class="card border-dark mb-3" style="max-width: 20rem;">\
            <div class="card-header">'+data[index].title+'</div>\
            <div class="card-body">\
                <p class="card-text">'+data[index].body+'</p>\
            </div>\
        </div>'   
                
            }  
        cardio.classList.remove('hidden');
        perem.innerHTML = divItems;    
       } 

    //data-атрибуты???

}
function showUserList(data) {
    let divItemsBlock = '';
    for (index in data) {
        divItemsBlock += '<button type="button" class="btn btn-outline-primary m-2" data-username="' + data[index].username + '" data-address="' + data[index].address.city + ', ' + data[index].address.street +'" data-email="'+data[index].email+'" data-phone="'+data[index].phone+'" data-website="'+data[index].website+'"data-id="'+data[index].id+'">' + data[index].name + '</button>'
    }
    //data-атрибуты???
    divi.innerHTML = divItemsBlock;
   getBtnInfo()
}
function getBtnInfo(){
     butAll = document.getElementsByClassName('btn-outline-primary');
    for (but of butAll) {
        console.log(but);
        but.onclick = function (event) {
            console.log(this.dataset.address);
            this.classList.add('haved');
            console.log(this);
            let temp = [this.textContent,this.dataset.username, this.dataset.address, this.dataset.email, this.dataset.phone, this.dataset.website];
            console.log(temp);
            let tablet = document.getElementsByTagName('td');
            console.log(tablet);
            for(let i=0;i<tablet.length;i++){
                tablet[i].textContent = temp[i];
            }
            document.getElementsByClassName('table-hover')[0].classList.remove('hidden');
            document.getElementsByClassName('btn-primary')[0].classList.remove('hidden');
            
        }
    }
}
