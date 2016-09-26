var btnMap = document.getElementById("showmap");
var mapContainer = document.getElementById("mapContainer");

btnMap.addEventListener("click", showMap);

function showMap() {
    var myPromise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition(
            position => resolve(position),
            error => reject(error)
        );
    });

    function drawMap(pos) {
        var img = new Image();
        img.src = `https://maps.googleapis.com/maps/api/staticmap?center=${pos.latitude},${pos.longitude}&zoom=16&size=700x700&sensor=false`;

        var imgElement = document.getElementById("map");

        imgElement.setAttribute("src", img.src);

        return imgElement;
    }

    function parseCoordinates(data) {
        return {
            latitude: data.coords.latitude,
            longitude: data.coords.longitude
        };
    }

    function wait(time, imgElement) {
        return new Promise((resolve, reject) => {
            setTimeout(() => {
                resolve(imgElement);
            }, time);
        });
    }

    function fadeout(imgElement) {
        setInterval(() => {
            var opacity = imgElement.style.opacity || 1;
            console.log(opacity);
            if (imgElement.style.opacity <= 0) {
                imgElement.style.opacity = 1;
                clearInterval();
            }

            imgElement.style.opacity = opacity - 0.05;
        }, 100);
    }

    myPromise
        .then(parseCoordinates)
        .then(drawMap)
        .then((imgElement) => wait(3000, imgElement))
        .then(fadeout)
        .catch((error) => {
            mapContainer.innerHTML = error.message;
            alert(error.message);
        });
}