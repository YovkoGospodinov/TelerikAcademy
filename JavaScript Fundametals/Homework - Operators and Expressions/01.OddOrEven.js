function solve(args) {
    var input = args[0] | 0;

    // var input = parseInt(args[0]);

    if (input % 2 === 0) {
        console.log("even " + input);
    } else {
        console.log("odd " + input);
    }
}

solve([3]);