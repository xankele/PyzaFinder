// deklaracja warstwy wektorowej zawierającej znaczniki (markery)
var layerMarkers;
// deklaracja tablicy zawierającej wszystkie markery (ToDo)
var arrMarkers = [];

// utwórz warstwę na przyjęcie znaczników (markerów)
function createMarkersLayer(id, layerName, displayInLayerSwitcher, setVisibility){
	layerMarkers = new OpenLayers.Layer.Markers(layerName);
	// przypisz identyfikator warstwy
	layerMarkers.id = id;
	// pokaż warstwę w oknie przełącznika warstw 
	layerMarkers.displayInLayerSwitcher = displayInLayerSwitcher;
	// pokaż warstwę na mapie 
	layerMarkers.setVisibility(setVisibility);
}

// funkcja tworząca pojedyncze znaczniki w warstwie wektorowej 'layerMarkers' 
// o atrybutach określonych w argumentach funkcji 
function createMarkers(id, lon, lat, markerFile, markerWidth, markerHeight, offsetX, offsetY,
												popupTitle, popupDescription, popupImage, popupImageCaption) {

	// konwertuj współrzędne geograficzne z układu odniesienia EPSG:4326 na EPSG:900913,
	var lonLat = new OpenLayers.LonLat(lon, lat).transform(epsg4326, epsg900913);
	// utwórz reprezentuję pary szerokość / wysokość
	var size = new OpenLayers.Size(markerWidth, markerHeight);
	// oblicz przesunięcie markera
	var offset = new OpenLayers.Pixel(offsetX, offsetY);
	// utwórz grafikę w oparciu o adres URL, o rozmiarze (size)
	// i przesunięciu punktu środkowego (offset))
	var icon = new OpenLayers.Icon(markerFile,size, offset);

	// utwórz klasę feature na podstawie danych geograficznych i graficznych
	var feature = new OpenLayers.Feature(layerMarkers, lonLat, {'icon': icon});
	// utwórz klasę 'popupClass', która będzie używana do tworzenia instancji nowego okna popup.
	feature.popupClass = OpenLayers.Class(OpenLayers.Popup.Anchored, {'autoSize': true});

	// utwórz znacznik (marker)
	var marker = feature.createMarker();
	// przypisz identyfikator znacznikowi
	marker.id = id;
	//https://stackoverflow.com/questions/11040312/how-to-remove-a-specific-marker-in-openlayer
	//identyfikator płaszczyzny (ToDo)
	marker.PlaneID = id;

	// rejestrowanie zdarzenie kliknięcia znacznika
	marker.events.register("click", marker, function(evt){

  var popupHtml=''
    popupHtml+='<div id="frameCloud">'
		popupHtml += '<h1>' + popupTitle + '</h1></a>'

    popupHtml+='<div id="foto">'
    popupHtml+='<img src="'+popupImage+'" alt="foto '+popupTitle+'"/><br>'

    popupHtml+='</div></div>'
	/*
		Definicja okna popup, które będzie utworzone po kliknięciu znacznika.
			• id						- identyfikator okna popup
			• lonlat				- położenie znacznika
			• contentHTML		- pełny tekst HTML określający styl i treść w oknie popup (dymku)
			• contentSize		- nie wiem co to jest
			• anchor				- obiekt, do którego zostanie zakotwiczone okno popup.
												• w MS Access dla anchor = null i plików graficznych "Centered" dymek
													otwiera się dokładnie w punkcie lonlat znacznika
													(po uwzględnieniu offsetX, offsetY), dla anchor = marker.icon
													okienko popup otwiera się na krawędzi znacznika,
												• w FireFox dla anchor = null okno popup otwiera się za pierwszym razem
													w zbyt małym rozmiarze (z paskami przewijania), dla anchor = marker.icon
													okno popup otwiera się prawidłowo.
			• closeBox 			- dla wartości true tworzony jest przycisk 'X' zamykający okno popup
		*/
		//var anchor = {'size': new OpenLayers.Size(0,0), 'offset': new OpenLayers.Pixel(-24, -24)};
		popup = new OpenLayers.Popup.FramedCloud(
																id = 'myFramedCloud',
																lonlat = marker.lonlat,
																contentSize = new OpenLayers.Size(0, 0),
																contentHTML = popupHtml,
																anchor = null, //marker.icon,
																closeBox = true);
		// dla exclusive = true, zamykane są inne otwarte okna popup
		map.addPopup(popup, exclusive = true); 
		OpenLayers.Event.stop(evt);
	});

	// rejestrowanie zdarzenia 'mouseover' nad znacznikiem
	// zmiana kursora myszy na 'rączkę'
	marker.events.register('mouseover', marker,  function(evt){
			feature.layer.div.style.cursor = "pointer";
			OpenLayers.Event.stop(evt);
	});

		// dodaj znacznik do warstwy
		layerMarkers.addMarker(marker);
		// dodaj znacznik do tablicy (ToDo)
		arrMarkers.push(marker);
		// dodaj warstwę znaczników do instancji mapy
		map.addLayer(layerMarkers);
	}

function fDrawMarkers(name, cord_x, cord_y, path2, grade) {
	// utwórz warstwę na przyjęcie znaczników (markerów)
	createMarkersLayer('dymki','Popup (dymki)', true, true)
	// współrzędne punktu
	var lon; var lat;
	// wielkość pliku graficznego i zarazem podkatalog plików graficznych
	var size=48;
	// ścieżka do plików graficznych "NotCentered")
	path = '../img/' + size.toString() + 'x' + size.toString() + '/';

	lat = cord_x; lon = cord_y //lat połnoc/połódnie lon wschod/zachod
		createMarkers(name, lon, lat, '../img/marker.png',
			size, size, -size / 2, -size,
			name,
			'ocena'+grade+'/10',
			'../img/pyzunia.png')
	// wycentruj mapę w/m współrzędnych środka, powiększ do skali zoomLevel
	fInitCenterMap(20.490818735899836, 53.77332128730482, 14);
}
