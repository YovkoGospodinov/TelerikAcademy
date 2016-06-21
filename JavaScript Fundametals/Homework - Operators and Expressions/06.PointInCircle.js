function solve(args) {
    var pointX = parseFloat(args[0]);
    var pointY = parseFloat(args[1]);
    var radius = 2;

    var distance = Math.sqrt(pointX * pointX + pointY * pointY);

    if (radius >= distance) {
        console.log("yes " + distance.toFixed(2));
    } else {
        console.log("no " + distance.toFixed(2));
    }
}