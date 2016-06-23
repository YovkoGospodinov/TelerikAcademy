function solve(args) {
    var firtsNumber = +args[0];
    var secondNumber = +args[1];
    var thirdNumber = +args[2];

    var discriminant = Math.pow(secondNumber, 2) - (4 * firtsNumber * thirdNumber);

    if (discriminant > 0) {
        var firstRealRoot = (-secondNumber + Math.sqrt(discriminant)) / (2 * firtsNumber);
        var secondRealRoot = (-secondNumber - Math.sqrt(discriminant)) / (2 * firtsNumber);
        if (firstRealRoot > secondRealRoot) {
            console.log(secondRealRoot + " " + firstRealRoot);
        } else {
            console.log(firtsNumber + " " + secondRealRoot);
        }
    } else if (discriminant === 0) {
        var realRoot = -(secondNumber / (2 * firtsNumber));
        console.log(realRoot);
    } else {
        console.log("no real roots");
    }
}