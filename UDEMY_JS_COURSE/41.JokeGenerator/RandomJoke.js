let btn = document.getElementById("btn");

btn.addEventListener("click", async function(){
    let urlapi = "https://api.chucknorris.io/jokes/random";
    let response = await fetch(urlapi);
    let data = await response.json();
    let joke = data.value;
    console.log(joke);

    GetJokeInDiv(joke);
});
function GetJokeInDiv(joke){
    let divContent = document.getElementById("jokeTable");
    divContent.classList.add("place");
    divContent.innerHTML = joke;
}