
async function StartApp(){
    let webApi = "http://api.nbp.pl/api/exchangerates/tables/a?format=json";
    let response = await fetch(webApi);
    let data = await response.json();
    CreateTable(data[0]);
}
StartApp();

function CreateTable(data){
 let contentDiv = document.getElementById("contentDiv");

    let date = data.effectiveDate;
    let rates = data.rates;

    contentDiv.innerHTML = "Tabela NBP: " + date;

    rates.forEach(function (el){
        console.log(el);
        let currency = el.currency; // Dolar amerykaski
        let code = el.code; // USD
        let mid = el.mid; //3.98

        let currentDiv = document.createElement("div");
        currentDiv.innerHTML =`
        <div>${currency}</div>
        <div>${code}</div>
        <div>${mid}</div>`

        contentDiv.append(currentDiv);
    })
}