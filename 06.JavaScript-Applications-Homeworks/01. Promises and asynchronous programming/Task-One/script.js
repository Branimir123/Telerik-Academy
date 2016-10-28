(function() {
    let locationElement = document.getElementById("location-wrapper");

    function getGeolocationPositionPromise() {
        return new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition(
                (position) => {
                    resolve(position);
                },
                (error) => {
                    reject(error);
                });
        });
    }

    function parseLatAndLongCoords(geolocationPosition) {
        if (geolocationPosition.coords) {
            return {
                lat: geolocationPosition.coords.latitude,
                long: geolocationPosition.coords.longitude
            };
        } else {
            throw {
                message: "No coords element found",
                name: "UserException"
            };
        }
    }

    function createGeolocationImage(coordsObj) {
        let imgElement = document.createElement("img"),
            imgSrc = "http://maps.googleapis.com/maps/api/staticmap?center=" +
            coordsObj.lat + "," +
            coordsObj.long + "&zoom=13&size=500x500&sensor=false";

        imgElement.setAttribute("src", imgSrc);

        locationElement.appendChild(imgElement);
    }

    getGeolocationPositionPromise()
        .then(parseLatAndLongCoords)
        .then(createGeolocationImage);
}());
