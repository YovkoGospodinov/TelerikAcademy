function solve(args) {
    var n = +args[0];
    var maxDivisor = Math.sqrt(n);
    var result;

    //debugger;
    for (var i = n; i > 1; i -= 1) {
        var isPrime = true;
        result = i;
        for (var j = 2; j <= maxDivisor; j += 1) {
            if (result % j === 0) {
                isPrime = false;
                break;
            }
        }
        if (isPrime) {
            break;
        }
    }
    return result;
    //console.log(result);
}

//solve([126]);