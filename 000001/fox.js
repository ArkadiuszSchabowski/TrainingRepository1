async function StartApp() {
    let urlApi = "https://foxes.cool/counts/fox";
    let response = await fetch(urlApi);
    let data = await response.json();
    console.log(data);
}
StartApp();