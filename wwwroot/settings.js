function Reload() {
    location.reload();
}

function GenerateMap(datos) {
    const tilesProvider = 'https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png'

    var map = L.map('myMap', {
        center: [18.735693, -70.162651],
        zoom: 8,
        layerGroup: [cities]
    });

    L.tileLayer(tilesProvider, {
        
    }).addTo(map);

    var littleton;
    var cities;

    for (var i = 0; i < datos.length; i++) {
        littleton = L.marker([datos[i].lat, datos[i].long]).bindPopup(
      `<b>Nombre:</b> <br>${datos[i].nombre} <br> <b>Descripcion:</b> <br>${datos[i].descripcion}<br> <b>Fecha:</b> <br>${datos[i].fecha}<br> <b>Valor:</b> <br>${datos[i].valor}</br>  <b>Peso:</b> <br>${datos[i].peso}</br> <b>URL:</b> <br>${datos[i].url}</br>`
        );
       
        cities = L.layerGroup([littleton]).addTo(map);
        
    }

          
}

