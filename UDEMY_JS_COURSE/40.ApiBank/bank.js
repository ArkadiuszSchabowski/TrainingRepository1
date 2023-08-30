StartApp();

async function StartApp() {
  let urlApi = "http://api.nbp.pl/api/exchangerates/tables/a?format=json";
  let response = await fetch(urlApi);
  let data = await response.json();

  ProcessData(data[0]);
}

function ProcessData(data) {
  let name = data.table;
  let number = data.no;
  let date = data.effectiveDate;
  let rates = data.rates;

  let dateSpan = document.getElementById("date");
  dateSpan.innerHTML = number + " - " + date;

  rates.forEach(function (el) {
    let currency = el.currency; //dolar amerykański
    let code = el.code; //USD
    let mid = el.mid; // 4.11

    AddRateContent(currency, code, mid);
  });
}

function AddRateContent(currency, code, mid) {
  let dataTable = document.getElementById("dataTable");

  let el = document.createElement("div");
  el.classList.add("rate");
  el.innerHTML = `
  <div> ${currency} </div>
  <div> ${code} </div>
  <div> ${mid} </div>
  `;

  dataTable.append(el);
}
