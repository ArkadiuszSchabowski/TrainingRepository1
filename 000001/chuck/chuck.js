let chuckJoke = {
    apiUrl : "https://api.chucknorris.io/jokes/random",
  GetJoke: async function () {
    let response = await fetch(this.apiUrl);
    let data = await response.json();
    SetAndGetTable(data.value);
  },
};

function SetAndGetTable(data) {
  let contentDiv = document.getElementById("contentDiv");

  const divJoke = document.createElement("div");
  divJoke.classList.add("normal");
  divJoke.innerText = data;
  
  contentDiv.append(divJoke);
}
chuckJoke.GetJoke();

let btnNextJoke = document.getElementById("btnNextJoke");

btnNextJoke.addEventListener("click", function(){
    ClearJokeContent(contentDiv);
    chuckJoke.GetJoke();
});
function ClearJokeContent(contentDiv){
    contentDiv.innerHTML = "";
}