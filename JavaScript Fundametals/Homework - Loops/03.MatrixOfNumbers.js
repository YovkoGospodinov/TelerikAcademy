function solve(args) {
    var n = +args[0];

    for (var i = 1; i <= n; i += 1) {
        var result = "";

        for (var j = i; j <= n + i - 1; j += 1) {
            result += j + " ";
        }
        console.log(result);
    }
}

// solve([3]);