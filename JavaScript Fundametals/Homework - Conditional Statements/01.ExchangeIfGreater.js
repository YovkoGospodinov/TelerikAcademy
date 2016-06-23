function solve(args) {
    var a = parseFloat(args[0]);
    var b = parseFloat(args[1]);

    if (a > b) {
        console.log(b + " " + a);
    } else {
        console.log(a + " " + b);
    }
}