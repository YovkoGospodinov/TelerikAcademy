function solve(args) {
    var arrayLength = +args[0];
    var array = args[1].split(" ").map(Number);
    var searchedNumber = +args[2];
    var count = 0;
    //debugger;
    for (var i = 0; i < arrayLength; i += 1) {
        var arrayElement = array[i];
        if (arrayElement === searchedNumber) {
            count += 1;
        }
    }

    return count;
}

//solve(["8 28 6 21 6 -7856 73 73 -56 73"]);