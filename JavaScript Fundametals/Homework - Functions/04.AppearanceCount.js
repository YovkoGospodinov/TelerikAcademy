function solve(args) {
    var input = args[0].split("\n");
    var arrayLength = +input[0];
    var array = input[1].split(" ").map(Number);
    var searchedNumber = +input[2];
    var count = 0;
    // debugger;
    for(var i = 0; i < arrayLength; i += 1) {
        var arrayElement = array[i];
        if (arrayElement === searchedNumber) {
            count += 1;
        }
    }

    return count;
}

//solve(["8\n28 6 21 6 -7856 73 73 -56\n73"]);