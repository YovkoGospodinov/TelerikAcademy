function solve(args) {
    var input = args[0].split("\n");
    var arrayLength = +input[0];
    var array = input[1].split(" ").map(Number);

    var index = 0;

    for(var i = 1; i < arrayLength - 1; i += 1) {
        if (array[i] > array[i - 1] && array[i] > array[i + 1]) {
            index += i;
            break;
        }
    }

    if (index === 0) {
        return -1;
    }

    return index;
}