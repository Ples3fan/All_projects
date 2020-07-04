let ficha = fetch('https://jsonplaceholder.typicode.com/posts?userId=2');
let main = document.getElementsByClassName('jumbotron')[0];
console.log(main);
loaderImg = new Image();
loaderImg.src = "images/loader.webp";
loadingBlock.append(loaderImg); 

let mainContent='';
function imgLoad(url){
    console.log(url);
    ficha.then(response =>{
       return response.json();
    }).then(posts =>{
          posts.forEach(post => { 
mainContent+=`<h6 class="display-3">${posts.id}</h6>
        <p class="lead">${posts.title}</p>
        <hr class="my-4">
        <p>${posts.body}</p>
        <p class="lead">
            <a class="btn btn-primary btn-lg" href="#" role="button">Learn more</a>
        </p>`
    });
    main.innerHTML = mainContent;
    main.classList.remove('hidden');
    loaderImg.remove();
    })
}
setTimeout(imgLoad, 3000);