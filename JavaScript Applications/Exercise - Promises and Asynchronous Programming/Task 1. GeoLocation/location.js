var btnMap = document.getElementById("showmap");
var mapContainer = document.getElementById("mapContainer");

btnMap.addEventListener("click", showMap);
// btnMap.onclick = showMap();

function showMap() {
    navigator.geolocation.getCurrentPosition(function success(pos) {
            var latitude = pos.coords.latitude;
            var longitude = pos.coords.longitude;

            var img = new Image();
            img.src = "https://maps.googleapis.com/maps/api/staticmap?center=" + latitude + "," + longitude + "&zoom=16&size=700x700&sensor=false";

            var imgElement = document.getElementById("map");

            imgElement.setAttribute("src", img.src);

        },

        function error(data) {
            mapContainer.innerHTML = "Your browser does not support geolocation.";
        });
}