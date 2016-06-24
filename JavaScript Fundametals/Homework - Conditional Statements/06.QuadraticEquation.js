function solve(args) {
    var firtsNumber = +args[0];
    var secondNumber = +args[1];
    var thirdNumber = +args[2];

    var discriminant = Math.pow(secondNumber, 2) - (4 * firtsNumber * thirdNumber);

    if (discriminant > 0) {
        var firstRealRoot = (-secondNumber + Math.sqrt(discriminant)) / (2 * firtsNumber);
        var secondRealRoot = (-secondNumber - Math.sqrt(discriminant)) / (2 * firtsNumber);
        console.log("x1=" + Math.min(firstRealRoot, secondRealRoot).toFixed(2) + "; x2= " + Math.max(firstRealRoot, secondRealRoot).toFixed(2));

        // if (firstRealRoot > secondRealRoot) {

        //     console.log("x1=" + secondRealRoot.toFixed(2) + "; x2= " + firstRealRoot.toFixed(2));
        // } else {
        //     console.log("x1=" + firstNumber.toFixed(2) + "; x2= " + secondRealRoot.toFixed(2));
        // }
    } else if (discriminant === 0) {
        var realRoot = -(secondNumber / (2 * firtsNumber));
        console.log("x1=x2=" + realRoot.toFixed(2));
    } else {
        console.log("no real roots");
    }
}

// function solve(args){
//     var a = +args[0],
//         b = +args[1],
//         c = +args[2],
//         x1,
//         x2;

//     x1 = (b + (Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);
//     x2 = (b - (Math.sqrt(Math.pow(b, 2) - 4 * a * c))) / (2 * a);

//     if ((Math.pow(b, 2) - 4 * a * c) < 0 || a === 0){
//         console.log('no real roots');
//     }
//     else{
//         if ((Math.pow(b, 2) - 4 * a * c) === 0){
//             console.log('x1=x2=' + Number(x1).toFixed(2));
//         }
//         else if(x1 < x2){
//             console.log('x1=' + Number(x1).toFixed(2) + '; ' + 'x2=' + Number(x2).toFixed(2));
//         }
//         else{
//             console.log('x1=' + Number(x2).toFixed(2) + '; ' + 'x2=' + Number(x1).toFixed(2));
//         }
//     }
// }