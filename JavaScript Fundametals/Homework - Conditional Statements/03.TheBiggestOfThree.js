function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];

    if (a === 0 || b === 0 || c === 0) {
        console.log("0");
    } else if (a > 0 && b > 0 && c > 0) {
        console.log("+");
    } else if (a < 0 && b < 0 && c < 0) {
        console.log("-");
    } else if (a < 0) {
        if (b > 0 && c > 0) {
            console.log("-");
        } else {
            console.log("+");
        }
    } else if (b < 0) {
        if (a > 0 && c > 0) {
            console.log("-");
        } else {
            console.log("+");
        }
    } else if (c < 0) {
        if (a > 0 && b > 0) {
            console.log("-");
        } else {
            console.log("+");
        }
    }
}


// function solve(args){   
// var numbers = args.map(Number);
// return numbers;
// }