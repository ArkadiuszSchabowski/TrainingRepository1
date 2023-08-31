StartApp();

async function StartApp() {
    let urlApi = "https://danepubliczne.imgw.pl/api/data/synop/stationDiv?format=json"
    let response = await fetch(urlApi);
    let data = await response.json();

    let container = document.getElementById("container");

    data.forEach(function(el) {
        let station = el.stacja;
        let dateMeasurement = el.data_pomiaru;
        let hourMeasurement = el.godzina_pomiaru;
        let temperature = el.temperatura;

        // Tworzenie nowego diva dla każdego pomiaru
        let measurementDiv = document.createElement("div");
        measurementDiv.classList.add("forecastArray")
        measurementDiv.innerHTML = `
        <div>Stacja: ${station}</div>
        <div>Data pomiaru: ${dateMeasurement}</div>
        <div>Godzina pomiaru: ${hourMeasurement}</div> 
        <div>Temperatura: ${temperature}</div>`;

        container.appendChild(measurementDiv);
    })
}
