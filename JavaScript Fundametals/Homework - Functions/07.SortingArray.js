function solve(args) {
    var arrayLength = +args[0];
    var array = args[1].split(" ").map(Number);

    var sortedArray = array.sort(function(a, b) {
        return a - b;
    });

    return sortedArray.join(" ");
}

//solve(['6\n3 4 1 5 2 6']);
//solve(['10\n36 10 1 34 28 38 31 27 30 20']);