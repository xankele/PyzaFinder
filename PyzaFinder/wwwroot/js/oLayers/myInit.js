	// zmienne publiczne OpenLayers
	var map = null;
	// odwołania do klas przekształcających współrzędne pomiędzy systemami odniesienia
	var epsg4326 = new OpenLayers.Projection("EPSG:4326");
	var epsg900913 = new OpenLayers.Projection("EPSG:900913");

//  Funkcja init() wyświetla zdefiniowaną mapę OSM lub UMP w bloku <div id = 'basicMap'>,
function init() {
	// ustaw przykładowe opcje instancji mapy
	var options = {
				units:'m',
				minResolution: 'auto',
				maxResolution: 'auto',
			// utwórz kontrolki nawigacyjne, informacyjne i sterujące instancji mapy
			controls: [
				// zminimalizowane okno przełącznika warstw;
				// niebieski przycisk (+) w prawym górnym rogu
				//--layerSwitcher = new OpenLayers.Control.LayerSwitcher({'ascending':true}),
				// umożliwia nawigacje po mapie za pomocą myszy
				new OpenLayers.Control.Navigation(),
				// elementy nawigacyjne w lewym górnym rogu,
				// strzałki lewa, prawa, dół, góra, powiększenie '+/-'
				//new OpenLayers.Control.PanZoom(),
				// elementy nawigacyjne w lewym górnym rogu j.w. plus pionowy suwak zmiany powiększenia,
				//--new OpenLayers.Control.PanZoomBar(),
				// umożliwia  przewijanie i powiększanie mapy za pomocą klawiatury
				new OpenLayers.Control.KeyboardDefaults(),
				// zminimalizowane okno mini-mapy, która umożliwia szybką nawigację;
				// niebieski przycisk (+) w dolnym prawym rogu 
				//--new OpenLayers.Control.OverviewMap(),

				// Dodatkowe 2 przyciski pod PanZoomBar
				// Nieaktualne w wersji 2.4, usunięte w wersji 3.0.
				//new OpenLayers.Control.MouseToolbar(),

				// liniowy wskaźnik bieżącego powiększenia mapy; w lewym dolnym rogu mapy,
				//--new OpenLayers.Control.ScaleLine({geodesic: true}),
				// bezpośredni odnośnik do mapy startowej: link w prawym dolnym rogu
				//--new OpenLayers.Control.Permalink('permalink'),
				// aktualne współrzędne geograficzne punktu pod kursorem myszy;
				//--new OpenLayers.Control.MousePosition({displayProjection: epsg4326}),
				// dolny prawy róg - prawa autorskie OSM, (nie działa w ver. 2.11)
				//--new OpenLayers.Control.Attribution()
		]
	};

	// utwórz nowy obiekt typu Map w kontenerze HTML (tutaj <div id="basicMap">)
	map = new OpenLayers.Map("basicMap", options);
	// utwórz nową warstwę 'layerOSM' odwołującą się darmowej mapy OpenStreetMap
	var layerOSM = new OpenLayers.Layer.OSM("Mapa OSM");
	// dodaj utworzoną warstwę do obiektu map
	map.addLayer(layerOSM);

	// w podobny sposób możemy utworzyć nową warstwę odwołującą się darmowej mapy UMP-pcPL
	var layerUMP = new OpenLayers.Layer.OSM("Mapa UMP", 
								"http://1.tiles.ump.waw.pl/ump_tiles/${z}/${x}/${y}.png")

	// dodaj utworzoną warstwę do obiektu map
	map.addLayer(layerUMP);

	fInitDrawTrack('MarTrack','ślad Marysin','gpx/trackMarysin.gpx','#00b',3,.6,'solid',true,true);
	fDrawMarkers();
}

	// Funkcja centrująca wyświetlaną mapę:
	// • centerLon, centerLat - współrzędne środka mapy w układzie odniesienia EPSG:900913,
	//													format używany m.in. przez OpenStreetMap, Google Maps,
	//														Bing Maps, Yahoo!Maps.
	// • zoomLevel 						- początkowe powiększenie mapy

	function fInitCenterMap(centerLon, centerLat, zoomLevel){
	// konwertuj współrzędne środka mapy z układu odniesienia EPSG:4326 na EPSG:900913,
	// wycentruj mapę w/m współrzędnych środka, powiększ do skali zoomLevel
	var point = new OpenLayers.LonLat(centerLon, centerLat);
	map.setCenter(point.transform(epsg4326,epsg900913), zoomLevel);
	}

/*
	Funkcja rysująca na mapie ślad (track) GPX o atrybutach przekazanych w argumentach
	===================================================================================
	• id											- identyfikator warstwy
	• nameLayer								- nazwa warstwy
	• fileGpx									- ścieżka do pliku *.gpx
	• strokeColor							- kolor pędzla
	• strokeWidth							- szerokość pędzla
	• strokeOpacity						- przezroczystość pędzla w zakresie 0÷1 (1 -nieprzezroczysty)
	• strokeDashstyle					- styl linii (solid, dot, dash, dash, dashdot, longdash, longdashdot, 
	• displayInLayerSwitcher	- dla true wyświetla nazwę warstwy w oknie przełącznika warstw
	• setVisibility						- dla wartości true narysowany ślad będzie widoczny na mapie
*/

function fInitDrawTrack(id, nameLayer, fileGpx, strokeColor, strokeWidth, strokeOpacity,
												strokeDashstyle, displayInLayerSwitcher, setVisibility){
	// utwórz nową warstwę wektorową o nazwie 'nameLayer'
	// w celu przetworzenia pliku 'fileGpx'
	var layerGpx = new OpenLayers.Layer.Vector(nameLayer, {
		// utwórz prostą podklasę strategii
		strategies: [new OpenLayers.Strategy.Fixed()],
		// utwórz nową instancję protokołu HTTP
		protocol: new OpenLayers.Protocol.HTTP({
			url: 'gpx/trackMarysin.gpx',
			// utwórz parser GPX, by przetworzyć plik *.gpx
			format: new OpenLayers.Format.GPX()
		}),
			style: {
				// użyj pędzla
				stroke:true,
				// kolor linii
				'strokeColor': strokeColor,
				// szerokość pędzla w pikselach
				'strokeWidth': strokeWidth,
				// stopień krycia pędzla (nieprzezroczystość)
				strokeOpacity: strokeOpacity,
				// styl linii (ciągła)
				'strokeDashstyle': strokeDashstyle
			}
	});
	// przypisz identyfikator warstwy
	layerGpx.id = id; 
	// pokaż warstwę w oknie przełącznika warstw 
	layerGpx.displayInLayerSwitcher = displayInLayerSwitcher;
	// pokaż warstwę na mapie 
	layerGpx.setVisibility(setVisibility);

	// dodaj utworzoną warstwę do obiektu map 
	map.addLayer(layerGpx);
}
